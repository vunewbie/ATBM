-- Cho phân hệ 2
-- CONNECT C##QLTDH/admin123@localhost:1521/XE;

-- Kiểm tra kết nối
SELECT SYS_CONTEXT('USERENV', 'CON_NAME') FROM DUAL;
SELECT USER FROM DUAL;

-- Kiểm tra tất cả procedures đã được tạo cho XE
SELECT OWNER, OBJECT_NAME, OBJECT_TYPE
FROM DBA_OBJECTS
WHERE OWNER = 'SYS' AND OBJECT_TYPE = 'PROCEDURE'
ORDER BY CREATED DESC;

-- Xóa toàn bộ procedures đã được tạo bởi C##QLTDH - Phân hệ 2
BEGIN
    FOR rec IN (
        SELECT OBJECT_NAME
        FROM ALL_OBJECTS
        WHERE OBJECT_TYPE = 'PROCEDURE'
          AND OWNER = 'C##QLTDH'
    ) LOOP
        BEGIN
            EXECUTE IMMEDIATE 'DROP PROCEDURE C##QLTDH.' || rec.OBJECT_NAME;
            DBMS_OUTPUT.PUT_LINE('Thủ tục ' || rec.OBJECT_NAME || ' đã được xóa.');
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Lỗi khi xóa thủ tục ' || rec.OBJECT_NAME || ': ' || SQLERRM);
        END;
    END LOOP;
END;
/

-- Lấy danh sách người dùng
-- DROP PROCEDURE GET_USER_LIST;
CREATE OR REPLACE PROCEDURE GET_USER_LIST (users_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN users_cursor FOR
    SELECT USER_ID, USERNAME, ACCOUNT_STATUS, CREATED 
    FROM DBA_USERS 
    ORDER BY ACCOUNT_STATUS DESC;
END;
/

-- DROP PROCEDURE CHECK_USER_EXISTS;
-- Kiểm tra người dùng có tồn tại
CREATE OR REPLACE PROCEDURE CHECK_USER_EXISTS (
    p_username IN VARCHAR2,
    p_exists OUT VARCHAR2
) 
AS
BEGIN
    -- Kiểm tra xem người dùng có tồn tại không
    SELECT CASE WHEN COUNT(*) > 0 THEN 'TRUE' ELSE 'FALSE' END
    INTO p_exists
    FROM DBA_USERS
    WHERE USERNAME = p_username;
END;
/

-- Tạo User (Trên áp nhớ thêm tiền tố "C##" khi test)
-- DROP PROCEDURE CREATE_USER;
CREATE OR REPLACE PROCEDURE CREATE_USER (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
) 
AS
BEGIN
    -- Tạo tài khoản và cấp quyền đăng nhập
    EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY ' || p_password;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || p_username;
END;
/

-- Xóa User
-- DROP PROCEDURE DELETE_USER;
CREATE OR REPLACE PROCEDURE DELETE_USER(
    p_username IN VARCHAR2
)
AS
BEGIN
    -- Xóa tài khoản
    EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';
END;
/

-- Cập nhật status cho user
-- DROP PROCEDURE UPDATE_USER_STATUS;
CREATE OR REPLACE PROCEDURE UPDATE_USER_STATUS (
    p_username IN VARCHAR2,
    p_new_status IN VARCHAR2
) 
AS  
BEGIN
    -- Cập nhật trạng thái tài khoản (thêm dấu chấm phẩy ở cuối)
    EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' ACCOUNT ' || p_new_status;
END;
/

-- Tìm kiếm người dùng
-- DROP PROCEDURE SEARCH_USER;
CREATE OR REPLACE PROCEDURE SEARCH_USER (
    p_username IN VARCHAR2,
    users_cursor OUT SYS_REFCURSOR
) 
AS
BEGIN
    OPEN users_cursor FOR
    SELECT USER_ID, USERNAME, ACCOUNT_STATUS, CREATED
    FROM DBA_USERS
    WHERE USERNAME LIKE '%' || p_username || '%'
    ORDER BY ACCOUNT_STATUS DESC;
END;
/

-- Lấy danh sách các Role
-- DROP PROCEDURE GET_ROLE_LIST;
CREATE OR REPLACE PROCEDURE GET_ROLE_LIST (roles_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN roles_cursor FOR
    SELECT ROLE_ID, ROLE, PASSWORD_REQUIRED
    FROM DBA_ROLES
    ORDER BY PASSWORD_REQUIRED DESC;
END;
/

-- Kiểm tra xem Role có tồn tại không
-- DROP PROCEDURE CHECK_ROLE_EXISTS;
CREATE OR REPLACE PROCEDURE CHECK_ROLE_EXISTS (
    p_role IN VARCHAR2,
    p_exists OUT VARCHAR2
) 
AS
BEGIN
    -- Kiểm tra xem Role có tồn tại không
    SELECT CASE WHEN COUNT(*) > 0 THEN 'TRUE' ELSE 'FALSE' END
    INTO p_exists
    FROM DBA_ROLES
    WHERE ROLE = p_role;
END;
/

-- Tạo vai trò mới
-- DROP PROCEDURE CREATE_ROLE;
CREATE OR REPLACE PROCEDURE CREATE_ROLE(
  p_role IN VARCHAR2,
  p_password IN VARCHAR2 DEFAULT NULL
)
AS
BEGIN
  IF p_password IS NULL THEN
    EXECUTE IMMEDIATE ('CREATE ROLE ' || p_role); -- PASSWORD_REQUIRED = "NO"
  ELSE
    EXECUTE IMMEDIATE ('CREATE ROLE ' || p_role || ' IDENTIFIED BY ' || p_password); -- PASSWORD_REQUIRED = "YES"
  END IF;
END;
/

-- Xóa Role
-- DROP PROCEDURE DELETE_ROLE;
CREATE OR REPLACE PROCEDURE DELETE_ROLE(
    p_role IN VARCHAR2
)
AS
BEGIN
    -- Xóa Role
    EXECUTE IMMEDIATE 'DROP ROLE ' || p_role;
END;
/

-- Cập nhật mật khẩu cho role
-- DROP PROCEDURE UPDATE_ROLE_PASSWORD;
CREATE OR REPLACE PROCEDURE UPDATE_ROLE_PASSWORD (
    p_role IN VARCHAR2,
    p_password IN VARCHAR2
) 
AS  
BEGIN
    -- Cập nhật password cho Role
    EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role || ' IDENTIFIED BY ' || p_password;
END UPDATE_ROLE_PASSWORD;
/

-- Tìm kiếm Role
-- DROP PROCEDURE SEARCH_ROLE;
CREATE OR REPLACE PROCEDURE SEARCH_ROLE (
    p_role IN VARCHAR2,
    roles_cursor OUT SYS_REFCURSOR
) 
AS
BEGIN
    OPEN roles_cursor FOR
    SELECT ROLE_ID, ROLE, PASSWORD_REQUIRED
    FROM DBA_ROLES
    WHERE ROLE LIKE '%' || p_role || '%'
    ORDER BY ROLE;
END;
/






