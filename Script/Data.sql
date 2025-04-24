-- Kiểm tra đã kết nối chưa
SELECT SYS_CONTEXT('USERENV', 'CON_NAME') FROM DUAL;
SELECT USER FROM DUAL;

-- Vô hiệu hóa các ràng buộc của bảng DANGKY
ALTER TABLE DANGKY DISABLE CONSTRAINT FK_DANGKY_MASV;
ALTER TABLE DANGKY DISABLE CONSTRAINT FK_DANGKY_MAMM;

-- Vô hiệu hóa các ràng buộc của bảng MOMON
ALTER TABLE MOMON DISABLE CONSTRAINT FK_MOMON_MAHP;
ALTER TABLE MOMON DISABLE CONSTRAINT FK_MOMON_MAGV;

-- Vô hiệu hóa các ràng buộc của bảng HOCPHAN
ALTER TABLE HOCPHAN DISABLE CONSTRAINT FK_HOCPHAN_MADV;

-- Vô hiệu hóa các ràng buộc của bảng SINHVIEN
ALTER TABLE SINHVIEN DISABLE CONSTRAINT FK_SINHVIEN_KHOA;

-- Vô hiệu hóa các ràng buộc của bảng NHANVIEN
ALTER TABLE NHANVIEN DISABLE CONSTRAINT FK_NHANVIEN_MADV;

-- Vô hiệu hóa các ràng buộc của bảng DONVI
ALTER TABLE DONVI DISABLE CONSTRAINT FK_DONVI_NHANVIEN;

-- Truncate các bảng theo thứ tự phù hợp
TRUNCATE TABLE DANGKY;
TRUNCATE TABLE MOMON;
TRUNCATE TABLE HOCPHAN;
TRUNCATE TABLE SINHVIEN;
TRUNCATE TABLE NHANVIEN;
TRUNCATE TABLE DONVI;

-- Bật lại các ràng buộc của bảng DONVI
ALTER TABLE DONVI ENABLE CONSTRAINT FK_DONVI_NHANVIEN;

-- Bật lại các ràng buộc của bảng NHANVIEN
ALTER TABLE NHANVIEN ENABLE CONSTRAINT FK_NHANVIEN_MADV;

-- Bật lại các ràng buộc của bảng SINHVIEN
ALTER TABLE SINHVIEN ENABLE CONSTRAINT FK_SINHVIEN_KHOA;

-- Bật lại các ràng buộc của bảng HOCPHAN
ALTER TABLE HOCPHAN ENABLE CONSTRAINT FK_HOCPHAN_MADV;

-- Bật lại các ràng buộc của bảng MOMON
ALTER TABLE MOMON ENABLE CONSTRAINT FK_MOMON_MAHP;
ALTER TABLE MOMON ENABLE CONSTRAINT FK_MOMON_MAGV;

-- Bật lại các ràng buộc của bảng DANGKY
ALTER TABLE DANGKY ENABLE CONSTRAINT FK_DANGKY_MASV;
ALTER TABLE DANGKY ENABLE CONSTRAINT FK_DANGKY_MAMM;

-- Nhập dữ liệu cho bảng DONVI
-- Khoa
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('CNT', 'Công nghệ thông tin', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('VLK', 'Vật lý - Vật lý kỹ thuật', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('DC', 'Địa chất', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('TTTH', 'Toán - Tin học', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('ETVT', 'Điện tử - Viễn thông', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('KHCN', 'Khoa học công nghệ và vật liệu', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('HH', 'Hóa học', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('SHCN', 'Sinh học - Công nghệ sinh học', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('MT', 'Môi trường', 'Khoa', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('KHLN', 'Khoa học liên ngành', 'Khoa', NULL);
-- Phòng
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('PĐT', 'Phòng Đào tạo', 'Phòng', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('PKT', 'Phòng Khảo thí', 'Phòng', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('PTTCHC', 'Phòng Tổ chức hành chính', 'Phòng', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('PCTSV', 'Phòng Công tác sinh viên', 'Phòng', NULL);
INSERT INTO DONVI (MADV, TENDV, LOAIDV, TRGDV) VALUES ('PKHCN', 'Phòng Khoa học công nghệ', 'Phòng', NULL);
-- Kiểm tra dữ liệu của DONVI
SELECT * FROM DONVI;

-- Nhân viên
-- Nhân viên cơ bản (NVCB)
BEGIN
    FOR i IN 1..500 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'NVCB' || LPAD(TO_CHAR(i), 4, '0'),
            'Nhân Viên Cơ Bản ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((30 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            4500000 + (i * 10000), -- Lương tăng dần
            500000, 
            '090' || LPAD(TO_CHAR(i), 7, '0'),
            'NVCB',
            CASE 
                WHEN MOD(i, 10) = 0 THEN 'CNT'
                WHEN MOD(i, 10) = 1 THEN 'VLK'
                WHEN MOD(i, 10) = 2 THEN 'DC'
                WHEN MOD(i, 10) = 3 THEN 'TTTH'
                WHEN MOD(i, 10) = 4 THEN 'ETVT'
                WHEN MOD(i, 10) = 5 THEN 'KHCN'
                WHEN MOD(i, 10) = 6 THEN 'HH'
                WHEN MOD(i, 10) = 7 THEN 'SHCN'
                WHEN MOD(i, 10) = 8 THEN 'MT'
                ELSE 'KHLN'
            END
        );
    END LOOP;
    COMMIT;
END;
/

-- Giảng viên (GV)
BEGIN
    FOR i IN 1..200 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'GV' || LPAD(TO_CHAR(i), 4, '0'),
            'Giảng Viên ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((40 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            6000000 + (i * 20000), -- Lương tăng dần
            800000, 
            '091' || LPAD(TO_CHAR(i), 7, '0'),
            'GV',
            CASE 
                WHEN MOD(i, 10) = 0 THEN 'CNT'
                WHEN MOD(i, 10) = 1 THEN 'VLK'
                WHEN MOD(i, 10) = 2 THEN 'DC'
                WHEN MOD(i, 10) = 3 THEN 'TTTH'
                WHEN MOD(i, 10) = 4 THEN 'ETVT'
                WHEN MOD(i, 10) = 5 THEN 'KHCN'
                WHEN MOD(i, 10) = 6 THEN 'HH'
                WHEN MOD(i, 10) = 7 THEN 'SHCN'
                WHEN MOD(i, 10) = 8 THEN 'MT'
                ELSE 'KHLN'
            END
        );
    END LOOP;
    COMMIT;
END;
/

-- Nhân viên Phòng Đào tạo (NV PĐT)
BEGIN
    FOR i IN 1..20 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'NVPDT' || LPAD(TO_CHAR(i), 4, '0'),
            'Nhân Viên Phòng Đào Tạo ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((35 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            5500000 + (i * 15000), -- Lương tăng dần
            600000, 
            '092' || LPAD(TO_CHAR(i), 7, '0'),
            'NV PĐT',
            'PĐT'
        );
    END LOOP;
    COMMIT;
END;
/

-- Nhân viên Phòng Khảo thí (NV PKT)
BEGIN
    FOR i IN 1..10 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'NVPKT' || LPAD(TO_CHAR(i), 4, '0'),
            'Nhân Viên Phòng Khảo Thí ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((35 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            5500000 + (i * 15000), -- Lương tăng dần
            600000, 
            '093' || LPAD(TO_CHAR(i), 7, '0'),
            'NV PKT',
            'PKT'
        );
    END LOOP;
    COMMIT;
END;
/

-- Nhân viên Phòng Tổ chức hành chính (NV TCHC)
BEGIN
    FOR i IN 1..15 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'NVTCHC' || LPAD(TO_CHAR(i), 4, '0'),
            'Nhân Viên Phòng Tổ Chức Hành Chính ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((35 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            5500000 + (i * 15000), -- Lương tăng dần
            600000, 
            '094' || LPAD(TO_CHAR(i), 7, '0'),
            'NV TCHC',
            'PTTCHC'
        );
    END LOOP;
    COMMIT;
END;
/

-- Nhân viên Phòng Công tác sinh viên (NV CTSV)
BEGIN
    FOR i IN 1..10 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'NVCTSV' || LPAD(TO_CHAR(i), 4, '0'),
            'Nhân Viên Phòng Công Tác Sinh Viên ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((35 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            5500000 + (i * 15000), -- Lương tăng dần
            600000, 
            '095' || LPAD(TO_CHAR(i), 7, '0'),
            'NV CTSV',
            'PCTSV'
        );
    END LOOP;
    COMMIT;
END;
/

-- Trưởng đơn vị (TRGĐV)
BEGIN
    FOR i IN 1..15 LOOP
        INSERT INTO NHANVIEN (MANV, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) 
        VALUES (
            'TRGDV' || LPAD(TO_CHAR(i), 4, '0'),
            'Trưởng Đơn Vị ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((40 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên
            7000000 + (i * 25000), -- Lương tăng dần
            1000000, 
            '096' || LPAD(TO_CHAR(i), 7, '0'),
            'TRGĐV',
            CASE 
                WHEN MOD(i, 15) = 1 THEN 'CNT'
                WHEN MOD(i, 15) = 2 THEN 'VLK'
                WHEN MOD(i, 15) = 3 THEN 'DC'
                WHEN MOD(i, 15) = 4 THEN 'TTTH'
                WHEN MOD(i, 15) = 5 THEN 'ETVT'
                WHEN MOD(i, 15) = 6 THEN 'KHCN'
                WHEN MOD(i, 15) = 7 THEN 'HH'
                WHEN MOD(i, 15) = 8 THEN 'SHCN'
                WHEN MOD(i, 15) = 9 THEN 'MT'
                WHEN MOD(i, 15) = 10 THEN 'KHLN'
                WHEN MOD(i, 15) = 11 THEN 'PĐT'
                WHEN MOD(i, 15) = 12 THEN 'PKT'
                WHEN MOD(i, 15) = 13 THEN 'PTTCHC'
                WHEN MOD(i, 15) = 0 THEN 'PKHCN'
                ELSE 'PCTSV'
            END
        );
    END LOOP;
    COMMIT;
END;
/

-- Cập nhật trưởng đơn vị cho bảng DONVI
UPDATE DONVI dv
SET TRGDV = (
    SELECT MANV 
    FROM NHANVIEN nv
    WHERE nv.VAITRO = 'TRGĐV' 
    AND nv.MADV = dv.MADV
);
COMMIT;
SELECT * FROM NHANVIEN;

-- Sinh viên
BEGIN
    FOR i IN 1..4000 LOOP
        INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, KHOA, TINHTRANG) 
        VALUES (
            'SV' || LPAD(TO_CHAR(i), 4, '0'),
            'Sinh Viên ' || i, 
            CASE WHEN MOD(i, 2) = 0 THEN 'Nam' ELSE 'Nữ' END,
            ADD_MONTHS(SYSDATE, -((20 + i) * 12)), -- Tạo ngày sinh ngẫu nhiên cho sinh viên
            'Địa Chỉ Sinh Viên ' || i, 
            '097' || LPAD(TO_CHAR(i), 7, '0'),
            CASE 
                WHEN MOD(i, 10) = 0 THEN 'CNT'
                WHEN MOD(i, 10) = 1 THEN 'VLK'
                WHEN MOD(i, 10) = 2 THEN 'DC'
                WHEN MOD(i, 10) = 3 THEN 'TTTH'
                WHEN MOD(i, 10) = 4 THEN 'ETVT'
                WHEN MOD(i, 10) = 5 THEN 'KHCN'
                WHEN MOD(i, 10) = 6 THEN 'HH'
                WHEN MOD(i, 10) = 7 THEN 'SHCN'
                WHEN MOD(i, 10) = 8 THEN 'MT'
                ELSE 'KHLN'
            END,
            CASE 
                WHEN MOD(i, 3) = 0 THEN 'Đang học'
                WHEN MOD(i, 3) = 1 THEN 'Nghỉ học'
                ELSE 'Bảo lưu'
            END
        );
    END LOOP;
    COMMIT;
END;
/
SELECT * FROM SINHVIEN;

-- Học phần
BEGIN
   FOR i IN 1..50 LOOP
       FOR donvi_rec IN (SELECT MADV, TENDV FROM DONVI WHERE LOAIDV = 'Khoa') LOOP
           INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, MADV) 
           VALUES (
               donvi_rec.MADV || LPAD(TO_CHAR(i), 4, '0'),
               donvi_rec.TENDV || ' ' || i,
               CASE 
                   WHEN MOD(i, 2) = 0 THEN 4
                   ELSE 4
               END,
               CASE 
                   WHEN MOD(i, 2) = 0 THEN 3
                   ELSE 4
               END,
               CASE 
                   WHEN MOD(i, 2) = 0 THEN 1
                   ELSE 0
               END,
               donvi_rec.MADV
           );
       END LOOP;
   END LOOP;
   COMMIT;
END;
/
SELECT * FROM HOCPHAN ORDER BY MADV, MAHP;

-- Mở môn
DECLARE
   v_mamm_counter NUMBER := 1;
BEGIN
   -- Năm 2024 có 3 học kỳ
   FOR nam IN 2024..2025 LOOP
       FOR hk IN 1..(CASE WHEN nam = 2024 THEN 3 ELSE 2 END) LOOP
           FOR hp_rec IN (
               SELECT MAHP, MADV 
               FROM HOCPHAN
           ) LOOP
               -- Chọn giảng viên thuộc cùng khoa với học phần
               INSERT INTO MOMON (MAMM, MAHP, MAGV, HK, NAM) 
               VALUES (
                   'MM' || LPAD(TO_CHAR(v_mamm_counter), 4, '0'),
                   hp_rec.MAHP,
                   (
                       SELECT MANV 
                       FROM NHANVIEN 
                       WHERE VAITRO = 'GV' 
                         AND MADV = hp_rec.MADV
                         AND ROWNUM = 1
                   ),
                   TO_CHAR(hk),
                   nam
               );
               
               v_mamm_counter := v_mamm_counter + 1;
           END LOOP;
       END LOOP;
   END LOOP;
   COMMIT;
END;
/
SELECT * FROM MOMON;

-- Đăng ký
DECLARE
   v_random_counter NUMBER := 0;
BEGIN
   FOR mm_rec IN (
       SELECT MAMM, MAHP 
       FROM MOMON
   ) LOOP
       FOR sv_rec IN (
           SELECT MASV, KHOA 
           FROM SINHVIEN 
           WHERE KHOA = (
               SELECT MADV 
               FROM HOCPHAN 
               WHERE MAHP = mm_rec.MAHP
           )
       ) LOOP
           v_random_counter := v_random_counter + 1;
           
           -- Sinh điểm ngẫu nhiên
           DECLARE
               v_diemth NUMBER(5,2) := ROUND(DBMS_RANDOM.VALUE(0, 10), 2);
               v_diemqt NUMBER(5,2) := ROUND(DBMS_RANDOM.VALUE(0, 10), 2);
               v_diemck NUMBER(5,2) := ROUND(DBMS_RANDOM.VALUE(0, 10), 2);
               v_diemtk NUMBER(5,2);
           BEGIN
               -- Tính điểm tổng kết theo công thức
               v_diemtk := ROUND(
                   (v_diemth * 0.3) + 
                   (v_diemqt * 0.2) + 
                   (v_diemck * 0.5), 
               2);
               
               -- Chỉ insert những sinh viên có khoa phù hợp
               INSERT INTO DANGKY (
                   MASV, MAMM, 
                   DIEMTH, DIEMQT, DIEMCK, DIEMTK
               ) VALUES (
                   sv_rec.MASV, 
                   mm_rec.MAMM,
                   v_diemth, 
                   v_diemqt, 
                   v_diemck, 
                   v_diemtk
               );
               
               -- Giới hạn số lượng đăng ký để không quá nhiều
               EXIT WHEN v_random_counter > 1000;
           END;
       END LOOP;
   END LOOP;
   COMMIT;
END;
/

-- Update điểm thành NULL cho các môn học kỳ 2 năm 2025
UPDATE DANGKY dk
SET 
   DIEMTH = NULL,
   DIEMQT = NULL,
   DIEMCK = NULL,
   DIEMTK = NULL
WHERE dk.MAMM IN (
   SELECT MAMM 
   FROM MOMON 
   WHERE NAM = 2025 AND HK = '2'
);
COMMIT;
SELECT * FROM DANGKY;




