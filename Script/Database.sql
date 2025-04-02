-- Đảm bảo đang ở ROOT
ALTER SESSION SET CONTAINER = CDB$ROOT;

-- Để hiển thị output
SET SERVEROUTPUT ON;

-- Kiểm tra kết nối
SELECT SYS_CONTEXT('USERENV', 'CON_NAME') FROM DUAL;
SELECT USER FROM DUAL;

-- Kiểm tra nếu dba đã được tạo
DECLARE
    -- Biến kiểm tra sự tồn tại của người dùng
    user_exists INTEGER;
BEGIN
    -- Kiểm tra sự tồn tại của người dùng QLTDH trong cơ sở dữ liệu
    SELECT COUNT(*) INTO user_exists
    FROM all_users
    WHERE username = 'C##QLTDH';

    -- Nếu người dùng tồn tại, thực hiện các thao tác
    IF user_exists > 0 THEN
        -- Thu hồi quyền DBA nếu người dùng có quyền này
        BEGIN
            EXECUTE IMMEDIATE 'REVOKE DBA FROM C##QLTDH';
        EXCEPTION
            WHEN OTHERS THEN
                NULL; -- Bỏ qua nếu không có quyền DBA
        END;

        -- Xóa người dùng và tất cả các đối tượng liên quan
        EXECUTE IMMEDIATE 'DROP USER C##QLTDH CASCADE';
        DBMS_OUTPUT.PUT_LINE('Người dùng C##QLTDH đã được xóa.');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Người dùng C##QLTDH không tồn tại.');
    END IF;
END;
/

-- Kiểm tra đã xóa thành công chưa (nếu có).
SELECT * FROM DBA_USERS WHERE USERNAME = 'C##QLTDH';

-- Tạo một admin
CREATE USER C##QLTDH IDENTIFIED BY admin123;

-- Cấp quyền dba
-- USER SQL
ALTER USER "C##QLTDH"
DEFAULT TABLESPACE "SYSTEM"
TEMPORARY TABLESPACE "TEMP"
ACCOUNT UNLOCK 
ENABLE EDITIONS ;

-- QUOTAS

-- ROLES
GRANT "DBA" TO "C##QLTDH" WITH ADMIN OPTION;
GRANT "CONNECT" TO "C##QLTDH" WITH ADMIN OPTION;
GRANT "RESOURCE" TO "C##QLTDH" WITH ADMIN OPTION;
ALTER USER "C##QLTDH" DEFAULT ROLE "DBA","PDB_DBA";

-- SYSTEM PRIVILEGES
GRANT CREATE USER, CREATE ROLE, CREATE TRIGGER, CREATE VIEW, CREATE SESSION, CREATE SEQUENCE TO "C##QLTDH" ;
GRANT ALTER USER, ALTER ANY ROLE, ALTER ANY TRIGGER, ALTER SESSION, ALTER ANY SEQUENCE TO "C##QLTDH" ;
GRANT DROP USER, DROP ANY ROLE, DROP ANY TRIGGER, DROP ANY VIEW, DROP ANY SEQUENCE TO "C##QLTDH" ;
GRANT SELECT ANY DICTIONARY TO "C##QLTDH" ;
GRANT UNLIMITED TABLESPACE TO "C##QLTDH" ;

-- Kiểm tra các vai trò đã cấp
SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'C##QLTDH';

-- Kiểm tra các quyền hệ thống đã cấp
SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'C##QLTDH';