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

--==============================================================================
--Tạo chính sách FGA
--==============================================================================
--Hành vi cập nhật quan hệ ĐANGKY tại các trường liên quan đến điểm số nhưng
--người đó không thuộc vai trò “NV PKT”.
BEGIN
  FOR rec IN (SELECT policy_name 
              FROM DBA_AUDIT_POLICIES 
              WHERE object_schema = 'QLTDH' 
              AND object_name = 'DANGKY' 
              AND policy_name = 'UPDATE_SCORE') 
  LOOP
    DBMS_FGA.DROP_POLICY(
      object_schema => 'QLTDH',    
      object_name   => 'DANGKY',   
      policy_name   => 'UPDATE_SCORE'  
    );
  END LOOP;
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'QLTDH',             
    object_name     => 'DANGKY',              
    policy_name     => 'UPDATE_SCORE',     
    audit_condition => 'VAITRO != ''NV PKT''',
    audit_column    => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',  
    statement_types => 'UPDATE'                
  );
END;
/

--Câu lệnh kiểm tra
--UPDATE QLTDH.DANGKY
--SET DIEMTH = 7.0
--WHERE MASV = 'SV0001' AND MAMM='MM0002';
--
--CONNECT NVPKT0001/NVPKT0001@localhost:1521/QUANLYTRUONGDAIHOC;
--UPDATE QLTDH.DANGKY
--SET DIEMTH = 6.0
--WHERE MASV = 'SV0001' AND MAMM='MM0002';

--Kiểm tra audit
--CONNECT QLTDH/admin123@localhost:1521/QUANLYTRUONGDAIHOC;
--SELECT * FROM DBA_FGA_AUDIT_TRAIL
--WHERE object_name = 'DANGKY';


--==============================================================================
--Hành vi của người dùng (không thuộc vai trò “NV TCHC”) có thể đọc trên
--trường LUONG, PHUCAP của người khác ở quan hệ NHANVIEN.
BEGIN
  FOR rec IN (SELECT policy_name 
              FROM DBA_AUDIT_POLICIES 
              WHERE object_schema = 'QLTDH' 
              AND object_name = 'NHANVIEN' 
              AND policy_name = 'SELECT_EMPLOYEE') 
  LOOP
    DBMS_FGA.DROP_POLICY(
      object_schema => 'QLTDH',    
      object_name   => 'NHANVIEN',   
      policy_name   => 'SELECT_EMPLOYEE'  
    );
  END LOOP;
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'QLTDH',             
    object_name     => 'NHANVIEN',              
    policy_name     => 'SELECT_EMPLOYEE',     
    audit_condition => 'VAITRO != ''NV TCHC'' AND MANV != SYS_CONTEXT(''USERENV'', ''SESSION_USER'')',
    audit_column    => 'LUONG,PHUCAP',  
    statement_types => 'SELECT'                
  );
END;
/

--Câu lệnh kiểm tra
--GRANT SELECT ON QLTDH.NHANVIEN TO "NVPKT0001";
--Đăng nhập bằng acc 'NVPKT0001'
--SELECT LUONG, PHUCAP FROM QLTDH.NHANVIEN WHERE MANV='NVPKT0001'; --không bị audit
--SELECT LUONG, PHUCAP FROM QLTDH.NHANVIEN WHERE MANV='NVPKT0002'; --bị audit

--Kiểm tra audit
--SELECT * FROM DBA_FGA_AUDIT_TRAIL
--WHERE object_name = 'NHANVIEN';

--==============================================================================
--Hành vi của người dùng (không thuộc vai trò “NV TCHC”) cập nhật ở 
--quan hệ NHANVIEN.
BEGIN
  FOR rec IN (SELECT policy_name 
              FROM DBA_AUDIT_POLICIES 
              WHERE object_schema = 'QLTDH' 
              AND object_name = 'NHANVIEN' 
              AND policy_name = 'UPDATE_EMPLOYEE') 
  LOOP
    DBMS_FGA.DROP_POLICY(
      object_schema => 'QLTDH',    
      object_name   => 'NHANVIEN',   
      policy_name   => 'UPDATE_EMPLOYEE'  
    );
  END LOOP;
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'QLTDH',             
    object_name     => 'NHANVIEN',              
    policy_name     => 'UPDATE_EMPLOYEE',     
    audit_condition => 'VAITRO != ''NV TCHC''',
    audit_column    => 'HOTEN,PHAI,NGSINH,LUONG,PHUCAP,DT,VAITRO,MADV',  
    statement_types => 'UPDATE'                
  );
END;
/

--Câu lệnh kiểm tra
--GRANT UPDATE ON QLTDH.NHANVIEN TO "NVPKT0001";
--Đăng nhập bằng acc 'NVPKT0001'
--UPDATE QLTDH.NHANVIEN SET PHAI='Nam' WHERE MANV='NVPKT0002';
--UPDATE QLTDH.NHANVIEN SET PHAI='Nam' WHERE MANV='NVPKT0001';

--Kiểm tra audit
--SELECT * FROM DBA_FGA_AUDIT_TRAIL
--WHERE object_name = 'NHANVIEN';

