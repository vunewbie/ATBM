-----------------------------------------------------------------------------------------------------
---- 1. Kích hoạt việc ghi nhật ký hệ thống.
-----------------------------------------------------------------------------------------------------
CONNECT SYS/oracle@localhost:1521/QUANLYTRUONGDAIHOC AS SYSDBA;

-- Đặt audit_trail trong SPFILE
ALTER SESSION SET CONTAINER = CDB$ROOT;
SELECT SYS_CONTEXT('USERENV', 'CON_NAME'), USER FROM DUAL;
ALTER SYSTEM SET audit_trail = DB SCOPE = BOTH;
-- Hoặc, bạn có thể đăng ký lại tham số mà không cần khởi động lại toàn bộ database
ALTER SYSTEM REGISTER;

-- Để thay đổi có hiệu lực, chúng ta sẽ tạm dừng và khởi động lại PDB
ALTER PLUGGABLE DATABASE QUANLYTRUONGDAIHOC CLOSE IMMEDIATE;
ALTER PLUGGABLE DATABASE QUANLYTRUONGDAIHOC OPEN;
ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Cấp quyền truy cập các bảng dữ liệu audit cho QLTDH
GRANT SELECT ON SYS.DBA_AUDIT_TRAIL TO QLTDH;
GRANT SELECT ON SYS.DBA_FGA_AUDIT_TRAIL TO QLTDH;
GRANT SELECT ON SYS.DBA_AUDIT_POLICIES TO QLTDH;
GRANT SELECT ON SYS.V$PARAMETER TO QLTDH;

-- Cấp quyền quản lý FGA
GRANT EXECUTE ON DBMS_FGA TO QLTDH;

-- Tạo procedure trong schema SYS sử dụng AUTHID DEFINER
CREATE OR REPLACE PROCEDURE SYS.EXECUTE_AUDIT_FOR_QLTDH(
    p_audit_command IN VARCHAR2
) 
AUTHID DEFINER  -- Chạy với quyền hạn của SYS
AS 
BEGIN
    EXECUTE IMMEDIATE p_audit_command;
END;
/

-- Cấp quyền thực thi cho QLTDH
GRANT EXECUTE ON SYS.EXECUTE_AUDIT_FOR_QLTDH TO QLTDH;

-- Sửa lại procedure ENABLE_ALL_AUDIT trong schema QLTDH
CREATE OR REPLACE PROCEDURE QLTDH.ENABLE_ALL_AUDIT
AS 
BEGIN
    -- Thực hiện các lệnh audit cụ thể thay vì AUDIT ALL
    SYS.EXECUTE_AUDIT_FOR_QLTDH('AUDIT INSERT, DELETE ON QLTDH.NHANVIEN BY ACCESS');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('AUDIT DELETE ON QLTDH.SINHVIEN BY ACCESS');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('AUDIT UPDATE ON QLTDH.MOMON BY ACCESS');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('AUDIT EXECUTE ON QLTDH.INSERT_EMPLOYEE BY ACCESS');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('AUDIT EXECUTE ON QLTDH.DELETE_STUDENT BY ACCESS');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('AUDIT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING BY ACCESS');
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'Lỗi khi bật audit: ' || SQLERRM);
END;
/

-- Sửa lại procedure DISABLE_ALL_AUDIT trong schema QLTDH
CREATE OR REPLACE PROCEDURE QLTDH.DISABLE_ALL_AUDIT
AS 
BEGIN
    -- Tắt các lệnh audit cụ thể
    SYS.EXECUTE_AUDIT_FOR_QLTDH('NOAUDIT INSERT, DELETE ON QLTDH.NHANVIEN');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('NOAUDIT DELETE ON QLTDH.SINHVIEN');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('NOAUDIT UPDATE ON QLTDH.MOMON');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('NOAUDIT EXECUTE ON QLTDH.INSERT_EMPLOYEE');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('NOAUDIT EXECUTE ON QLTDH.DELETE_STUDENT');
    SYS.EXECUTE_AUDIT_FOR_QLTDH('NOAUDIT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING');
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'Lỗi khi tắt audit: ' || SQLERRM);
END;
/

-- Tiếp tục với phần có sẵn của bạn từ dòng "CONNECT QLTDH/admin123"

CONNECT QLTDH/admin123@localhost:1521/QUANLYTRUONGDAIHOC;
---------------------------------------------------------------------------------------------------
-- 2. Thực hiện ghi nhật ký hệ thống dùng Standard audit:.
---------------------------------------------------------------------------------------------------
-- 2.1. Audit thêm, xóa trên bảng NHANVIEN
AUDIT INSERT, DELETE ON QLTDH.NHANVIEN BY ACCESS;
AUDIT EXECUTE ON QLTDH.INSERT_EMPLOYEE BY ACCESS;

-- -- Test
-- CONNECT NVTCHC0001/NVTCHC0001@localhost:1521/QUANLYTRUONGDAIHOC;
-- INSERT INTO QLTDH.NHANVIEN (MANV) VALUES ('TEST');
-- DELETE FROM QLTDH.NHANVIEN WHERE MANV = 'TEST';

-- 2.2. Audit xóa trên bảng SINHVIEN
AUDIT DELETE ON QLTDH.SINHVIEN BY ACCESS;
AUDIT EXECUTE ON QLTDH.DELETE_STUDENT BY ACCESS;

-- -- Test
-- CONNECT NVCTSV0001/NVCTSV0001@localhost:1521/QUANLYTRUONGDAIHOC;
-- BEGIN
--    QLTDH.INSERT_STUDENT('Sinh Viên Test', 'Nam', TO_DATE('2000-01-01', 'YYYY-MM-DD'),
--        'Địa chỉ test', '0912345678', 'Công nghệ thông tin', 'NV CTSV');
-- END;
-- /
-- BEGIN
--    QLTDH.DELETE_STUDENT('SV4001', 'NV CTSV');
-- END;
-- /
-- CONNECT QLTDH/admin123@localhost:1521/QUANLYTRUONGDAIHOC;

-- 2.3. Audit cập nhật trên bảng MOMON
AUDIT UPDATE ON QLTDH.MOMON BY ACCESS;
AUDIT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING BY ACCESS;

-- -- TEST
-- CONNECT NVPDT0001/NVPDT0001@localhost:1521/QUANLYTRUONGDAIHOC;
-- BEGIN
--     QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING('MM2001', 'CNT0001', 'GV0001', '2', 2025);
-- END;
-- /
-- UPDATE QLTDH.MOMON
-- SET MAGV = 'GV0010'
-- WHERE MAMM = 'MM2001' AND HK = '2' AND NAM = 2025;
-- BEGIN
--     QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING('MM2001', 'CNT0001', 'GV0010', '2', 2025);
-- EXCEPTION
--     WHEN OTHERS THEN
--         DBMS_OUTPUT.PUT_LINE('Lỗi như dự kiến: ' || SQLERRM);
-- END;
-- /
-- CONNECT QLTDH/admin123@localhost:1521/QUANLYTRUONGDAIHOC;

-- SELECT *
-- FROM DBA_AUDIT_TRAIL
-- ORDER BY TIMESTAMP DESC;
-----------------------------------------------------------------------------------------------------
---- 3. Fine-grained Audit
-----------------------------------------------------------------------------------------------------
-- 3.1. Procedure để load lên
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
            ''STANDARD'' AS AUDIT_TYPE,
            CAST(EXTENDED_TIMESTAMP AS TIMESTAMP) AS EVENT_TIMESTAMP,
            USERNAME AS DBUSERNAME,
            OBJ_NAME AS OBJECT_NAME,
            SQL_TEXT,
            NULL AS FGA_POLICY_NAME
        FROM DBA_AUDIT_TRAIL
        WHERE ';

    IF p_table_name IS NOT NULL THEN
        v_sql := v_sql || 'UPPER(OBJ_NAME) = ''' || UPPER(p_table_name) || '''';
    ELSE
        v_sql := v_sql || '1=1';
    END IF;

    v_sql := v_sql || '
        UNION ALL
        SELECT
            ''FGA'' AS AUDIT_TYPE,
            CAST(TIMESTAMP AS TIMESTAMP) AS EVENT_TIMESTAMP,
            DB_USER AS DBUSERNAME,
            OBJECT_NAME,
            SQL_TEXT,
            POLICY_NAME AS FGA_POLICY_NAME
        FROM DBA_FGA_AUDIT_TRAIL
        WHERE ';

    IF p_table_name IS NOT NULL THEN
        v_sql := v_sql || 'UPPER(OBJECT_NAME) LIKE ''%' || UPPER(p_table_name) || '%''';
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
    v_nhanvien_count NUMBER := 0;
    v_sinhvien_count NUMBER := 0;
    v_momon_count    NUMBER := 0;
    v_fga_count      NUMBER := 0;
BEGIN
    -- Kiểm tra audit trên NHANVIEN
    SELECT COUNT(*) INTO v_nhanvien_count
    FROM DBA_OBJ_AUDIT_OPTS
    WHERE OWNER = 'QLTDH' AND OBJECT_NAME = 'NHANVIEN'
    AND (INS != '-/-' OR DEL != '-/-');

    -- Kiểm tra audit trên SINHVIEN
    SELECT COUNT(*) INTO v_sinhvien_count
    FROM DBA_OBJ_AUDIT_OPTS
    WHERE OWNER = 'QLTDH' AND OBJECT_NAME = 'SINHVIEN'
    AND DEL != '-/-';

    -- Kiểm tra audit trên MOMON
    SELECT COUNT(*) INTO v_momon_count
    FROM DBA_OBJ_AUDIT_OPTS
    WHERE OWNER = 'QLTDH' AND OBJECT_NAME = 'MOMON'
    AND UPD != '-/-';

    -- Kiểm tra chính sách FGA
    SELECT COUNT(*) INTO v_fga_count
    FROM DBA_AUDIT_POLICIES
    WHERE OBJECT_SCHEMA = 'QLTDH' AND ENABLED = 'YES';

    -- Đánh giá trạng thái audit
    IF v_nhanvien_count > 0 AND v_sinhvien_count > 0 AND v_momon_count > 0 THEN
        p_status := 'TRUE';
    ELSIF v_fga_count > 0 THEN
        p_status := 'TRUE';
    ELSE
        p_status := 'FALSE';
    END IF;
EXCEPTION
    WHEN OTHERS THEN
        p_status := 'FALSE';
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
--    IF p_table_name IS NOT NULL THEN
--        v_sql := v_sql || 'OBJECT_NAME = ''' || UPPER(p_table_name) || '''';
--    ELSE
--        v_sql := v_sql || '1=1'; 
--    END IF;
--
--    IF p_sort_time THEN
--        v_sql := v_sql || ' ORDER BY EVENT_TIMESTAMP DESC';
--    ELSE
--        v_sql := v_sql || ' ORDER BY EVENT_TIMESTAMP ASC';
--    END IF;
--
--    OPEN audit_cursor FOR v_sql;
--END;
--/
--
--CREATE OR REPLACE PROCEDURE QLTDH.CHECK_AUDIT_STATUS (
--    p_status OUT VARCHAR2
--)
--AS
--    v_enabled VARCHAR2(10);
--BEGIN
--    SELECT VALUE INTO v_enabled
--    FROM V$OPTION
--    WHERE PARAMETER = 'Unified Auditing';
--
--    IF v_enabled = 'TRUE' THEN
--        p_status := 'TRUE';
--    ELSE
--        p_status := 'FALSE';
--    END IF;
--
--EXCEPTION
--    WHEN OTHERS THEN
--        p_status := 'FALSE';
--END;
--/
--
--CREATE OR REPLACE PROCEDURE QLTDH.ENABLE_ALL_AUDIT
--AS 
--BEGIN
--  EXECUTE IMMEDIATE 'AUDIT ALL BY ACCESS';
--EXCEPTION
--  WHEN OTHERS THEN
--    RAISE_APPLICATION_ERROR(-20001, 'Lỗi khi bật audit: ' || SQLERRM);
--END;
--/
--
--CREATE OR REPLACE PROCEDURE QLTDH.DISABLE_ALL_AUDIT
--AS 
--BEGIN
--  EXECUTE IMMEDIATE 'NOAUDIT';
--EXCEPTION
--  WHEN OTHERS THEN
--    RAISE_APPLICATION_ERROR(-20002, 'Lỗi khi tắt audit: ' || SQLERRM);
--END;
--/
--
----==============================================================================
----Tạo chính sách FGA
----==============================================================================
----Hành vi cập nhật quan hệ ĐANGKY tại các trường liên quan đến điểm số nhưng
----người đó không thuộc vai trò “NV PKT”.
--BEGIN
--  FOR rec IN (SELECT policy_name 
--              FROM DBA_AUDIT_POLICIES 
--              WHERE object_schema = 'QLTDH' 
--              AND object_name = 'DANGKY' 
--              AND policy_name = 'UPDATE_SCORE') 
--  LOOP
--    DBMS_FGA.DROP_POLICY(
--      object_schema => 'QLTDH',    
--      object_name   => 'DANGKY',   
--      policy_name   => 'UPDATE_SCORE'  
--    );
--  END LOOP;
--END;
--/
--BEGIN
--  DBMS_FGA.ADD_POLICY(
--    object_schema   => 'QLTDH',             
--    object_name     => 'DANGKY',              
--    policy_name     => 'UPDATE_SCORE',     
--    audit_condition => 'VAITRO != ''NV PKT''',
--    audit_column    => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',  
--    statement_types => 'UPDATE'                
--  );
--END;
--/
--
----Câu lệnh kiểm tra
----UPDATE QLTDH.DANGKY
----SET DIEMTH = 7.0
----WHERE MASV = 'SV0001' AND MAMM='MM0002';
----
----CONNECT NVPKT0001/NVPKT0001@localhost:1521/QUANLYTRUONGDAIHOC;
----UPDATE QLTDH.DANGKY
----SET DIEMTH = 6.0
----WHERE MASV = 'SV0001' AND MAMM='MM0002';
--
----Kiểm tra audit
----CONNECT QLTDH/admin123@localhost:1521/QUANLYTRUONGDAIHOC;
----SELECT * FROM DBA_FGA_AUDIT_TRAIL
----WHERE object_name = 'DANGKY';
--
--
----==============================================================================
----Hành vi của người dùng (không thuộc vai trò “NV TCHC”) có thể đọc trên
----trường LUONG, PHUCAP của người khác ở quan hệ NHANVIEN.
--BEGIN
--  FOR rec IN (SELECT policy_name 
--              FROM DBA_AUDIT_POLICIES 
--              WHERE object_schema = 'QLTDH' 
--              AND object_name = 'NHANVIEN' 
--              AND policy_name = 'SELECT_EMPLOYEE') 
--  LOOP
--    DBMS_FGA.DROP_POLICY(
--      object_schema => 'QLTDH',    
--      object_name   => 'NHANVIEN',   
--      policy_name   => 'SELECT_EMPLOYEE'  
--    );
--  END LOOP;
--END;
--/
--BEGIN
--  DBMS_FGA.ADD_POLICY(
--    object_schema   => 'QLTDH',             
--    object_name     => 'NHANVIEN',              
--    policy_name     => 'SELECT_EMPLOYEE',     
--    audit_condition => 'VAITRO != ''NV TCHC'' AND MANV != SYS_CONTEXT(''USERENV'', ''SESSION_USER'')',
--    audit_column    => 'LUONG,PHUCAP',  
--    statement_types => 'SELECT'                
--  );
--END;
--/
--
----Câu lệnh kiểm tra
----GRANT SELECT ON QLTDH.NHANVIEN TO "NVPKT0001";
----Đăng nhập bằng acc 'NVPKT0001'
----SELECT LUONG, PHUCAP FROM QLTDH.NHANVIEN WHERE MANV='NVPKT0001'; --không bị audit
----SELECT LUONG, PHUCAP FROM QLTDH.NHANVIEN WHERE MANV='NVPKT0002'; --bị audit
--
----Kiểm tra audit
----SELECT * FROM DBA_FGA_AUDIT_TRAIL
----WHERE object_name = 'NHANVIEN';
--
----==============================================================================
----Hành vi của người dùng (không thuộc vai trò “NV TCHC”) cập nhật ở 
----quan hệ NHANVIEN.
--BEGIN
--  FOR rec IN (SELECT policy_name 
--              FROM DBA_AUDIT_POLICIES 
--              WHERE object_schema = 'QLTDH' 
--              AND object_name = 'NHANVIEN' 
--              AND policy_name = 'UPDATE_EMPLOYEE') 
--  LOOP
--    DBMS_FGA.DROP_POLICY(
--      object_schema => 'QLTDH',    
--      object_name   => 'NHANVIEN',   
--      policy_name   => 'UPDATE_EMPLOYEE'  
--    );
--  END LOOP;
--END;
--/
--BEGIN
--  DBMS_FGA.ADD_POLICY(
--    object_schema   => 'QLTDH',             
--    object_name     => 'NHANVIEN',              
--    policy_name     => 'UPDATE_EMPLOYEE',     
--    audit_condition => 'VAITRO != ''NV TCHC''',
--    audit_column    => 'HOTEN,PHAI,NGSINH,LUONG,PHUCAP,DT,VAITRO,MADV',  
--    statement_types => 'UPDATE'                
--  );
--END;
--/
--
----Câu lệnh kiểm tra
----GRANT UPDATE ON QLTDH.NHANVIEN TO "NVPKT0001";
----Đăng nhập bằng acc 'NVPKT0001'
----UPDATE QLTDH.NHANVIEN SET PHAI='Nam' WHERE MANV='NVPKT0002';
----UPDATE QLTDH.NHANVIEN SET PHAI='Nam' WHERE MANV='NVPKT0001';
--
----Kiểm tra audit
----SELECT * FROM DBA_FGA_AUDIT_TRAIL
----WHERE object_name = 'NHANVIEN';
--
