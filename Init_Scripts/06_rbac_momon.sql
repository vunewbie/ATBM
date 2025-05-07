ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Giảng viên có quyền xem thông tin phân công giảng dạy của mình
-- Tạo view để giảng viên xem thông tin phân công giảng dạy của mình
CREATE OR REPLACE VIEW QLTDH.TEACHER_GET_COURSE_OFFERING 
AS
    SELECT MM.MAMM, MM.MAHP, MM.MAGV, MM.HK, MM.NAM, 
           HP.TENHP, HP.SOTC, HP.STLT, HP.STTH, HP.MADV,
           DV.TENDV
    FROM QLTDH.MOMON MM
    JOIN QLTDH.HOCPHAN HP ON MM.MAHP = HP.MAHP
    JOIN QLTDH.DONVI DV ON HP.MADV = DV.MADV
    WHERE MM.MAGV = SYS_CONTEXT('USERENV', 'SESSION_USER');

-- Cấp quyền cho role GV
GRANT SELECT ON QLTDH.TEACHER_GET_COURSE_OFFERING TO "GV";


-- Nhân viên PĐT có quyền thao tác trên bảng MOMON trong học kỳ hiện tại
-- Tạo view cho phép nhân viên PĐT thao tác trên MOMON trong học kỳ hiện tại (HK 2, 2025)
CREATE OR REPLACE VIEW QLTDH.EDUCATION_DEPARTMENT_GET_COURSE_OFFERING
AS
    SELECT MM.MAMM, MM.MAHP, MM.MAGV, MM.HK, MM.NAM, 
           HP.TENHP, HP.SOTC, HP.STLT, HP.STTH, HP.MADV, 
           NV.HOTEN AS TENGV, DV.TENDV
    FROM QLTDH.MOMON MM
    JOIN QLTDH.HOCPHAN HP ON MM.MAHP = HP.MAHP
    JOIN QLTDH.NHANVIEN NV ON MM.MAGV = NV.MANV
    JOIN QLTDH.DONVI DV ON HP.MADV = DV.MADV
    WHERE MM.HK = '2'
    AND MM.NAM = 2025;


-- Tạo procedure để thêm mới môn học
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

-- Tạo procedure để cập nhật môn học
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

-- Tạo procedure để xóa môn học
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

-- Cấp quyền cho role NV PĐT
GRANT SELECT ON QLTDH.EDUCATION_DEPARTMENT_GET_COURSE_OFFERING TO "NV PĐT";
GRANT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_INSERT_COURSE_OFFERING TO "NV PĐT";
GRANT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING TO "NV PĐT";
GRANT EXECUTE ON QLTDH.EDUCATION_DEPARTMENT_DELETE_COURSE_OFFERING TO "NV PĐT";


-- Trưởng đơn vị có quyền xem thông tin phân công giảng dạy của giảng viên trong đơn vị
-- Tạo view cho phép trưởng đơn vị xem thông tin phân công giảng dạy của giảng viên trong đơn vị
CREATE OR REPLACE VIEW QLTDH.UNIT_HEAD_GET_FACULTY_TEACHING
AS
    SELECT 
        MM.MAMM, MM.MAHP, MM.MAGV, MM.HK, MM.NAM,
        HP.TENHP, HP.SOTC, HP.STLT, HP.STTH, HP.MADV,
        DV.TENDV,
        NV.HOTEN, NV.PHAI, NV.NGSINH, NV.DT
    FROM QLTDH.MOMON MM
    JOIN QLTDH.HOCPHAN HP ON MM.MAHP = HP.MAHP
    JOIN QLTDH.NHANVIEN NV ON MM.MAGV = NV.MANV
    JOIN QLTDH.DONVI DV ON NV.MADV = DV.MADV
    WHERE NV.MADV = (
        SELECT MADV 
        FROM QLTDH.DONVI 
        WHERE TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER')
    );

-- Cấp quyền cho role TRGĐV
GRANT SELECT ON QLTDH.UNIT_HEAD_GET_FACULTY_TEACHING TO "TRGĐV";


-- Sinh viên có quyền xem các môn mở thuộc khoa mà sinh viên đang theo học
-- Tạo view cho phép sinh viên xem các môn mở thuộc khoa mà sinh viên đang theo học
CREATE OR REPLACE VIEW QLTDH.STUDENT_GET_DEPARTMENT_COURSES
AS
    SELECT 
        MM.MAMM, MM.MAHP, MM.MAGV, MM.HK, MM.NAM,
        HP.TENHP, HP.SOTC, HP.STLT, HP.STTH, HP.MADV,
        DV.TENDV, DV.LOAIDV,
        NV.HOTEN AS TENGV
    FROM QLTDH.MOMON MM
    JOIN QLTDH.HOCPHAN HP ON MM.MAHP = HP.MAHP
    JOIN QLTDH.DONVI DV ON HP.MADV = DV.MADV
    JOIN QLTDH.NHANVIEN NV ON MM.MAGV = NV.MANV
    WHERE HP.MADV = (
        SELECT KHOA
        FROM QLTDH.SINHVIEN
        WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER')
        AND TINHTRANG = 'Đang học'
    );

-- Cấp quyền cho role SV
GRANT SELECT ON QLTDH.STUDENT_GET_DEPARTMENT_COURSES TO "SV";