-- Đảm bảo đang ở ROOT
ALTER SESSION SET CONTAINER = CDB$ROOT;

-- Để hiển thị output
SET SERVEROUTPUT ON;

-- Kiểm tra nếu PDB đã tồn tại
DECLARE
    pdb_exists INTEGER;
BEGIN
    -- Kiểm tra sự tồn tại của PDB
    SELECT COUNT(*) INTO pdb_exists
    FROM v$pdbs
    WHERE name = 'QUANLYTRUONGDAIHOC';
    
    -- Nếu PDB tồn tại, tiến hành xóa
    IF pdb_exists > 0 THEN
        -- Đóng PDB nếu nó đang mở
        EXECUTE IMMEDIATE 'ALTER PLUGGABLE DATABASE QUANLYTRUONGDAIHOC CLOSE IMMEDIATE';
        
        -- Xóa PDB cùng với các file dữ liệu
        EXECUTE IMMEDIATE 'DROP PLUGGABLE DATABASE QUANLYTRUONGDAIHOC INCLUDING DATAFILES';
        DBMS_OUTPUT.PUT_LINE('PDB QUANLYTRUONGDAIHOC đã được xóa.');
    ELSE
        DBMS_OUTPUT.PUT_LINE('PDB QUANLYTRUONGDAIHOC không tồn tại.');
    END IF;
END;
/

-- Kiểm tra đã xóa pdb thành công chưa(nếu có).
select pdb_name from dba_pdbs;

-- Kiểm tra nếu dba đã được tạo
DECLARE
    -- Biến kiểm tra sự tồn tại của người dùng
    user_exists INTEGER;
BEGIN
    -- Kiểm tra sự tồn tại của người dùng QLTDH trong cơ sở dữ liệu
    SELECT COUNT(*) INTO user_exists
    FROM all_users
    WHERE username = 'QLTDH';

    -- Nếu người dùng tồn tại, thực hiện các thao tác
    IF user_exists > 0 THEN
        -- Thu hồi quyền DBA nếu người dùng có quyền này
        BEGIN
            EXECUTE IMMEDIATE 'REVOKE DBA FROM QLTDH';
        EXCEPTION
            WHEN OTHERS THEN
                NULL; -- Bỏ qua nếu không có quyền DBA
        END;

        -- Xóa người dùng và tất cả các đối tượng liên quan
        EXECUTE IMMEDIATE 'DROP USER QLTDH CASCADE';
        DBMS_OUTPUT.PUT_LINE('Người dùng QLTDH đã được xóa.');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Người dùng QLTDH không tồn tại.');
    END IF;
END;
/

-- Kiểm tra đã xóa thành công chưa (nếu có).
SELECT * FROM DBA_USERS WHERE USERNAME = 'QLTDH';

-- Tạo database
CREATE PLUGGABLE DATABASE QUANLYTRUONGDAIHOC
  ADMIN USER QLTDH IDENTIFIED BY admin123
  FILE_NAME_CONVERT = ('C:\app\vuloc\product\21c\oradata\XE\pdbseed', 'C:\app\vuloc\product\21c\oradata\XE\pdbseed\project');
  
-- Mở kết nối đến database
ALTER PLUGGABLE DATABASE QUANLYTRUONGDAIHOC OPEN;  
ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Kiểm tra kết nối
SELECT SYS_CONTEXT('USERENV', 'CON_NAME') FROM DUAL;
SELECT USER FROM DUAL;

-- Cấp quyền dba
-- USER SQL
ALTER USER "QLTDH"
DEFAULT TABLESPACE "SYSTEM"
TEMPORARY TABLESPACE "TEMP"
ACCOUNT UNLOCK 
ENABLE EDITIONS ;

-- QUOTAS

-- ROLES
GRANT "DBA" TO "QLTDH" WITH ADMIN OPTION;
GRANT "CONNECT" TO "QLTDH" WITH ADMIN OPTION;
GRANT "RESOURCE" TO "QLTDH" WITH ADMIN OPTION;
ALTER USER "QLTDH" DEFAULT ROLE "DBA","PDB_DBA";

-- SYSTEM PRIVILEGES
GRANT CREATE USER, CREATE ROLE, CREATE TRIGGER, CREATE VIEW, CREATE SESSION, CREATE SEQUENCE TO "QLTDH" ;
GRANT ALTER USER, ALTER ANY ROLE, ALTER ANY TRIGGER, ALTER SESSION, ALTER ANY SEQUENCE TO "QLTDH" ;
GRANT DROP USER, DROP ANY ROLE, DROP ANY TRIGGER, DROP ANY VIEW, DROP ANY SEQUENCE TO "QLTDH" ;
GRANT SELECT ANY DICTIONARY TO "QLTDH" ;
GRANT UNLIMITED TABLESPACE TO "QLTDH" ;

-- Kiểm tra các vai trò đã cấp
SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'QLTDH';

-- Kiểm tra các quyền hệ thống đã cấp
SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'QLTDH';