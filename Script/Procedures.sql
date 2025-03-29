-- Mở kết nối đến database
ALTER PLUGGABLE DATABASE QUANLYTRUONGDAIHOC OPEN;  
ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Kiểm tra kết nối
SELECT SYS_CONTEXT('USERENV', 'CON_NAME') FROM DUAL;
SELECT USER FROM DUAL;

-- Kiểm tra các procedures đã được tạo bởi QLTDH, lưu ý: thủ tục được tạo bởi "QLTDH" nên cũng cần gán quyền
SELECT OBJECT_NAME
FROM DBA_PROCEDURES
WHERE OBJECT_TYPE = 'PROCEDURE' 
AND OWNER = 'QLTDH';

-- Xóa toàn bộ procedures đã được tạo bởi QLTDH
BEGIN
    FOR rec IN (
        SELECT OBJECT_NAME
        FROM ALL_OBJECTS
        WHERE OBJECT_TYPE = 'PROCEDURE'
          AND OWNER = 'QLTDH'
    ) LOOP
        BEGIN
            EXECUTE IMMEDIATE 'DROP PROCEDURE QLTDH.' || rec.OBJECT_NAME;
            DBMS_OUTPUT.PUT_LINE('Thủ tục ' || rec.OBJECT_NAME || ' đã được xóa.');
        EXCEPTION
            WHEN OTHERS THEN
                DBMS_OUTPUT.PUT_LINE('Lỗi khi xóa thủ tục ' || rec.OBJECT_NAME || ': ' || SQLERRM);
        END;
    END LOOP;
END;
/

-- Lấy danh sách người dùng
CREATE OR REPLACE PROCEDURE QLTDH.GET_USER_LIST (users_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN users_cursor FOR
    SELECT USER_ID, USERNAME, ACCOUNT_STATUS, CREATED 
    FROM DBA_USERS 
    ORDER BY ACCOUNT_STATUS DESC;
END GET_USER_LIST;
/

-- Kiểm tra người dùng có tồn tại
CREATE OR REPLACE PROCEDURE QLTDH.CHECK_USER_EXISTS (
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
END CHECK_USER_EXISTS;
/

-- Tạo User
CREATE OR REPLACE PROCEDURE QLTDH.CREATE_USER (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
) 
AS
BEGIN
    -- Tạo tài khoản và cấp quyền đăng nhập
    EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY ' || p_password;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || p_username;
END CREATE_USER;
/

-- Xóa User
CREATE OR REPLACE PROCEDURE QLTDH.DELETE_USER(
    p_username IN VARCHAR2
)
AS
BEGIN
    -- Xóa tài khoản
    EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';
END DELETE_USER;
/

-- Cập nhật status cho user
CREATE OR REPLACE PROCEDURE QLTDH.UPDATE_USER_STATUS (
    p_username IN VARCHAR2,
    p_new_status IN VARCHAR2
) 
AS  
BEGIN
    -- Cập nhật trạng thái tài khoản (thêm dấu chấm phẩy ở cuối)
    EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' ACCOUNT ' || p_new_status;
END UPDATE_USER_STATUS;
/
BEGIN
    UPDATE_USER_STATUS('HEHE', 'LOCK');
END;
/

-- Tìm kiếm người dùng
CREATE OR REPLACE PROCEDURE QLTDH.SEARCH_USER (
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
END SEARCH_USER;
/



