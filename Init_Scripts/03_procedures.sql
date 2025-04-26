ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;
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
-- DROP PROCEDURE QLTDH.GET_USER_LIST;
CREATE OR REPLACE PROCEDURE QLTDH.GET_USER_LIST (users_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN users_cursor FOR
    SELECT USER_ID, USERNAME, ACCOUNT_STATUS, CREATED 
    FROM DBA_USERS
    WHERE COMMON = 'NO'
    ORDER BY ACCOUNT_STATUS DESC;
END GET_USER_LIST;
/

-- Kiểm tra người dùng có tồn tại
-- DROP PROCEDURE QLTDH.CHECK_USER_EXISTS;
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
    WHERE USERNAME = p_username
    AND COMMON = 'NO';
END CHECK_USER_EXISTS;
/

-- Tạo User
-- DROP PROCEDURE QLTDH.CREATE_USER;
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
-- DROP PROCEDURE QLTDH.DELETE_USER;
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
-- DROP PROCEDURE QLTDH.UPDATE_USER_STATUS;
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

-- Tìm kiếm người dùng
-- DROP PROCEDURE QLTDH.SEARCH_USER;
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
    AND COMMON = 'NO'
    ORDER BY ACCOUNT_STATUS DESC;
END SEARCH_USER;
/

-- Lấy danh sách các Role
-- DROP PROCEDURE QLTDH.GET_ROLE_LIST;
CREATE OR REPLACE PROCEDURE QLTDH.GET_ROLE_LIST (roles_cursor OUT SYS_REFCURSOR) 
AS
BEGIN
    OPEN roles_cursor FOR
    SELECT ROLE_ID, ROLE, PASSWORD_REQUIRED
    FROM DBA_ROLES
    WHERE COMMON = 'NO'
    ORDER BY PASSWORD_REQUIRED DESC;
END GET_ROLE_LIST;
/

-- Kiểm tra xem Role có tồn tại không
-- DROP PROCEDURE QLTDH.CHECK_ROLE_EXISTS;
CREATE OR REPLACE PROCEDURE QLTDH.CHECK_ROLE_EXISTS (
    p_role IN VARCHAR2,
    p_exists OUT VARCHAR2
) 
AS
BEGIN
    -- Kiểm tra xem Role có tồn tại không
    SELECT CASE WHEN COUNT(*) > 0 THEN 'TRUE' ELSE 'FALSE' END
    INTO p_exists
    FROM DBA_ROLES
    WHERE ROLE = p_role
    AND COMMON = 'NO';
END CHECK_ROLE_EXISTS;
/

-- Tạo vai trò mới
-- DROP PROCEDURE QLTDH.CREATE_ROLE;
CREATE OR REPLACE PROCEDURE QLTDH.CREATE_ROLE(
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
-- DROP PROCEDURE PH1_DELETE_ROLE;
CREATE OR REPLACE PROCEDURE QLTDH.DELETE_ROLE(
    p_role IN VARCHAR2
)
AS
BEGIN
    -- Xóa Role
    EXECUTE IMMEDIATE 'DROP ROLE ' || p_role;
END DELETE_ROLE;
/

-- Cập nhật mật khẩu cho role
-- DROP PROCEDURE QLTDH.UPDATE_ROLE_PASSWORD;
CREATE OR REPLACE PROCEDURE QLTDH.UPDATE_ROLE_PASSWORD (
    p_role IN VARCHAR2,
    p_password IN VARCHAR2 DEFAULT NULL
) 
AS  
BEGIN
    IF p_password IS NULL THEN
        EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role || ' NOT IDENTIFIED'; -- PASSWORD NULL
    ELSE
        -- Cập nhật password cho Role
        EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role || ' IDENTIFIED BY ' || p_password;
    END IF;
END UPDATE_ROLE_PASSWORD;
/

-- Tìm kiếm Role
-- DROP PROCEDURE QLTDH.SEARCH_ROLE;
CREATE OR REPLACE PROCEDURE QLTDH.SEARCH_ROLE (
    p_role IN VARCHAR2,
    roles_cursor OUT SYS_REFCURSOR
) 
AS
BEGIN
    OPEN roles_cursor FOR
    SELECT ROLE_ID, ROLE, PASSWORD_REQUIRED
    FROM DBA_ROLES
    WHERE ROLE LIKE '%' || p_role || '%'
    AND COMMON = 'NO'
    ORDER BY ROLE;
END SEARCH_ROLE;
/

-- Lấy danh sách các quyền đã cấp cho user/role trên bảng
-- DROP PROCEDURE PH1_GET_PRIVILEGES_TABLE;
CREATE OR REPLACE PROCEDURE QLTDH.GET_PRIVILEGES_TABLE (
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
        AND (
            -- Các privileges thuộc schema của các user khác (không phải system schemas)
            OWNER NOT IN ('SYSTEM', 'OUTLN', 'DIP', 'ORACLE_OCM', 
                        'DBSNMP', 'APPQOSSYS', 'DBSFWUSER', 'GGSYS', 
                        'ANONYMOUS', 'XDB', 'CTXSYS', 'MDSYS', 'OLAPSYS', 
                        'ORDDATA', 'ORDPLUGINS', 'ORDSYS', 'LBACSYS', 'DVSYS',
                        'AUDSYS', 'REMOTE_SCHEDULER_AGENT', 'SYSBACKUP',
                        'SYSDG', 'SYSKM', 'GSMADMIN_INTERNAL', 'SYSRAC',
                        'OJVMSYS', 'DVF', 'WMSYS', 'APEX_050000', 'SI_INFORMTN_SCHEMA')
        )
        ORDER BY GRANTEE, OWNER, TABLE_NAME, PRIVILEGE;
    ELSE
        -- Nếu là user thông thường, chỉ lấy các privileges thuộc schema của họ hoặc được cấp cho họ
        OPEN table_privileges_cursor FOR
        SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE, GRANTABLE, HIERARCHY, COMMON, TYPE, INHERITED
        FROM DBA_TAB_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%'))
        AND OWNER = v_current_user --OR GRANTEE = v_current_user
        ORDER BY GRANTEE, OWNER, TABLE_NAME, PRIVILEGE;
    END IF;
END;
/

-- Lấy danh sách các quyền đã cấp cho user/role trên cột
-- DROP PROCEDURE PH1_GET_PRIVILEGES_COLUMN;
CREATE OR REPLACE PROCEDURE QLTDH.GET_PRIVILEGES_COLUMN (
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
        AND (
            -- Các privileges thuộc schema của các user khác (không phải system schemas)
            OWNER NOT IN ('SYSTEM', 'OUTLN', 'DIP', 'ORACLE_OCM', 
                        'DBSNMP', 'APPQOSSYS', 'DBSFWUSER', 'GGSYS', 
                        'ANONYMOUS', 'XDB', 'CTXSYS', 'MDSYS', 'OLAPSYS', 
                        'ORDDATA', 'ORDPLUGINS', 'ORDSYS', 'LBACSYS', 'DVSYS',
                        'AUDSYS', 'REMOTE_SCHEDULER_AGENT', 'SYSBACKUP',
                        'SYSDG', 'SYSKM', 'GSMADMIN_INTERNAL', 'SYSRAC',
                        'OJVMSYS', 'DVF', 'WMSYS', 'APEX_050000', 'SI_INFORMTN_SCHEMA')
        )
        ORDER BY GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE;
    ELSE
        OPEN column_privileges_cursor FOR
        SELECT GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, GRANTOR, PRIVILEGE, GRANTABLE, COMMON, INHERITED
        FROM DBA_COL_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%'))
        AND OWNER = v_current_user --OR GRANTEE = v_current_user
        ORDER BY GRANTEE, OWNER, TABLE_NAME, COLUMN_NAME, PRIVILEGE;
    END IF;
END;
/


--Lấy ra danh sách tất cả các đối tượng của user/role
CREATE OR REPLACE PROCEDURE QLTDH.GET_ALL_OBJECTS_BY_USER_OR_ROLE (
    p_user_or_role IN VARCHAR2,
    all_objects_cursor OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN all_objects_cursor FOR
    SELECT DISTINCT TABLE_NAME
    FROM DBA_TAB_PRIVS
    WHERE GRANTEE = p_user_or_role

    UNION 

    SELECT TABLE_NAME
    FROM DBA_COL_PRIVS
    WHERE GRANTEE = p_user_or_role;
    
END;
/

--Load table/view/proc/function for user/role in grantprivilegeform 
CREATE OR REPLACE PROCEDURE QLTDH.GET_OBJECT_TYPE_BY_USER_OR_ROLE (
    p_user_or_role IN VARCHAR2,
    p_object IN VARCHAR2, -- Loại đối tượng: TABLE, VIEW, PROCEDURE, FUNCTION
    p_cursor OUT SYS_REFCURSOR
)
AS
    v_count NUMBER;
    v_object_type VARCHAR2(30);
    v_admin_con_id NUMBER;
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

    -- Lấy container ID của admin hiện tại
    SELECT SYS_CONTEXT('USERENV', 'CON_ID') INTO v_admin_con_id FROM dual;

    -- Kiểm tra xem p_user_or_role là user hay role và nằm trong cùng container
    SELECT COUNT(*) INTO v_count 
    FROM cdb_users 
    WHERE username = UPPER(p_user_or_role)
    AND con_id = v_admin_con_id;

    IF v_count = 0 THEN
        -- Nếu không phải user, kiểm tra role
        SELECT COUNT(*) INTO v_count 
        FROM cdb_roles 
        WHERE role = UPPER(p_user_or_role)
        AND con_id = v_admin_con_id;

        IF v_count = 0 THEN
            -- Không cùng container hoặc không hợp lệ, thoát procedure
            RAISE_APPLICATION_ERROR(-20002, 'User or Role not in the same container or invalid');
        END IF;
    END IF;

    -- Nếu cùng container, load tất cả đối tượng mà admin có quyền truy cập
    OPEN p_cursor FOR
        SELECT object_name
        FROM cdb_objects o
        WHERE o.con_id = v_admin_con_id
        AND o.object_type = v_object_type
        AND o.owner NOT IN ('SYS', 'SYSTEM')
        AND EXISTS (
            SELECT 1
            FROM cdb_tab_privs tp
            WHERE tp.owner = o.owner
            AND tp.table_name = o.object_name
            AND tp.grantee = SYS_CONTEXT('USERENV', 'SESSION_USER')
            AND tp.grantable = 'YES'
            UNION
            SELECT 1
            FROM cdb_objects
            WHERE owner = SYS_CONTEXT('USERENV', 'SESSION_USER')
            AND object_name = o.object_name
            AND object_type = o.object_type
            AND con_id = o.con_id
        );
END;
/

--Grant quyền select
CREATE OR REPLACE PROCEDURE QLTDH.GRANT_SELECT_TO_USER_OR_ROLE (
    p_username          IN VARCHAR2,
    p_object            IN VARCHAR2,
    p_with_grant_option IN BOOLEAN,
    p_success           OUT BOOLEAN,
    p_attribute         IN OUT SYS.DBMS_SQL.VARCHAR2A
)
AS
    v_sql        VARCHAR2(4000);
    v_view_name  VARCHAR2(100);
    v_count      INTEGER;
BEGIN
    p_success := FALSE;

    -- Validate inputs
    IF p_username IS NULL OR p_object IS NULL THEN
        RAISE_APPLICATION_ERROR(-20001, 'Username and Object cannot be NULL');
    END IF;

    -- If p_attribute is NULL, grant SELECT on the entire object
    IF p_attribute.COUNT = 1 AND p_attribute(1) = '*' THEN
        v_sql := 'GRANT SELECT ON ' || p_object || ' TO ' || p_username;
        IF p_with_grant_option THEN
            v_sql := v_sql || ' WITH GRANT OPTION';
        END IF;
        EXECUTE IMMEDIATE v_sql;
        p_success := TRUE;
        RETURN;
    END IF;

    -- Construct view name
    v_view_name := 'v_';
    FOR i IN 1 .. p_attribute.COUNT LOOP
        v_view_name := v_view_name || p_attribute(i);
        IF i < p_attribute.COUNT THEN
            v_view_name := v_view_name || '_';
        END IF;
    END LOOP;
    v_view_name := v_view_name || '_' || p_object;

    -- Check if the view already exists
    SELECT COUNT(*) INTO v_count FROM user_views WHERE view_name = UPPER(v_view_name);

    -- If the view doesn't exist, create it
    IF v_count = 0 THEN
        v_sql := 'CREATE OR REPLACE VIEW ' || v_view_name || ' AS SELECT ';
        FOR i IN 1 .. p_attribute.COUNT LOOP
            IF i > 1 THEN
                v_sql := v_sql || ', ';
            END IF;
            v_sql := v_sql || p_attribute(i);
        END LOOP;
        v_sql := v_sql || ' FROM ' || p_object;
        EXECUTE IMMEDIATE v_sql;
    END IF;

    -- Grant SELECT on the view to the user
    v_sql := 'GRANT SELECT ON ' || v_view_name || ' TO ' || p_username;
    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;
    EXECUTE IMMEDIATE v_sql;

    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        p_success := FALSE;
        DBMS_OUTPUT.PUT_LINE('ERROR: ' || SQLERRM);
END;
/
--Grant quyền update
CREATE OR REPLACE PROCEDURE QLTDH.GRANT_UPDATE_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
    p_object IN VARCHAR2,
    p_with_grant_option IN BOOLEAN,
    p_success OUT BOOLEAN,
    p_attribute IN OUT SYS.DBMS_SQL.VARCHAR2A
)
AS
    v_sql VARCHAR2(4000);
    v_columns VARCHAR2(4000);
BEGIN
    p_success := FALSE;

    IF p_username IS NULL THEN
        RAISE_APPLICATION_ERROR(-20001, 'Username or Role cannot be NULL');
    END IF;

    IF p_object IS NULL THEN
        RAISE_APPLICATION_ERROR(-20003, 'Object name cannot be NULL');
    END IF;

    IF p_attribute.COUNT = 1 AND p_attribute(1) = '*' THEN
        v_sql := 'GRANT UPDATE ON ' || p_object || ' TO ' || p_username;
    ELSE
        v_columns := '';
        FOR i IN 1 .. p_attribute.COUNT LOOP
            IF p_attribute(i) IS NULL OR TRIM(p_attribute(i)) = '' THEN
                RAISE_APPLICATION_ERROR(-20004, 'Attribute name cannot be NULL or empty');
            END IF;
            IF i > 1 THEN
                v_columns := v_columns || ', ';
            END IF;
            v_columns := v_columns || p_attribute(i);
        END LOOP;

        v_sql := 'GRANT UPDATE (' || v_columns || ') ON ' || p_object || ' TO ' || p_username;
    END IF;

    IF p_with_grant_option THEN
        v_sql := v_sql || ' WITH GRANT OPTION';
    END IF;

    EXECUTE IMMEDIATE v_sql;
    p_success := TRUE;

EXCEPTION
    WHEN OTHERS THEN
        p_success := FALSE;
END;
/

--GRANT QUYỀN DELETE
CREATE OR REPLACE PROCEDURE QLTDH.GRANT_DELETE_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
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
END;
/

--grant quyền insert
CREATE OR REPLACE PROCEDURE QLTDH.GRANT_INSERT_TO_USER_OR_ROLE (
    p_username IN VARCHAR2,
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
END;
/

--grant quyền execute function/proc cho user/role
CREATE OR REPLACE PROCEDURE QLTDH.GRANT_EXEC_TO_USER_OR_ROLE (
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

    -- Thực thi
    EXECUTE IMMEDIATE v_sql;

    -- Đánh dấu thành công nếu không lỗi
    p_success := TRUE;
 
EXCEPTION
    WHEN OTHERS THEN
        p_success := FALSE;
END;
/

--Cấp role cho user
CREATE OR REPLACE PROCEDURE QLTDH.GRANT_ROLE_TO_USER (
    p_user IN VARCHAR2,
    p_role IN VARCHAR2,
    p_with_admin_option IN BOOLEAN
)
AS
    v_sql VARCHAR2(4000);
    v_container_id_user NUMBER;
    v_container_id_role NUMBER;
BEGIN
    -- Kiểm tra xem user và role có cùng container không
    BEGIN
        SELECT con_id INTO v_container_id_user
        FROM cdb_users
        WHERE username = UPPER(p_user);
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RAISE_APPLICATION_ERROR(-20001, 'Không tìm thấy người dùng ' || p_user);
    END;
    
    BEGIN
        SELECT con_id INTO v_container_id_role
        FROM cdb_roles
        WHERE role = UPPER(p_role);
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RAISE_APPLICATION_ERROR(-20002, 'Không tìm thấy role ' || p_role);
    END;
    
    -- Kiểm tra nếu user và role không cùng container
    IF v_container_id_user != v_container_id_role THEN
        RAISE_APPLICATION_ERROR(-20003, 'Không thể cấp role từ PDB này cho người dùng ở PDB khác.');
    END IF;
    
    -- Xây dựng câu lệnh GRANT ROLE TO USER
    v_sql := 'GRANT ' || p_role || ' TO ' || p_user;
    
    -- Thêm WITH ADMIN OPTION nếu cần
    IF p_with_admin_option THEN
        v_sql := v_sql || ' WITH ADMIN OPTION';
    END IF;
    
    -- Thực thi
    EXECUTE IMMEDIATE v_sql;
    
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE NOT IN (-20001, -20002, -20003) THEN
            RAISE_APPLICATION_ERROR(-20000, 'Lỗi khi cấp quyền: ' || SQLERRM);
        ELSE
            RAISE;
        END IF;
END;
/

--Xem danh sách role đã cấp cho người dùng
CREATE OR REPLACE PROCEDURE QLTDH.GET_GRANTED_ROLES (
    p_grantee IN VARCHAR2 DEFAULT NULL,
    granted_roles_cursor OUT SYS_REFCURSOR
)
AS
BEGIN
    IF p_grantee IS NULL THEN
        -- Nếu không truyền user, lấy tất cả
        OPEN granted_roles_cursor FOR
        SELECT GRANTEE, GRANTED_ROLE, ADMIN_OPTION, DEFAULT_ROLE
        FROM DBA_ROLE_PRIVS
        WHERE COMMON = 'NO'
        ORDER BY GRANTEE, GRANTED_ROLE;
    ELSE
        -- Nếu có truyền user, lọc theo user đó
        OPEN granted_roles_cursor FOR
        SELECT GRANTEE, GRANTED_ROLE, ADMIN_OPTION, DEFAULT_ROLE
        FROM DBA_ROLE_PRIVS
        WHERE (p_grantee IS NULL OR UPPER(GRANTEE) LIKE UPPER('%' || p_grantee || '%')) AND COMMON = 'NO'
        ORDER BY GRANTED_ROLE;
    END IF;
END;
/

--Thu hồi role của user
CREATE OR REPLACE PROCEDURE QLTDH.REVOKE_ROLE_FROM_USER (
    p_grantee    IN VARCHAR2,
    p_role       IN VARCHAR2
)
AS
    v_sql        VARCHAR2(4000);
    v_count      NUMBER := 0;
    v_is_dba     NUMBER := 0;
BEGIN
    SELECT COUNT(*) INTO v_is_dba
    FROM DBA_ROLE_PRIVS
    WHERE GRANTEE = UPPER(p_grantee)
      AND GRANTED_ROLE = 'DBA';

    IF v_is_dba > 0 THEN
        RAISE_APPLICATION_ERROR(-20002, 'Không được phép thu hồi role từ người dùng thuộc DBA.');
    END IF;

    BEGIN
        v_sql := 'REVOKE ' || p_role || ' FROM ' || p_grantee;
        EXECUTE IMMEDIATE v_sql;
    EXCEPTION
        WHEN OTHERS THEN
            -- Gửi thông báo lỗi cho người dùng
            RAISE_APPLICATION_ERROR(-20003, 'Lỗi khi thu hồi role từ "' || p_grantee || '" cho role "' || p_role || '": ' || SQLERRM);
    END;
END;
/
