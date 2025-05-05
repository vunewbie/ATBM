ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;
SELECT SYS_CONTEXT('USERENV', 'CON_NAME'), USER FROM DUAL;
SET SERVEROUTPUT ON;

-- Xóa các role nếu tồn tại
DECLARE
    v_role_exists NUMBER;
    TYPE role_array IS TABLE OF VARCHAR2(20);
    roles role_array := role_array('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV TCHC', 'NV CTSV', 'TRGĐV');
BEGIN
    FOR i IN 1..roles.COUNT LOOP
        -- Kiểm tra xem role có tồn tại không
        SELECT COUNT(*) INTO v_role_exists 
        FROM DBA_ROLES 
        WHERE ROLE = roles(i);
        
        -- Nếu role tồn tại thì xóa
        IF v_role_exists > 0 THEN
            EXECUTE IMMEDIATE 'DROP ROLE "' || roles(i) || '"';
            DBMS_OUTPUT.PUT_LINE('Role ' || roles(i) || ' đã được xóa thành công');
        ELSE
            DBMS_OUTPUT.PUT_LINE('Role ' || roles(i) || ' không tồn tại');
        END IF;
    END LOOP;
END;
/

-- Tạo các role
BEGIN
  FOR r IN (SELECT column_value AS role_name FROM TABLE(sys.dbms_debug_vc2coll('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV TCHC', 'NV CTSV', 'TRGĐV'))) LOOP
    EXECUTE IMMEDIATE 'CREATE ROLE "' || r.role_name || '"';
  END LOOP;
END;
/

-- Kiểm tra xem các role đã được tạo chưa
SELECT * FROM DBA_ROLES WHERE COMMON = 'NO';

-- Xóa các user nếu tồn tại
DECLARE
    v_user_exists NUMBER;
    TYPE user_array IS TABLE OF VARCHAR2(30);
    users user_array := user_array(
        'NVCB0001', 'GV0001', 'NVPDT0001', 'NVPKT0001',
        'NVTCHC0001', 'NVCTSV0001', 'TRGDV0001'
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
            DBMS_OUTPUT.PUT_LINE('User ' || users(i) || ' đã được xóa thành công');
        ELSE
            DBMS_OUTPUT.PUT_LINE('User ' || users(i) || ' không tồn tại');
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
END;
/

-- Kiểm tra xem các user đã được tạo chưa
SELECT * FROM DBA_USERS WHERE COMMON = 'NO';

-- Cấp role cho các user tương ứng
BEGIN
    QLTDH.GRANT_ROLE_TO_USER('NVCB0001', 'NVCB', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('GV0001', 'GV', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVPDT0001', 'NV PĐT', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVPKT0001', 'NV PKT', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVTCHC0001', 'NV TCHC', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('NVCTSV0001', 'NV CTSV', FALSE);
    QLTDH.GRANT_ROLE_TO_USER('TRGDV0001', 'TRGĐV', FALSE);
END;
/

-- Kiểm tra các role đã cấp
SELECT * 
FROM DBA_ROLE_PRIVS 
WHERE GRANTEE IN ('NVCB0001', 'GV0001', 'NVPDT0001', 'NVPKT0001', 'NVTCHC0001', 'NVCTSV0001', 'TRGDV0001')
ORDER BY GRANTEE;

-- Xóa view nếu đã tồn tại
BEGIN
    EXECUTE IMMEDIATE 'DROP VIEW QLTDH.EMPLOYEE_GET_PERSONAL_INFO';
    DBMS_OUTPUT.PUT_LINE('View QLTDH.EMPLOYEE_GET_PERSONAL_INFO đã được xóa.');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -942 THEN
            DBMS_OUTPUT.PUT_LINE('View QLTDH.EMPLOYEE_GET_PERSONAL_INFO không tồn tại.');
        ELSE
            RAISE;
        END IF;
END;
/

-- Tạo view để nhân viên xem thông tin cá nhân của mình
CREATE OR REPLACE VIEW QLTDH.EMPLOYEE_GET_PERSONAL_INFO 
AS
    SELECT *
    FROM QLTDH.NHANVIEN 
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');

-- Xóa procedure nếu đã tồn tại
BEGIN
    EXECUTE IMMEDIATE 'DROP PROCEDURE QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER';
    DBMS_OUTPUT.PUT_LINE('Procedure QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER đã được xóa.');
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -942 THEN
            DBMS_OUTPUT.PUT_LINE('Procedure QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER không tồn tại.');
        ELSE
            RAISE;
        END IF;
END;
/

-- Tạo procedure để nhân viên cập nhật số điện thoại của mình
CREATE OR REPLACE PROCEDURE QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER (
    p_new_dt IN VARCHAR2
)
AS
BEGIN
    UPDATE QLTDH.NHANVIEN
    SET DT = p_new_dt
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
    COMMIT;
END;
/

-- Cấp quyền cho tất cả các nhân viên
GRANT SELECT ON QLTDH.EMPLOYEE_GET_PERSONAL_INFO TO "NVCB", "GV", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "TRGĐV";
GRANT EXECUTE ON QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER TO "NVCB", "GV", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "TRGĐV";

SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE IN ('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV TCHC', 'NV CTSV', 'TRGĐV');
SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE IN ('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV TCHC', 'NV CTSV', 'TRGĐV');