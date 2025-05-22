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
    v_value VARCHAR2(30);
BEGIN
    SELECT VALUE INTO v_value FROM V$PARAMETER WHERE NAME='audit_trail';
    IF v_value IN ('DB', 'DB, EXTENDED', 'XML', 'XML, EXTENDED') THEN
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

--Câu lệnh kiểm tra
--UPDATE QLTDH.DANGKY
--SET DIEMTH = 7.0
--WHERE MASV = 'SV0001' AND MAMM='MM0002';
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

----==============================================================================
--Hành vi thêm, xóa, sửa trên quan hệ DANGKY của sinh viên nhưng trên dòng
--dữ liệu của sinh viên khác hoặc thực hiện hiệu chỉnh đăng ký học phần ngoài
--thời gian cho phép hiệu chỉnh đăng ký học phần.
--BEGIN
--  FOR rec IN (SELECT policy_name 
--              FROM DBA_AUDIT_POLICIES 
--              WHERE object_schema = 'QLTDH' 
--              AND object_name = 'DANGKY' 
--              AND policy_name = 'UML_DANGKY') 
--  LOOP
--    DBMS_FGA.DROP_POLICY(
--      object_schema => 'QLTDH',    
--      object_name   => 'DANGKY',   
--      policy_name   => 'UML_DANGKY'  
--    );
--  END LOOP;
--END;
--/
--BEGIN
--  DBMS_FGA.ADD_POLICY(
--    object_schema    => 'QLTDH',
--    object_name      => 'DANGKY',
--    policy_name      => 'UML_DANGKY',
--    audit_condition  => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') != MASV', 
--    statement_types  => 'INSERT, UPDATE, DELETE',
--    audit_column     => NULL,
--    enable           => TRUE
--  );
--END;
--/
--
----Câu lệnh kiểm tra
--UPDATE QLTDH.DANGKY
--SET DIEMCK = 9.5
--WHERE MASV = 'SV0010' AND MAMM = 'MM0001';
----
----Kiểm tra audit
--SELECT * FROM DBA_FGA_AUDIT_TRAIL
--WHERE object_name = 'DANGKY';