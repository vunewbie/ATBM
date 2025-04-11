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
-- DROP PROCEDURE PH1_GET_USER_LIST;
CREATE OR REPLACE PROCEDURE PH1_GET_USER_LIST (users_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN users_cursor FOR
    SELECT USER_ID, USERNAME, ACCOUNT_STATUS, CREATED 
    FROM DBA_USERS 
    ORDER BY ACCOUNT_STATUS DESC;
END;
/
GRANT EXECUTE ON SYS.PH1_GET_USER_LIST TO C##QLTDH;

-- Kiểm tra người dùng có tồn tại
-- DROP PROCEDURE PH1_CHECK_USER_EXISTS;
CREATE OR REPLACE PROCEDURE PH1_CHECK_USER_EXISTS (
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
GRANT EXECUTE ON SYS.PH1_CHECK_USER_EXISTS TO C##QLTDH;

-- Tạo User (Trên áp nhớ thêm tiền tố "C##" khi test)
-- DROP PROCEDURE PH1_CREATE_USER;
CREATE OR REPLACE PROCEDURE PH1_CREATE_USER (
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
GRANT EXECUTE ON SYS.PH1_CREATE_USER TO C##QLTDH;

-- Xóa User
-- DROP PROCEDURE PH1_DELETE_USER;
CREATE OR REPLACE PROCEDURE PH1_DELETE_USER(
    p_username IN VARCHAR2
)
AS
BEGIN
    -- Xóa tài khoản
    EXECUTE IMMEDIATE 'DROP USER ' || p_username || ' CASCADE';
END;
/
GRANT EXECUTE ON SYS.PH1_DELETE_USER TO C##QLTDH;

-- Cập nhật status cho user
-- DROP PROCEDURE PH1_UPDATE_USER_STATUS;
CREATE OR REPLACE PROCEDURE PH1_UPDATE_USER_STATUS (
    p_username IN VARCHAR2,
    p_new_status IN VARCHAR2
) 
AS  
BEGIN
    -- Cập nhật trạng thái tài khoản (thêm dấu chấm phẩy ở cuối)
    EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' ACCOUNT ' || p_new_status;
END;
/
GRANT EXECUTE ON SYS.PH1_UPDATE_USER_STATUS TO C##QLTDH;

-- Tìm kiếm người dùng
-- DROP PROCEDURE PH1_SEARCH_USER;
CREATE OR REPLACE PROCEDURE PH1_SEARCH_USER (
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
GRANT EXECUTE ON SYS.PH1_SEARCH_USER TO C##QLTDH;

-- Lấy danh sách các Role
-- DROP PROCEDURE PH1_GET_ROLE_LIST;
CREATE OR REPLACE PROCEDURE PH1_GET_ROLE_LIST (roles_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN roles_cursor FOR
    SELECT ROLE_ID, ROLE, PASSWORD_REQUIRED
    FROM DBA_ROLES
    ORDER BY PASSWORD_REQUIRED DESC;
END;
/
GRANT EXECUTE ON SYS.PH1_GET_ROLE_LIST TO C##QLTDH;

-- Kiểm tra xem Role có tồn tại không
-- DROP PROCEDURE PH1_CHECK_ROLE_EXISTS;
CREATE OR REPLACE PROCEDURE PH1_CHECK_ROLE_EXISTS (
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
GRANT EXECUTE ON SYS.PH1_CHECK_ROLE_EXISTS TO C##QLTDH;

-- Tạo vai trò mới
-- DROP PROCEDURE PH1_CREATE_ROLE;
CREATE OR REPLACE PROCEDURE PH1_CREATE_ROLE(
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
GRANT EXECUTE ON SYS.PH1_CREATE_ROLE TO C##QLTDH;

-- Xóa Role
-- DROP PROCEDURE PH1_DELETE_ROLE;
CREATE OR REPLACE PROCEDURE PH1_DELETE_ROLE(
    p_role IN VARCHAR2
)
AS
BEGIN
    -- Xóa Role
    EXECUTE IMMEDIATE 'DROP ROLE ' || p_role;
END;
/
GRANT EXECUTE ON SYS.PH1_CREATE_ROLE TO C##QLTDH;

-- Cập nhật mật khẩu cho role
-- DROP PROCEDURE PH1_UPDATE_ROLE_PASSWORD;
CREATE OR REPLACE PROCEDURE PH1_UPDATE_ROLE_PASSWORD (
    p_role IN VARCHAR2,
    p_password IN VARCHAR2
) 
AS  
BEGIN
    -- Cập nhật password cho Role
    EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role || ' IDENTIFIED BY ' || p_password;
END;
/
GRANT EXECUTE ON SYS.PH1_UPDATE_ROLE_PASSWORD TO C##QLTDH;

-- Tìm kiếm Role
-- DROP PROCEDURE PH1_SEARCH_ROLE;
CREATE OR REPLACE PROCEDURE PH1_SEARCH_ROLE (
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

-- Lấy danh sách các quyền đã cấp cho user/role trên bảng
-- DROP PROCEDURE PH1_GET_PRIVILEGES_TABLE;
CREATE OR REPLACE PROCEDURE PH1_GET_PRIVILEGES_TABLE (
    p_grantee IN VARCHAR2 DEFAULT NULL,
    table_privileges_cursor OUT SYS_REFCURSOR
)
AS
    v_current_user VARCHAR2(30);
BEGIN
    -- Lấy thông tin user hiện tại
    SELECT USER INTO v_current_user FROM DUAL;
    
    IF v_current_user = 'SYS' THEN
        OPEN table_privileges_cursor FOR
        SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE, HIERARCHY, COMMON, TYPE, INHERITED
        FROM DBA_TAB_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%'))
        -- Exclude system schemas
        AND OWNER NOT IN ('SYS', 'SYSTEM', 'OUTLN', 'DIP', 'ORACLE_OCM', 
                        'DBSNMP', 'APPQOSSYS', 'DBSFWUSER', 'GGSYS', 
                        'ANONYMOUS', 'XDB', 'CTXSYS', 'MDSYS', 'OLAPSYS', 
                        'ORDDATA', 'ORDPLUGINS', 'ORDSYS', 'LBACSYS', 'DVSYS',
                        'AUDSYS', 'REMOTE_SCHEDULER_AGENT', 'SYSBACKUP',
                        'SYSDG', 'SYSKM', 'GSMADMIN_INTERNAL', 'SYSRAC',
                        'OJVMSYS', 'DVF', 'WMSYS', 'APEX_050000', 'SI_INFORMTN_SCHEMA')
        ORDER BY GRANTEE, OWNER, TABLE_NAME, PRIVILEGE;
    ELSE
        OPEN table_privileges_cursor FOR
        SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE, HIERARCHY, COMMON, TYPE, INHERITED
        FROM DBA_TAB_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%'))
        AND OWNER = v_current_user OR GRANTEE = v_current_user
        ORDER BY GRANTEE, OWNER, TABLE_NAME, PRIVILEGE;
    END IF;
END;
/
GRANT EXECUTE ON SYS.PH1_GET_PRIVILEGES_TABLE TO C##QLTDH;

-- Lấy danh sách các quyền đã cấp cho user/role trên cột
-- DROP PROCEDURE PH1_GET_PRIVILEGES_COLUMN;
CREATE OR REPLACE PROCEDURE PH1_GET_PRIVILEGES_COLUMN (
    p_grantee IN VARCHAR2 DEFAULT NULL,
    column_privileges_cursor OUT SYS_REFCURSOR
)
AS
    v_current_user VARCHAR2(30);
BEGIN
    -- Lấy thông tin user hiện tại
    SELECT USER INTO v_current_user FROM DUAL;
    
    IF v_current_user = 'SYS' THEN
        OPEN column_privileges_cursor FOR
        SELECT GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, GRANTOR, PRIVILEGE, GRANTABLE, COMMON, INHERITED
        FROM DBA_COL_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%'))
        -- Exclude system schemas
        AND OWNER NOT IN ('SYS', 'SYSTEM', 'OUTLN', 'DIP', 'ORACLE_OCM',
                        'DBSNMP', 'APPQOSSYS', 'DBSFWUSER', 'GGSYS', 
                        'ANONYMOUS', 'XDB', 'CTXSYS', 'MDSYS', 'OLAPSYS', 
                        'ORDDATA', 'ORDPLUGINS', 'ORDSYS', 'LBACSYS', 'DVSYS',
                        'AUDSYS', 'REMOTE_SCHEDULER_AGENT', 'SYSBACKUP',
                        'SYSDG', 'SYSKM', 'GSMADMIN_INTERNAL', 'SYSRAC',
                        'OJVMSYS', 'DVF', 'WMSYS', 'APEX_050000', 'SI_INFORMTN_SCHEMA')
        ORDER BY GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE;
    ELSE
        OPEN column_privileges_cursor FOR
        SELECT GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, GRANTOR, PRIVILEGE, GRANTABLE, COMMON, INHERITED
        FROM DBA_COL_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%'))
        AND OWNER = v_current_user OR GRANTEE = v_current_user
        ORDER BY GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE;
    END IF;
END;
/
GRANT EXECUTE ON SYS.PH1_GET_PRIVILEGES_COLUMN TO C##QLTDH;

-- Kiểm tra username/role
CREATE OR REPLACE PROCEDURE PH1_CHECK_USER_ROLE(
     p_username_or_role IN VARCHAR2,
     p_type OUT VARCHAR2
)
AS
    v_count NUMBER;
BEGIN
    -- Kiểm tra nếu là USER
    SELECT COUNT(*)
    INTO v_count
    FROM ALL_USERS
    WHERE USERNAME = p_username_or_role;

    IF v_count > 0 THEN
        p_type := 'Đây là user';
        RETURN;
    END IF;

    -- Kiểm tra nếu là ROLE
    SELECT COUNT(*)
    INTO v_count
    FROM DBA_ROLES
    WHERE ROLE = UPPER(p_username_or_role);

    IF v_count > 0 THEN
        p_type := 'Đây là role';
        RETURN;
    END IF;

    -- Không phải user hoặc role
    p_type := 'Không hợp lệ';
END;
/
GRANT EXECUTE ON SYS.PH1_CHECK_USER_ROLE TO C##QLTDH;

--Load table/view/proc/function for user/role in grantprivilegeform 
CREATE OR REPLACE PROCEDURE PH1_GET_OBJECT_TYPE_BY_USER_OR_ROLE (
    p_user_or_role IN VARCHAR2,
    p_object IN VARCHAR2, -- Loại đối tượng: TABLE, VIEW, PROCEDURE, FUNCTION
    p_cursor OUT SYS_REFCURSOR
)
AS
    v_count NUMBER;
    v_object_type VARCHAR2(30);
BEGIN
    -- Kiểm tra tham số đầu vào
    IF p_user_or_role IS NULL THEN
        RAISE_APPLICATION_ERROR(-20001, 'User or Role parameter cannot be NULL');
    END IF;

    IF p_object IS NULL THEN
        RAISE_APPLICATION_ERROR(-20003, 'Object type parameter cannot be NULL');
    END IF;

    -- Chuẩn hóa loại đối tượng
    v_object_type := UPPER(p_object);

    IF v_object_type NOT IN ('TABLE', 'VIEW', 'PROCEDURE', 'FUNCTION') THEN
        RAISE_APPLICATION_ERROR(-20004, 'Invalid object type. Must be TABLE, VIEW, PROCEDURE, or FUNCTION');
    END IF;

    -- Kiểm tra xem p_user_or_role là user hay role
    SELECT COUNT(*) INTO v_count 
    FROM all_users 
    WHERE username = UPPER(p_user_or_role);

    IF v_count > 0 THEN
        -- Nếu là user, trả danh sách đối tượng thuộc schema của user
        OPEN p_cursor FOR
            SELECT object_name
            FROM all_objects
            WHERE owner = UPPER(p_user_or_role)
            AND owner NOT IN ('SYS', 'SYSTEM')
            AND object_type = v_object_type;
    ELSE
        -- Kiểm tra xem có phải là role
        SELECT COUNT(*) INTO v_count 
        FROM dba_roles 
        WHERE role = UPPER(p_user_or_role);

        IF v_count > 0 THEN
            -- Nếu là role, trả danh sách đối tượng thuộc schema của các user được gán role
            OPEN p_cursor FOR
                SELECT DISTINCT o.object_name
                FROM all_objects o
                JOIN dba_role_privs rp ON o.owner = rp.grantee
                WHERE rp.granted_role = UPPER(p_user_or_role)
                AND o.owner NOT IN ('SYS', 'SYSTEM')
                AND o.object_type = v_object_type;
        ELSE
            RAISE_APPLICATION_ERROR(-20002, 'Invalid User or Role name');
        END IF;
    END IF;
END;
/

--tạo kiểu mảng
CREATE OR REPLACE TYPE column_array AS VARRAY(100) OF VARCHAR2(128);
/
--Grant quyền select
CREATE OR REPLACE PROCEDURE PH1_GRANT_SELECT_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
    p_object_type IN VARCHAR2,
    p_object IN VARCHAR2,
    p_attribute IN column_array, -- Mảng các cột
    p_with_grant_option IN BOOLEAN,
    p_success OUT BOOLEAN -- Tham số đầu ra: TRUE nếu thành công, FALSE nếu thất bại
)
AS
    v_sql VARCHAR2(4000);
    v_columns VARCHAR2(4000); -- Chuỗi các cột để dùng trong GRANT
BEGIN
    -- Khởi tạo giá trị mặc định cho p_success
    p_success := FALSE;

    -- Xây dựng câu lệnh GRANT
    IF p_attribute IS NULL OR p_attribute.COUNT = 0 THEN
        -- Cấp quyền SELECT trên toàn bộ bảng/view
        v_sql := 'GRANT SELECT ON ' || p_object || ' TO ' || p_username;
    ELSE
        -- Xây dựng danh sách cột từ mảng
        v_columns := '';
        FOR i IN 1..p_attribute.COUNT LOOP
            IF i > 1 THEN
                v_columns := v_columns || ',';
            END IF;
            v_columns := v_columns || p_attribute(i);
        END LOOP;

        -- Cấp quyền SELECT trên các cột cụ thể
        v_sql := 'GRANT SELECT (' || v_columns || ') ON ' || p_object || ' TO ' || p_username;
    END IF;

    -- Thêm WITH GRANT OPTION nếu cần
    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;

    -- Thực thi câu lệnh GRANT
    EXECUTE IMMEDIATE v_sql;

    -- Nếu không có lỗi, đặt p_success = TRUE
    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        -- Nếu có lỗi, đặt p_success = FALSE
        p_success := FALSE;
END PH1_GRANT_SELECT_TO_USER_OR_ROLE;
/
--Grant quyền update
CREATE OR REPLACE PROCEDURE PH1_GRANT_UPDATE_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
    p_object_type IN VARCHAR2,
    p_object IN VARCHAR2,
    p_attribute IN column_array, -- Mảng các cột
    p_with_grant_option IN BOOLEAN,
    p_success OUT BOOLEAN -- Tham số đầu ra: TRUE nếu thành công, FALSE nếu thất bại
)
AS
    v_sql VARCHAR2(4000);
    v_columns VARCHAR2(4000); -- Chuỗi các cột để dùng trong GRANT
BEGIN
    -- Khởi tạo giá trị mặc định cho p_success
    p_success := FALSE;

    -- Xây dựng câu lệnh GRANT
    IF p_attribute IS NULL OR p_attribute.COUNT = 0 THEN
        -- Cấp quyền UPDATE trên toàn bộ bảng/view
        v_sql := 'GRANT UPDATE ON ' || p_object || ' TO ' || p_username;
    ELSE
        -- Xây dựng danh sách cột từ mảng
        v_columns := '';
        FOR i IN 1..p_attribute.COUNT LOOP
            IF i > 1 THEN
                v_columns := v_columns || ',';
            END IF;
            v_columns := v_columns || p_attribute(i);
        END LOOP;

        -- Cấp quyền SELECT trên các cột cụ thể
        v_sql := 'GRANT UPDATE (' || v_columns || ') ON ' || p_object || ' TO ' || p_username;
    END IF;

    -- Thêm WITH GRANT OPTION nếu cần
    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;

    -- Thực thi câu lệnh GRANT
    EXECUTE IMMEDIATE v_sql;

    -- Nếu không có lỗi, đặt p_success = TRUE
    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        -- Nếu có lỗi, đặt p_success = FALSE
        p_success := FALSE;
END PH1_GRANT_UPDATE_TO_USER_OR_ROLE;
/

--GRANT QUYỀN DELETE
CREATE OR REPLACE PROCEDURE PH1_GRANT_DELETE_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
    p_object_type IN VARCHAR2,
    p_object IN VARCHAR2,
    p_with_grant_option IN BOOLEAN,
    p_success OUT BOOLEAN -- Tham số đầu ra: TRUE nếu thành công, FALSE nếu thất bại
)
AS
    v_sql VARCHAR2(4000);
BEGIN
    -- Khởi tạo giá trị mặc định cho p_success
    p_success := FALSE;

    -- Xây dựng câu lệnh GRANT DELETE
    v_sql := 'GRANT DELETE ON ' || p_object || ' TO ' || p_username;

    -- Thêm WITH GRANT OPTION nếu cần
    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;

    -- Thực thi câu lệnh GRANT
    EXECUTE IMMEDIATE v_sql;

    -- Nếu không có lỗi, đặt p_success = TRUE
    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        -- Nếu có lỗi, đặt p_success = FALSE
        p_success := FALSE;
END PH1_GRANT_DELETE_TO_USER_OR_ROLE;
/

--grant quyền insert
CREATE OR REPLACE PROCEDURE PH1_GRANT_INSERT_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
    p_object_type IN VARCHAR2,
    p_object IN VARCHAR2,
    p_with_grant_option IN BOOLEAN,
    p_success OUT BOOLEAN -- Tham số đầu ra: TRUE nếu thành công, FALSE nếu thất bại
)
AS
    v_sql VARCHAR2(4000);
BEGIN
    -- Khởi tạo giá trị mặc định cho p_success
    p_success := FALSE;

    -- Xây dựng câu lệnh GRANT INSERT
    v_sql := 'GRANT INSERT ON ' || p_object || ' TO ' || p_username;

    -- Thêm WITH GRANT OPTION nếu cần
    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;

    -- Thực thi câu lệnh GRANT
    EXECUTE IMMEDIATE v_sql;

    -- Nếu không có lỗi, đặt p_success = TRUE
    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        -- Nếu có lỗi, đặt p_success = FALSE
        p_success := FALSE;
END PH1_GRANT_INSERT_TO_USER_OR_ROLE;
/

--grant quyền execute function/proc cho user/role
CREATE OR REPLACE PROCEDURE PH1_GRANT_EXEC_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
    p_object IN VARCHAR2,       -- Tên function/procedure
    p_with_grant_option IN BOOLEAN,
    p_success OUT BOOLEAN
)
AS
    v_sql VARCHAR2(4000);
BEGIN
    -- Mặc định là thất bại
    p_success := FALSE;

    -- Xây dựng câu lệnh GRANT EXECUTE
    v_sql := 'GRANT EXECUTE ON ' || p_object || ' TO ' || p_username;

    -- Thêm WITH GRANT OPTION nếu cần
    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;

    -- Thực thi
    EXECUTE IMMEDIATE v_sql;

    -- Đánh dấu thành công nếu không lỗi
    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        p_success := FALSE;
END PH1_GRANT_EXEC_TO_USER_OR_ROLE;
/

