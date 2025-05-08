ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Xóa các role nếu tồn tại
DECLARE
    v_role_exists NUMBER;
    TYPE role_array IS TABLE OF VARCHAR2(20);
    roles role_array := role_array('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV TCHC', 'NV CTSV', 'TRGĐV', 'SV');
BEGIN
    FOR i IN 1..roles.COUNT LOOP
        -- Kiểm tra xem role có tồn tại không
        SELECT COUNT(*) INTO v_role_exists 
        FROM DBA_ROLES 
        WHERE ROLE = roles(i);
        
        -- Nếu role tồn tại thì xóa
        IF v_role_exists > 0 THEN
            EXECUTE IMMEDIATE 'DROP ROLE "' || roles(i) || '"';
        END IF;
    END LOOP;
END;
/

-- Tạo các role
BEGIN
  FOR r IN (SELECT column_value AS role_name FROM TABLE(sys.dbms_debug_vc2coll('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV TCHC', 'NV CTSV', 'TRGĐV', 'SV'))) LOOP
    EXECUTE IMMEDIATE 'CREATE ROLE "' || r.role_name || '"';
  END LOOP;
END;
/

-- Xóa các user nếu tồn tại
DECLARE
    v_user_exists NUMBER;
    TYPE user_array IS TABLE OF VARCHAR2(30);
    users user_array := user_array(
        'NVCB0001', 'GV0001', 'NVPDT0001', 'NVPKT0001',
        'NVTCHC0001', 'NVCTSV0001', 'TRGDV0001', 'SV0030'
    );
BEGIN
    FOR i IN 1..users.COUNT LOOP
        -- Kiểm tra xem user có tồn tại không
        SELECT COUNT(*) INTO v_user_exists
        FROM DBA_USERS
        WHERE USERNAME = users(i);

        -- Nếu user tồn tại thì xóa
        IF v_user_exists > 0 THEN
            EXECUTE IMMEDIATE 'DROP USER "' || users(i) || '" CASCADE';
        END IF;
    END LOOP;
END;
/

-- Tạo các user
BEGIN
    QLTDH.CREATE_USER('NVCB0001', 'NVCB0001');
    QLTDH.CREATE_USER('GV0001', 'GV0001');
    QLTDH.CREATE_USER('NVPDT0001', 'NVPDT0001');
    QLTDH.CREATE_USER('NVPKT0001', 'NVPKT0001');
    QLTDH.CREATE_USER('NVTCHC0001', 'NVTCHC0001');
    QLTDH.CREATE_USER('NVCTSV0001', 'NVCTSV0001');
    QLTDH.CREATE_USER('TRGDV0001', 'TRGDV0001');
    QLTDH.CREATE_USER('SV0030', 'SV0030');
END;
/

-- Cấp role cho các user tương ứng
BEGIN
    QLTDH.GRANT_ROLE_TO_USER('NVCB0001', 'NVCB', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('GV0001', 'GV', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVPDT0001', 'NV PĐT', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVPKT0001', 'NV PKT', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVTCHC0001', 'NV TCHC', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVCTSV0001', 'NV CTSV', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('TRGDV0001', 'TRGĐV', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('SV0030', 'SV', FALSE);
END;
/

-- Nhân viên có quyền xem thông tin cá nhân
-- Tạo view để nhân viên xem thông tin cá nhân của mình
CREATE OR REPLACE VIEW QLTDH.EMPLOYEE_GET_PERSONAL_INFO 
AS
    SELECT *
    FROM QLTDH.NHANVIEN 
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');

-- Cấp quyền cho tất cả các nhân viên
GRANT SELECT ON QLTDH.EMPLOYEE_GET_PERSONAL_INFO TO "NVCB", "GV", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "TRGĐV";


-- Nhân viên chỉ có thể cập nhật số điện thoại
-- Tạo procedure để nhân viên cập nhật số điện thoại của mình
CREATE OR REPLACE PROCEDURE QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER (
    p_new_phone_number IN VARCHAR2
)
AS
BEGIN
    UPDATE QLTDH.NHANVIEN
    SET DT = p_new_phone_number
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
    COMMIT;
END;
/

-- Cấp quyền thực thi procedure cho các role
GRANT EXECUTE ON QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER TO "NVCB", "GV", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "TRGĐV";


-- Trưởng đơn vị có quyền xem thông tin nhân viên trong đơn vị
-- Tạo view để trưởng đơn vị xem thông tin nhân viên trong đơn vị
CREATE OR REPLACE VIEW QLTDH.EMPLOYEE_UNIT_INFO 
AS
    SELECT NV.MANV, NV.HOTEN, NV.PHAI, NV.NGSINH, NV.DT, NV.VAITRO, NV.MADV
    FROM QLTDH.NHANVIEN NV
    WHERE NV.MADV = (
        SELECT MADV 
        FROM QLTDH.NHANVIEN 
        WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER'));

-- Cấp quyền cho role TRGĐV
GRANT SELECT ON QLTDH.EMPLOYEE_UNIT_INFO TO "TRGĐV";


-- Nhân viên TCHC có quyền CRUD trên bảng NHANVIEN
-- Cấp quyền cho role NV TCHC
GRANT SELECT, INSERT, UPDATE, DELETE ON QLTDH.NHANVIEN TO "NV TCHC";