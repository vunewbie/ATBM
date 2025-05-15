ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Thêm cột NGAYBD vào bảng MOMON
ALTER TABLE QLTDH.MOMON
ADD (NGAYBD DATE);

UPDATE QLTDH.MOMON 
SET NGAYBD = TO_DATE('01-09-2025', 'DD-MM-YYYY')
WHERE NAM = 2025 AND HK = 1;

UPDATE QLTDH.MOMON 
SET NGAYBD = TO_DATE('01-01-2026', 'DD-MM-YYYY') 
WHERE NAM = 2025 AND HK = 2;

UPDATE QLTDH.MOMON 
SET NGAYBD = TO_DATE('01-05-2026', 'DD-MM-YYYY') 
WHERE NAM = 2025 AND HK = 3;


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
    IF v_user IN ('SYS', 'QLTDH') THEN
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
    IF v_user IN ('SYS', 'QLTDH') THEN
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
            WHERE MM.MAMM = MAMM 
            AND SYSDATE <= MM.NGAYBD + 14
        )';
    END IF;
    
    IF v_vaitro = 'NV PĐT' THEN
        -- Predicate kiểm tra: 
        -- 1. SINHVIEN_ID phải là của user hiện tại
        -- 2. NGAYBD của MOMON_ID trong dòng hiện tại phải nằm trong 14 ngày
        RETURN 'MAMM IN (
            SELECT MM.MAMM
            FROM QLTDH.MOMON MM
            WHERE MM.MAMM = MAMM 
            AND SYSDATE <= MM.NGAYBD + 14
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

--drop trigger sys.TRG_DANGKY_SET_DIEM_NULL
--Tạo TRIGGER để đảm bảo SV/NV PĐT thêm dữ liệu trong bảng đăng ký thì điểm luôn NULL
CREATE OR REPLACE TRIGGER TRG_DANGKY_SET_DIEM_NULL
BEFORE INSERT OR UPDATE ON QLTDH.DANGKY
FOR EACH ROW
DECLARE
    v_vaitro VARCHAR2(7);
    v_user VARCHAR2(30) := SYS_CONTEXT('USERENV', 'SESSION_USER');
BEGIN
    -- Nếu user là SYS hoặc QLTDH (người định nghĩa trigger), thì bỏ qua luôn
    IF v_user IN ('SYS', 'QLTDH') THEN
        RETURN;
    END IF;
    
    -- Lấy vai trò của người dùng
    SELECT GRANTED_ROLE INTO v_vaitro FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''||UPPER(v_user)||'' AND GRANTED_ROLE NOT IN ('CONNECT', 'RESOURCE');
    DBMS_OUTPUT.PUT_LINE('Vai trò người dùng 1: ' || v_vaitro);

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


--grant "NV PKT" to NVPKT0001
----NVPKT0001
UPDATE QLTDH.DANGKY SET DIEMTH = 10, DIEMCK = 7 WHERE MASV = 'SV0030' AND MAMM = 'MM0001';
select * from QLTDH.DANGKY where MASV = 'SV0030'