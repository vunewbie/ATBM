ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'CON_NAME'), USER FROM DUAL;
SET SERVEROUTPUT ON;

ALTER TABLE QLTDH.MOMON
ADD (NGAYBD DATE);
UPDATE QLTDH.MOMON 
SET NGAYBD = TO_DATE('01-09-2025', 'DD-MM-YYYY')  --cho nay sua thanh thang 5 nhe
WHERE NAM = 2025 AND HK = 1;
UPDATE QLTDH.MOMON 
SET NGAYBD = TO_DATE('01-01-2026', 'DD-MM-YYYY') 
WHERE NAM = 2025 AND HK = 2;
UPDATE QLTDH.MOMON 
SET NGAYBD = TO_DATE('01-05-2026', 'DD-MM-YYYY') 
WHERE NAM = 2025 AND HK = 3;
SELECT * FROM QLTDH.MOMON where nam=2025; 
select * from qltdh.dangky where mamm='MM1501'

--Cấp quyền trên bảng DANG KY cho các role
GRANT SELECT,INSERT, UPDATE, DELETE ON QLTDH.DANGKY TO SV;
GRANT SELECT, INSERT, UPDATE, DELETE ON QLTDH.DANGKY TO "NV PĐT";
GRANT SELECT ON QLTDH.DANGKY TO "NV PKT";
GRANT UPDATE(DIEMTH, DIEMQT, DIEMCK, DIEMTK) ON QLTDH.DANGKY TO "NV PKT";
GRANT SELECT ON QLTDH.DANGKY TO GV;
GRANT SELECT ON QLTDH.DANGKY TO "NV PĐT";

-- Policy cho SELECT
CREATE OR REPLACE FUNCTION QLTDH.DANGKY_SELECT_POLICY (
    p_schema IN VARCHAR2,
    p_object IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user VARCHAR2(30) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    v_hp VARCHAR2(10);
    v_vaitro VARCHAR2(7);
BEGIN
    -- Nếu người dùng là Quản trị viên (QLTDH), không áp dụng chính sách
    IF v_user = 'QLTDH' THEN
        RETURN '1=1';
    END IF;

    -- Lấy vai trò của người dùng
    SELECT GRANTED_ROLE INTO v_vaitro FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''||UPPER(v_user)||'' AND GRANTED_ROLE NOT IN ('CONNECT', 'RESOURCE');
    
    -- Sinh viên chỉ có thể xem dữ liệu của mình
    IF v_vaitro = 'SV' THEN
        RETURN 'MASV = ''' || v_user || '''';
    END IF;
    -- nv pđt chỉ có thể xem dữ liệu 
    IF v_vaitro IN ('NV PĐT', 'NV PKT') THEN
        RETURN '1=1';
    END IF;
    
    -- giảng viên có quyền xem danh sách lớp, bảng điểm các lớp học phần mà giảng viên đó phụ trách giảng dạy.
    IF v_vaitro = 'GV' THEN
        RETURN 'MAMM IN (SELECT MM.MAMM FROM QLTDH.MOMON MM WHERE MAGV = ''' || v_user || ''')';
    END IF;
    
END;
/

-- Policy cho INSERT, UPDATE, DELETE
CREATE OR REPLACE FUNCTION QLTDH.DANGKY_MODIFY_POLICY (
    p_schema IN VARCHAR2,
    p_object IN VARCHAR2
) RETURN VARCHAR2 AS
    v_user VARCHAR2(30) := SYS_CONTEXT('USERENV', 'SESSION_USER');
    v_vaitro VARCHAR2(7);
    v_hocky_start_date DATE;
    v_current_date DATE := SYSDATE;
    v_momon_id NUMBER;  -- ID của môn học
BEGIN
    -- Nếu người dùng là Quản trị viên (QLTDH), không áp dụng chính sách
    IF v_user = 'QLTDH' THEN
        RETURN '1=1';
    END IF;

    -- Lấy vai trò của người dùng
    SELECT GRANTED_ROLE INTO v_vaitro FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''||UPPER(v_user)||'' AND GRANTED_ROLE NOT IN ('CONNECT', 'RESOURCE');
    
    -- Sinh viên chỉ có thể thao tác với dữ liệu có ngày bắt đầu trong khoảng 14 ngày
    
    IF v_vaitro = 'SV' THEN
        -- Predicate kiểm tra: 
        -- 1. SINHVIEN_ID phải là của user hiện tại
        -- 2. NGAYBD của MOMON_ID trong dòng hiện tại phải nằm trong 14 ngày
        RETURN 'MASV = ''' || v_user || ''' AND EXISTS (
            SELECT 1 
            FROM QLTDH.MOMON MM
            WHERE MM.MAMM = DANGKY.MAMM 
            AND SYSDATE <= NGAYBD + 14
        )';
    END IF;
    
    IF v_vaitro = 'NV PĐT' THEN
        -- Predicate kiểm tra: 
        -- 1. SINHVIEN_ID phải là của user hiện tại
        -- 2. NGAYBD của MOMON_ID trong dòng hiện tại phải nằm trong 14 ngày
        RETURN 'MAMM IN (
            SELECT MM.MAMM
            FROM QLTDH.MOMON MM
            WHERE MM.MAMM = DANGKY.MAMM 
            AND SYSDATE <= NGAYBD + 14
        )';
    END IF;
    
    IF v_vaitro = 'NV PKT' THEN
        RETURN '1=1';
    END IF;

    RETURN '1=0'; -- Mặc định cho các trường hợp khác
END;
/
-- Xóa chính sách VPD nếu tồn tại
BEGIN
    DBMS_RLS.DROP_POLICY (
        object_schema => 'QLTDH',
        object_name   => 'DANGKY',
        policy_name   => 'DANGKY_SELECT_POLICY'
    );
        DBMS_OUTPUT.PUT_LINE('Chính sách VPD DANGKY_SELECT_POLICY đã được xóa.');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -28102 THEN -- Policy không tồn tại
            DBMS_OUTPUT.PUT_LINE('Chính sách VPD DANGKY_SELECT_POLICY không tồn tại.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Lỗi khi xóa chính sách VPD: ' || SQLERRM);
            RAISE;
        END IF;
END;
/
-- Xóa chính sách VPD nếu tồn tại
BEGIN
    DBMS_RLS.DROP_POLICY (
        object_schema => 'QLTDH',
        object_name   => 'DANGKY',
        policy_name   => 'DANGKY_MODIFY_POLICY'
    );
        DBMS_OUTPUT.PUT_LINE('Chính sách VPD DANGKY_MODIFY_POLICY đã được xóa.');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -28102 THEN -- Policy không tồn tại
            DBMS_OUTPUT.PUT_LINE('Chính sách VPD DANGKY_MODIFY_POLICY không tồn tại.');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Lỗi khi xóa chính sách VPD: ' || SQLERRM);
            RAISE;
        END IF;
END;
/
-- Áp dụng các policy
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'QLTDH',
        object_name   => 'DANGKY',
        policy_name   => 'DANGKY_SELECT_POLICY',
        function_schema => 'QLTDH',
        policy_function => 'DANGKY_SELECT_POLICY',
        statement_types => 'SELECT',
        update_check   => TRUE
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema => 'QLTDH',
        object_name   => 'DANGKY',
        policy_name   => 'DANGKY_MODIFY_POLICY',
        function_schema => 'QLTDH',
        policy_function => 'DANGKY_MODIFY_POLICY',
        statement_types => 'INSERT, UPDATE, DELETE',
        update_check   => TRUE
    );
END;
/
--SELECT policy_name
--FROM DBA_POLICIES 
--WHERE OBJECT_NAME = 'DANGKY';


--tẠO TRIGGER ĐỂ ĐẢM BẢO SV/NV pđt thêm dữ liệu trong bảng đăng ký thì điểm luôn NULL
CREATE OR REPLACE TRIGGER TRG_DANGKY_SET_DIEM_NULL
BEFORE INSERT OR UPDATE ON QLTDH.DANGKY
FOR EACH ROW
DECLARE
    v_vaitro VARCHAR2(7);
    v_user VARCHAR2(30) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    -- Lấy vai trò của người dùng
    SELECT GRANTED_ROLE INTO v_vaitro FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''||UPPER(v_user)||'' AND GRANTED_ROLE NOT IN ('CONNECT', 'RESOURCE');

    -- Nếu là NV CTSV, đảm bảo TINHTRANG = NULL
    IF v_vaitro IN('SV', 'NV PĐT') THEN
        IF INSERTING OR 
               UPDATING('DIEMTH') OR UPDATING('DIEMQT') OR 
               UPDATING('DIEMCK') OR UPDATING('DIEMTK') THEN
            :NEW.DIEMTH := NULL;
            :NEW.DIEMQT :=NULL;
            :NEW.DIEMCK :=NULL;
            :NEW.DIEMTK :=NULL;
        END IF;
    END IF;
END;
/

-- Kiểm tra quyền của sinh viên (SV)
CONNECT SV0030/SV0030@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') AS USERNAME FROM DUAL;

-- SELECT: Chỉ thấy dữ liệu của SV0030
SELECT * FROM QLTDH.DANGKY;
-- INSERT: Thêm môn học có ngày bắt đầu trong vòng 14 ngày
INSERT INTO QLTDH.DANGKY(MASV, MAMM, DIEMQT, DIEMTH, DIEMCK, DIEMTK)
VALUES ('SV0030', 'MM1501',9,9,9,9); -- MM1501 phải có NGAYBD trong 14 ngày gần nhất
--kiem tra lai
SELECT * FROM QLTDH.DANGKY;
-- UPDATE: Cập nhật điểm – sẽ bị set NULL do trigger
UPDATE QLTDH.DANGKY SET DIEMTH = 9, DIEMQT = 8 WHERE MASV = 'SV0030' AND MAMM = 'MM1501';
--kiem tra lai
SELECT * FROM QLTDH.DANGKY;
-- DELETE: Được phép nếu trong khoảng 14 ngày (duoc)
DELETE FROM QLTDH.DANGKY WHERE MASV = 'SV0030' AND MAMM = 'MM1501';
--kiem tra lai
SELECT * FROM QLTDH.DANGKY;
-- DELETE: khong duoc
DELETE FROM QLTDH.DANGKY WHERE MASV = 'SV0030' AND MAMM = 'MM0001';
--kiem tra lai
SELECT * FROM QLTDH.DANGKY;
-- Kiểm tra trigger: điểm phải là NULL
SELECT MASV, MAMM, DIEMTH, DIEMQT FROM QLTDH.DANGKY WHERE MASV = 'SV0030';

------------------------------------------------------------

-- Kiểm tra quyền của nhân viên PĐT
CONNECT NVPDT0001/NVPDT0001@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') FROM DUAL;

-- SELECT: Thấy toàn bộ
SELECT * FROM QLTDH.DANGKY;

-- INSERT: Chỉ thành công nếu MAMM có NGAYBD trong vòng 14 ngày
INSERT INTO QLTDH.DANGKY(MASV, MAMM)
VALUES ('SV0031', 'MM124'); -- bi chan

INSERT INTO QLTDH.DANGKY(MASV, MAMM)
VALUES ('SV0031', 'MM1501'); -- duoc

-- UPDATE: Cập nhật điểm -> trigger sẽ set NULL
UPDATE QLTDH.DANGKY SET DIEMCK = 10 WHERE MASV = 'SV0031' AND MAMM = 'MM1501';

select * from QLTDH.DANGKY where MASV='SV0031'
-- DELETE: Được phép nếu MAMM phù hợp
DELETE FROM QLTDH.DANGKY WHERE MASV = 'SV0031' AND MAMM = 'MM0002'; --khong duoc
DELETE FROM QLTDH.DANGKY WHERE MASV = 'SV0031' AND MAMM = 'MM1501'; -- duoc

------------------------------------------------------------

-- Kiểm tra quyền của giảng viên (GV)
CONNECT GV0001/GV0001@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') FROM DUAL;

-- SELECT: Thấy danh sách lớp mình giảng dạy
SELECT * FROM QLTDH.DANGKY ;
------------------------------------------------------------

--grant "NV PKT" to NVPKT0001
-- Kiểm tra quyền của NV PKT
CONNECT NVPKT0001/NVPKT0001@localhost:1521/QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'SESSION_USER') FROM DUAL;

-- SELECT: Thấy toàn bộ
SELECT * FROM QLTDH.DANGKY;

SELECT * FROM QLTDH.DANGKY WHERE MASV='SV0030';
-- UPDATE điểm được phép (theo GRANT cụ thể)
UPDATE QLTDH.DANGKY SET DIEMTH = 6, DIEMCK = 7 WHERE MASV = 'SV0030' AND MAMM = 'MM0001';

-- INSERT/DELETE: không được phép (do khoong co quyen)



