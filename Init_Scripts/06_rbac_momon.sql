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


-- Cấp quyền cho role NV PĐT
GRANT SELECT ON QLTDH.EDUCATION_DEPARTMENT_GET_COURSE_OFFERING TO "NV PĐT";


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