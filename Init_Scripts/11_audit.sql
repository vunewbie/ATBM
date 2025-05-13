CREATE OR REPLACE PROCEDURE QLTDH.LOAD_AUDIT(
    p_table_name IN VARCHAR2,
    p_sort_time IN BOOLEAN,
    audit_cursor OUT SYS_REFCURSOR
)
AS
    v_sql CLOB;
BEGIN
    v_sql := '
        SELECT
            AUDIT_TYPE,
            EVENT_TIMESTAMP,
            DBUSERNAME,
            OBJECT_NAME,
            ACTION_NAME,
            SQL_TEXT, 
            FGA_POLICY_NAME
        FROM UNIFIED_AUDIT_TRAIL
        WHERE ';

    IF p_table_name IS NOT NULL THEN
        v_sql := v_sql || 'OBJECT_NAME = ''' || UPPER(p_table_name) || '''';
    ELSE
        v_sql := v_sql || '1=1'; 
    END IF;

    IF p_sort_time THEN
        v_sql := v_sql || ' ORDER BY EVENT_TIMESTAMP DESC';
    ELSE
        v_sql := v_sql || ' ORDER BY EVENT_TIMESTAMP ASC';
    END IF;

    OPEN audit_cursor FOR v_sql;
END;
/

CREATE OR REPLACE PROCEDURE QLTDH.CHECK_AUDIT_STATUS (
    p_status OUT VARCHAR2
)
AS
    v_enabled VARCHAR2(10);
BEGIN
    SELECT VALUE INTO v_enabled
    FROM V$OPTION
    WHERE PARAMETER = 'Unified Auditing';

    IF v_enabled = 'TRUE' THEN
        p_status := 'TRUE';
    ELSE
        p_status := 'FALSE';
    END IF;

EXCEPTION
    WHEN OTHERS THEN
        p_status := 'FALSE';
END;
/

CREATE OR REPLACE PROCEDURE QLTDH.ENABLE_ALL_AUDIT
AS 
BEGIN
  EXECUTE IMMEDIATE 'AUDIT ALL BY ACCESS';
EXCEPTION
  WHEN OTHERS THEN
    RAISE_APPLICATION_ERROR(-20001, 'Lỗi khi bật audit: ' || SQLERRM);
END;
/

CREATE OR REPLACE PROCEDURE QLTDH.DISABLE_ALL_AUDIT
AS 
BEGIN
  EXECUTE IMMEDIATE 'NOAUDIT';
EXCEPTION
  WHEN OTHERS THEN
    RAISE_APPLICATION_ERROR(-20002, 'Lỗi khi tắt audit: ' || SQLERRM);
END;
/
