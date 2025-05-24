ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

--=================================================================================================
-- Procedures cho chính sách RBAC
--=================================================================================================
---------------------------------------------------------------------------------------------------
CONNECT QLTDH/admin123@localhost:1521/QUANLYTRUONGDAIHOC;
-- Nhân viên chỉ có thể cập nhật số điện thoại
-- Tạo procedure để nhân viên cập nhật số điện thoại của mình
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER (
    p_new_phone_number IN VARCHAR2
)
AS
BEGIN
    UPDATE QLTDH.NHANVIEN
    SET DT = p_new_phone_number
    WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
    COMMIT;
END;
/

-- Cấp quyền thực thi procedure cho các role
GRANT EXECUTE ON QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER TO "NVCB", "GV", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "TRGĐV";

---------------------------------------------------------------------------------------------------
-- Tạo procedure để thêm mới môn học
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.EDUCATION_DEPARTMENT_INSERT_COURSE_OFFERING (
    p_mahp IN VARCHAR2,
    p_magv IN VARCHAR2,
    p_hk IN VARCHAR2,
    p_nam IN NUMBER
)
AS
    v_mamm VARCHAR2(10);
    v_max_id NUMBER;
BEGIN   
    -- Kiểm tra học kỳ và năm học
    IF p_hk <> '2' OR p_nam <> 2025 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ được phép thêm môn học trong học kỳ 2 năm 2025');
    END IF;
    
    -- Tìm MAMM lớn nhất hiện tại
    BEGIN
        SELECT TO_NUMBER(SUBSTR(MAX(MAMM), 3)) INTO v_max_id
        FROM QLTDH.MOMON
        WHERE MAMM LIKE 'MM%';
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            v_max_id := 0;
    END;
    
    -- Tạo MAMM mới
    v_mamm := 'MM' || LPAD(TO_CHAR(v_max_id + 1), 4, '0');
    
    -- Thực hiện thêm môn học
    INSERT INTO QLTDH.MOMON (MAMM, MAHP, MAGV, HK, NAM)
    VALUES (v_mamm, p_mahp, p_magv, p_hk, p_nam);
    
    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/
GRANT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_INSERT_COURSE_OFFERING TO "NV PĐT";

---------------------------------------------------------------------------------------------------
-- Tạo procedure để cập nhật môn học
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING (
    p_mamm IN VARCHAR2,
    p_mahp IN VARCHAR2,
    p_magv IN VARCHAR2,
    p_hk IN VARCHAR2,
    p_nam IN NUMBER
)
AS
    v_old_hk VARCHAR2(1);
    v_old_nam NUMBER;
BEGIN   
    -- Kiểm tra học kỳ và năm học mới
    IF p_hk <> '2' OR p_nam <> 2025 THEN
        RAISE_APPLICATION_ERROR(-20003, 'Chỉ được phép cập nhật môn học trong học kỳ 2 năm 2025');
    END IF;
    
    -- Lấy thông tin môn học cũ
    SELECT HK, NAM INTO v_old_hk, v_old_nam
    FROM QLTDH.MOMON
    WHERE MAMM = p_mamm;
    
    -- Kiểm tra môn học cũ có thuộc học kỳ hiện tại không
    IF v_old_hk <> '2' OR v_old_nam <> 2025 THEN
        RAISE_APPLICATION_ERROR(-20003, 'Chỉ được phép cập nhật môn học trong học kỳ 2 năm 2025');
    END IF;
    
    -- Thực hiện cập nhật môn học
    UPDATE QLTDH.MOMON
    SET MAHP = p_mahp, MAGV = p_magv, HK = p_hk, NAM = p_nam
    WHERE MAMM = p_mamm;
    
    COMMIT;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20007, 'Không tìm thấy môn học với mã ' || p_mamm);
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/
GRANT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING TO "NV PĐT";

---------------------------------------------------------------------------------------------------
-- Tạo procedure để xóa môn học
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.EDUCATION_DEPARTMENT_DELETE_COURSE_OFFERING (
    p_mamm IN VARCHAR2
)
AS
    v_hk VARCHAR2(1);
    v_nam NUMBER;
BEGIN   
    -- Lấy thông tin môn học
    SELECT HK, NAM INTO v_hk, v_nam
    FROM QLTDH.MOMON
    WHERE MAMM = p_mamm;
    
    -- Kiểm tra môn học có thuộc học kỳ hiện tại không
    IF v_hk <> '2' OR v_nam <> 2025 THEN
        RAISE_APPLICATION_ERROR(-20005, 'Chỉ được phép xóa môn học trong học kỳ 2 năm 2025');
    END IF;
    
    -- Thực hiện xóa môn học
    DELETE FROM QLTDH.MOMON WHERE MAMM = p_mamm;
    
    COMMIT;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        RAISE_APPLICATION_ERROR(-20008, 'Không tìm thấy môn học với mã ' || p_mamm);
    WHEN OTHERS THEN
        ROLLBACK;
        RAISE;
END;
/
GRANT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_DELETE_COURSE_OFFERING TO "NV PĐT";

--=================================================================================================
-- Procedures cho Winform Application - phân hệ 2
--=================================================================================================


---------------------------------------------------------------------------------------------------
--Xem danh sách nhân viên
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.GET_EMPLOYEE_LIST(
    name IN VARCHAR2,
    role IN VARCHAR2,
    employees_cursor OUT SYS_REFCURSOR)
AS
BEGIN
    IF role IN ('NVCB', 'GV', 'NV PĐT', 'NV PKT', 'NV CTSV') THEN
        OPEN employees_cursor FOR 
        SELECT * FROM EMPLOYEE_GET_PERSONAL_INFO
        WHERE name IS NULL OR LOWER(HOTEN) LIKE '%' || LOWER(name) || '%';
    ELSIF role = 'TRGĐV' THEN
        OPEN employees_cursor FOR
        SELECT * FROM EMPLOYEE_GET_PERSONAL_INFO
        WHERE name IS NULL OR LOWER(HOTEN) LIKE '%' || LOWER(name) || '%'
        UNION
        SELECT MANV, HOTEN, PHAI, NGSINH, NULL AS LUONG, NULL AS PHUCAP, DT, VAITRO, MADV 
        FROM EMPLOYEE_UNIT_INFO u
        WHERE (name IS NULL OR LOWER(HOTEN) LIKE '%' || LOWER(name) || '%')
        AND NOT EXISTS (SELECT 1 FROM EMPLOYEE_GET_PERSONAL_INFO p WHERE p.MANV = u.MANV);

    ELSIF role='NV TCHC' THEN
        OPEN employees_cursor FOR
        SELECT * FROM EMPLOYEE_GET_PERSONAL_INFO
        WHERE name IS NULL OR LOWER(HOTEN) LIKE '%' || LOWER(name) || '%'
        UNION
        SELECT * FROM QLTDH.NHANVIEN u
        WHERE (name IS NULL OR LOWER(HOTEN) LIKE '%' || LOWER(name) || '%')
        AND NOT EXISTS (SELECT 1 FROM EMPLOYEE_GET_PERSONAL_INFO p WHERE p.MANV = u.MANV);
    ELSE
        OPEN employees_cursor FOR SELECT * FROM DUAL WHERE 1 = 0; 
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.GET_EMPLOYEE_LIST TO NVCB, GV, "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", TRGĐV;

---------------------------------------------------------------------------------------------------
--Thêm nhân viên
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.INSERT_EMPLOYEE(
    fullname IN VARCHAR2,
    gender IN VARCHAR2,
    DOB IN DATE,
    salary IN NUMBER,
    allowance IN NUMBER,
    phone IN VARCHAR2,
    role IN VARCHAR2,
    unit IN VARCHAR2
)
AS
    v_prefix VARCHAR2(20);
    v_count NUMBER;
    v_manv VARCHAR2(20);
    v_unitID VARCHAR2(20);
BEGIN
    v_prefix := REPLACE(role, ' ', '');

    SELECT COUNT(*) + 1 INTO v_count
    FROM QLTDH.NHANVIEN
    WHERE MANV LIKE v_prefix || '%';

    v_manv := v_prefix || LPAD(v_count, 4, '0');
    
    SELECT MADV INTO v_unitID FROM QLTDH.DONVI WHERE TENDV=unit;

    INSERT INTO QLTDH.NHANVIEN(MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV)
    VALUES(v_manv, fullname, gender, DOB, salary, allowance, phone, role, v_unitID);
END;
/
GRANT EXECUTE ON QLTDH.INSERT_EMPLOYEE TO "NV TCHC";

---------------------------------------------------------------------------------------------------
--Chỉnh sửa nhân viên
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.UPDATE_EMPLOYEE(
    employeeID IN VARCHAR2,
    fullname IN VARCHAR2,
    gender IN VARCHAR2,
    DOB IN DATE,
    salary IN NUMBER,
    allowance IN NUMBER,
    phone IN VARCHAR2,
    role IN VARCHAR2,
    unitID IN VARCHAR2
)
AS
BEGIN
    UPDATE QLTDH.NHANVIEN
    SET HOTEN=fullname, PHAI=gender, NGSINH=DOB, LUONG=salary, 
        PHUCAP= allowance, DT=phone, VAITRO=role, MADV=unitID
    WHERE MANV=employeeID;
END;
/
GRANT EXECUTE ON QLTDH.UPDATE_EMPLOYEE TO "NV TCHC";

---------------------------------------------------------------------------------------------------
--Xem thông tin danh sách mở môn
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.GET_OPEN_SUBJECT_LIST(
    name IN VARCHAR2,
    role IN VARCHAR2,
    subject_cursor OUT SYS_REFCURSOR)
AS
BEGIN
    IF role='GV' THEN OPEN subject_cursor FOR 
        SELECT * FROM QLTDH.TEACHER_GET_COURSE_OFFERING
        WHERE name IS NULL OR LOWER(TENHP) LIKE '%' || LOWER(name) || '%';
    ELSIF role='NV PĐT' THEN OPEN subject_cursor FOR 
        SELECT * FROM QLTDH.EDUCATION_DEPARTMENT_GET_COURSE_OFFERING
        WHERE name IS NULL OR LOWER(TENHP) LIKE '%' || LOWER(name) || '%';
    ELSIF role='TRGĐV' THEN OPEN subject_cursor FOR 
        SELECT * FROM QLTDH.UNIT_HEAD_GET_FACULTY_TEACHING
        WHERE name IS NULL OR LOWER(TENHP) LIKE '%' || LOWER(name) || '%';
    ELSIF role='SV' THEN OPEN subject_cursor FOR 
        SELECT * FROM QLTDH.STUDENT_GET_DEPARTMENT_COURSES
        WHERE name IS NULL OR LOWER(TENHP) LIKE '%' || LOWER(name) || '%';
    ELSE 
        OPEN subject_cursor FOR SELECT * FROM DUAL WHERE 1 = 0; 
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.GET_OPEN_SUBJECT_LIST TO GV, "NV PĐT", TRGĐV, SV;
GRANT SELECT ON QLTDH.DONVI TO "NV TCHC";
GRANT SELECT ON QLTDH.HOCPHAN TO "NV PĐT";

---------------------------------------------------------------------------------------------------
--Xem danh sách mã giảng viên để thêm mới mở môn
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE VIEW QLTDH.v_TeacherID
AS
    SELECT MANV FROM QLTDH.NHANVIEN WHERE VAITRO='GV';
    
GRANT SELECT ON QLTDH.v_TeacherID TO "NV PĐT";
/

--Xem danh sách sinh viên
CREATE OR REPLACE PROCEDURE QLTDH.GET_STUDENT_LIST(
    name IN VARCHAR2,
    role IN VARCHAR2,
    student_cursor OUT SYS_REFCURSOR)
AS
BEGIN
    IF role in ('GV', 'SV', 'NV CTSV', 'NV PĐT') THEN
        OPEN student_cursor FOR 
        SELECT * FROM QLTDH.SINHVIEN
        WHERE name IS NULL OR LOWER(HOTEN) LIKE '%' || LOWER(name) || '%';
    ELSE
        OPEN student_cursor FOR SELECT * FROM DUAL WHERE 1 = 0; 
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.GET_STUDENT_LIST TO GV, SV, "NV PĐT","NV CTSV";
GRANT SELECT ON QLTDH.DONVI TO "NV CTSV";

---------------------------------------------------------------------------------------------------
-- Cập nhật thông tin sinh viên
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.UPDATE_STUDENT(
    studentID IN VARCHAR2,
    fullname IN VARCHAR,
    gender IN VARCHAR2,
    DOB IN DATE,
    address IN VARCHAR2,
    phone IN VARCHAR2,
    department IN VARCHAR2,
    status IN VARCHAR2,
    role IN VARCHAR2
)
AS
BEGIN
    IF role = 'SV' THEN
        UPDATE QLTDH.SINHVIEN
        SET DCHI = address, DT = phone
        WHERE MASV=studentID;
    ELSIF role = 'NV CTSV' THEN
        UPDATE QLTDH.SINHVIEN
        SET HOTEN = fullname, PHAI = gender, NGSINH = DOB, DCHI = address, DT = phone, KHOA = department
        WHERE MASV=studentID;
    ELSIF role = 'NV PĐT' THEN
        UPDATE QLTDH.SINHVIEN
        SET TINHTRANG = status
        WHERE MASV=studentID;
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ có sinh viên và nhân viên phòng CTSV mới có quyền cập nhật thông tin sinh viên!');
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.UPDATE_STUDENT TO SV, "NV CTSV", "NV PĐT";

---------------------------------------------------------------------------------------------------
--Thêm sinh viên
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.INSERT_STUDENT(
    fullname IN VARCHAR,
    gender IN VARCHAR2,
    DOB IN DATE,
    address IN VARCHAR2,
    phone IN VARCHAR2,
    department IN VARCHAR2,
    role IN VARCHAR2
)
AS
    v_prefix VARCHAR2(20);
    v_count NUMBER;
    v_masv VARCHAR2(20);
    v_departmentID VARCHAR2(20);
BEGIN
    IF role = 'NV CTSV' THEN
        v_prefix := REPLACE(role, ' ', '');

        SELECT COUNT(*) + 1 INTO v_count
        FROM QLTDH.SINHVIEN
        WHERE MASV LIKE v_prefix || '%';

        v_masv := v_prefix || LPAD(v_count, 4, '0');
        
        SELECT MADV INTO v_departmentID FROM QLTDH.DONVI WHERE TENDV=department and LOAIDV='Khoa';
        
        INSERT INTO QLTDH.SINHVIEN(MASV, HOTEN, PHAI, NGSINH, DCHI, DT, KHOA, TINHTRANG)
        VALUES(v_masv, fullname, gender, DOB, address, phone, v_departmentID, NULL);
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ có nhân viên phòng CTSV mới có quyền thêm sinh viên!');
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.INSERT_STUDENT TO "NV CTSV";

---------------------------------------------------------------------------------------------------
-- Xoá thông tin sinh viên
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.DELETE_STUDENT(
    studentID IN VARCHAR2,
    role IN VARCHAR2
)
AS
BEGIN
    IF role = 'NV CTSV' THEN
        DELETE FROM QLTDH.SINHVIEN WHERE MASV=studentID;
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ có nhân viên phòng CTSV mới có quyền xóa thông tin sinh viên!');
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.DELETE_STUDENT TO "NV CTSV";

---------------------------------------------------------------------------------------------------
-- Xem danh sách đăng ký
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.GET_REGISTER_LIST(
    name IN VARCHAR2,
    role IN VARCHAR2,
    register_cursor OUT SYS_REFCURSOR)
AS
BEGIN
    IF role IN ('GV', 'SV', 'NV PĐT', 'NV PKT') THEN
        OPEN register_cursor FOR 
        SELECT * FROM QLTDH.DANGKY
        WHERE name IS NULL OR LOWER(MASV) LIKE '%' || LOWER(name) || '%';
    ELSE 
        OPEN register_cursor FOR SELECT * FROM DUAL WHERE 1 = 0; 
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.GET_REGISTER_LIST TO GV, SV, "NV PĐT", "NV PKT";

---------------------------------------------------------------------------------------------------
-- Kiểm tra xem khoảng cách từ ngày hiện tại đến NgayBD ở bảng MOMON của MAMM đó có lớn hơn 14 hay không
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.CHECK_REGISTER_DELETE(
    openSubjectID IN VARCHAR2,
    role IN VARCHAR2,
    result OUT NUMBER
)
AS
    v_current_date DATE;
    v_start_date DATE;
    v_days_difference NUMBER;
BEGIN
    IF role IN ('SV', 'NV PĐT') THEN
        -- Lấy ngày hiện tại
        SELECT SYSDATE INTO v_current_date FROM DUAL;

        -- Lấy ngày bắt đầu từ bảng MOMON
        SELECT NGAYBD INTO v_start_date FROM QLTDH.MOMON WHERE MAMM = openSubjectID;

        -- Tính khoảng cách giữa hai ngày
        v_days_difference := v_current_date - v_start_date;
        IF v_days_difference <= 14 THEN
            result := 1; -- Có thể xóa
        ELSE
            result := 0; -- Không thể xóa
        END IF;
    ELSE
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ có sinh viên và nhân viên phòng PĐT mới có quyền kiểm tra xoá thông tin đăng ký!');
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.CHECK_REGISTER_DELETE TO SV, "NV PĐT";

---------------------------------------------------------------------------------------------------
-- Xoá thông tin đăng ký
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.DELETE_REGISTER(
    studentID IN VARCHAR2,
    openSubjectID IN VARCHAR2,
    role IN VARCHAR2
)
AS 
BEGIN
    IF role IN ('SV', 'NV PĐT') THEN
        DELETE FROM QLTDH.DANGKY WHERE MASV=studentID AND MAMM=openSubjectID;
    ELSE 
        RAISE_APPLICATION_ERROR(-20001, 'Chỉ có sinh viên và nhân viên phòng PĐT mới có quyền xóa thông tin đăng ký!');
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.DELETE_REGISTER TO SV, "NV PĐT";

---------------------------------------------------------------------------------------------------
-- Thêm đăng ký
---------------------------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE QLTDH.INSERT_REGISTER(
    studentID IN VARCHAR2,
    openSubjectID IN VARCHAR2,
    role IN VARCHAR2
)
AS
    v_current_date DATE;
    v_start_date DATE;
    v_days_difference NUMBER;
    v_count NUMBER;
BEGIN
    -- Kiểm tra xem sinh viên đã đăng ký môn học này chưa
    SELECT COUNT(*) INTO v_count FROM QLTDH.DANGKY WHERE MASV = studentID AND MAMM = openSubjectID;
    IF v_count > 0 THEN
        RAISE_APPLICATION_ERROR(-20010, 'Sinh viên đã đăng ký môn học này rồi!');
    END IF;

    IF role IN ('SV', 'NV PĐT') THEN
        -- Lấy ngày hiện tại
        SELECT SYSDATE INTO v_current_date FROM DUAL;

        -- Lấy ngày bắt đầu từ bảng MOMON
        SELECT NGAYBD INTO v_start_date FROM QLTDH.MOMON WHERE MAMM = openSubjectID;

        -- Tính khoảng cách giữa hai ngày
        v_days_difference := v_current_date - v_start_date;
        IF v_days_difference <= 14 THEN
            INSERT INTO QLTDH.DANGKY(MASV, MAMM, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES(studentID, openSubjectID, NULL, NULL, NULL, NULL);
            COMMIT;
        ELSE
            RAISE_APPLICATION_ERROR(-20020, 'Không thể đăng ký môn học này vì đã quá thời gian cho phép!');
        END IF;
    ELSE 
        RAISE_APPLICATION_ERROR(-20030, 'Chỉ có sinh viên và nhân viên phòng PĐT mới có quyền thêm thông tin đăng ký!');
    END IF;
END;
/
GRANT EXECUTE ON QLTDH.INSERT_REGISTER TO SV, "NV PĐT";
/