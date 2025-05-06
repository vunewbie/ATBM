ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'CON_NAME'), USER FROM DUAL;
SET SERVEROUTPUT ON;

--Sinh viên có thể xem dòng dữ liệu liên quan đến chính mình, có thể sửa các trường địachỉ (ĐCHI), số điện thoại (ĐT) liên quan đến chính mình.
--Người dùng có vai trò “NV PCTSV” có thể thêm, xóa, sửa thông tin trên quan hệ SINHVIEN. Tuy nhiên, trường TINHTRANG mang giá trị NULL cho đến khi người 
--dùng với vai trò “NV PĐT” cập nhật thành giá trị mới, cho biết tình trạng học vụ của sinh viên.
--Người dùng có vai trò “GV” được xem danh sách sinh viên thuộc đơn vị (khoa) mà giảng viên trực thuộc.
-- Tạo hàm policy cho bảng SINHVIEN
CREATE OR REPLACE FUNCTION QLTDH.SINHVIEN_VPD_POLICY (
    p_schema IN VARCHAR2,
    p_object IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user VARCHAR2(10) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    v_vaitro VARCHAR2(7);
    v_madv VARCHAR2(10);
    v_count NUMBER;
BEGIN
    IF v_user = 'QLTDH' THEN
        RETURN '1=1';
    END IF;

    -- Kiểm tra nếu là sinh viên
    SELECT GRANTED_ROLE INTO v_vaitro FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''||UPPER(v_user)||'' AND GRANTED_ROLE NOT IN ('CONNECT', 'RESOURCE');
    -- Kiểm tra nếu user có role SINHVIEN
    IF v_vaitro = 'SV' THEN
    DBMS_OUTPUT.PUT_LINE('User: ' || v_user || ', Vai trò: ' || v_vaitro || ', MADV: ' || v_madv);
        RETURN 'MASV = ''' || v_user || '''';
    END IF;

    -- Kiểm tra nếu có role NV CTSV hoặc NV PĐT
    IF v_vaitro IN ('NV CTSV', 'NV PĐT') THEN
        RETURN '1=1';
    END IF;

    -- Nếu có role GV → lấy khoa (mã đơn vị) từ bảng nhân viên
    IF v_vaitro = 'GV' THEN
        BEGIN
            SELECT MADV INTO v_madv FROM QLTDH.NHANVIEN WHERE MANV = v_user;
            RETURN 'KHOA = ''' || v_madv || '''';
        EXCEPTION
            WHEN NO_DATA_FOUND THEN
                RETURN '1=0';
        END;
    END IF;
    -- Mặc định không truy cập
    RETURN '1=0';
END;
/

-- Tạo chính sách VPD cho bảng SINHVIEN
-- Xóa chính sách VPD nếu tồn tại
BEGIN
    DBMS_RLS.DROP_POLICY (
        object_schema => 'QLTDH',
        object_name   => 'SINHVIEN',
        policy_name   => 'SINHVIEN_ACCESS_POLICY'
    );
        DBMS_OUTPUT.PUT_LINE('Chính sách VPD SINHVIEN_ACCESS_POLICY đã được xóa.');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -28102 THEN -- Policy không tồn tại
            DBMS_OUTPUT.PUT_LINE('Chính sách VPD SINHVIEN_ACCESS_POLICY không tồn tại.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Lỗi khi xóa chính sách VPD: ' || SQLERRM);
            RAISE;
        END IF;
END;
/
--tạo chính sách vpd
BEGIN
    DBMS_RLS.ADD_POLICY (
        object_schema   => 'QLTDH',
        object_name     => 'SINHVIEN',
        policy_name     => 'SINHVIEN_ACCESS_POLICY',
        function_schema => 'QLTDH',
        policy_function => 'SINHVIEN_VPD_POLICY',
        statement_types  => 'SELECT, INSERT, UPDATE, DELETE',
        update_check    => TRUE
    );
    DBMS_OUTPUT.PUT_LINE('Chính sách VPD SINHVIEN_ACCESS_POLICY đã được tạo.');
END;
/

-- Tạo trigger để đảm bảo TINHTRANG = NULL khi NV CTSV thêm/sửa
CREATE OR REPLACE TRIGGER QLTDH.SINHVIEN_TINHTRANG_CHECK
BEFORE INSERT OR UPDATE ON QLTDH.SINHVIEN
FOR EACH ROW
DECLARE
    v_vaitro VARCHAR2(7);
    v_user VARCHAR2(30) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    -- Lấy vai trò của người dùng
    BEGIN
        SELECT VAITRO INTO v_vaitro
        FROM QLTDH.NHANVIEN
        WHERE MANV = v_user;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            v_vaitro := 'SINHVIEN'; -- Giả định là sinh viên nếu không tìm thấy trong NHANVIEN
    END;

    -- Nếu là NV CTSV, đảm bảo TINHTRANG = NULL
    IF v_vaitro = 'NV CTSV' THEN
        :NEW.TINHTRANG := NULL;
        DBMS_OUTPUT.PUT_LINE('User ' || v_user || ' (NV CTSV) đặt TINHTRANG = NULL.');
    END IF;
END;
/

-- Cấp quyền cho các role
GRANT SELECT, UPDATE(DCHI, DT) ON QLTDH.SINHVIEN TO SV;
GRANT SELECT, INSERT, UPDATE, DELETE ON QLTDH.SINHVIEN TO "NV CTSV";
GRANT SELECT ON QLTDH.SINHVIEN TO GV;
GRANT SELECT ON QLTDH.SINHVIEN TO "NV PĐT";
-- Bổ sung quyền cho NV PĐT để cập nhật TINHTRANG
GRANT UPDATE(TINHTRANG) ON QLTDH.SINHVIEN TO "NV PĐT";
-- Kiểm tra chính sách VPD
-- Kiểm tra quyền của sinh viên
CONNECT SV0030/SV0030@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT * FROM QLTDH.SINHVIEN; -- Chỉ thấy dòng của mình
UPDATE QLTDH.SINHVIEN SET DCHI = '456 Hanoi' WHERE MASV = 'SV0030'; -- Được phép
UPDATE QLTDH.SINHVIEN SET HOTEN = 'Test' WHERE MASV = 'SV0030'; -- Không được phép
SELECT * FROM QLTDH.SINHVIEN WHERE MASV = 'SV0030';
-- Kiểm tra quyền của NV CTSV
CONNECT NVCTSV0001/NVCTSV0001@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT * FROM QLTDH.SINHVIEN; -- Thấy tất cả
INSERT INTO QLTDH.SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, KHOA, TINHTRANG)
VALUES ('SV9999', 'Test SV', 'Nam', TO_DATE('2000-01-01', 'YYYY-MM-DD'), 'Hanoi', '0999999999', 'CNT', 'Đang học'); -- TINHTRANG sẽ thành NULL
SELECT * FROM QLTDH.SINHVIEN WHERE MASV = 'SV9999';
-- Kiểm tra quyền của GV
CONNECT GV0001/GV0001@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'CON_NAME'), USER FROM DUAL;
SELECT * FROM QLTDH.SINHVIEN; -- Chỉ thấy sinh viên thuộc khoa của mình

-- Kiểm tra quyền của NV PĐT
CONNECT NVPDT0001/NVPDT0001@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'CON_NAME'), USER FROM DUAL;
UPDATE QLTDH.SINHVIEN SET TINHTRANG = 'Đang học' WHERE MASV = 'SV9999'; -- Được phép
SELECT * FROM QLTDH.SINHVIEN WHERE MASV = 'SV9999';


