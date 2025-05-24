--Cấu hình và kích hoạt OLS
ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;
EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;

-------------------------------------------------------------------------------------

--UNLOCK LBACSYS(OLS ADMIN)
ALTER SESSION SET CONTAINER = CDB$ROOT;
ALTER USER LBACSYS IDENTIFIED BY LBACSYS ACCOUNT UNLOCK CONTAINER=ALL;
GRANT SELECT ANY DICTIONARY TO LBACSYS;

-------------------------------------------------------------------------------------

--cấp quyền cho QLTDH
ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO QLTDH WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.SA_LABEL_ADMIN TO QLTDH WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.SA_USER_ADMIN TO QLTDH WITH GRANT OPTION;
GRANT EXECUTE ON SA_POLICY_ADMIN TO QLTDH WITH GRANT OPTION;
GRANT EXECUTE ON CHAR_TO_LABEL TO QLTDH WITH GRANT OPTION;

GRANT LBAC_DBA TO QLTDH;
GRANT EXECUTE ON SA_SYSDBA TO QLTDH WITH GRANT OPTION;
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO QLTDH;

GRANT INHERIT PRIVILEGES ON USER QLTDH TO LBACSYS WITH GRANT OPTION;
GRANT INHERIT PRIVILEGES ON USER SYS TO LBACSYS WITH GRANT OPTION;
GRANT INHERIT PRIVILEGES ON USER LBACSYS TO QLTDH WITH GRANT OPTION;

-------------------------------------------------------------------------------------

--tạo bảng thông báo
CREATE TABLE QLTDH.THONGBAO (
  MATB        NUMBER PRIMARY KEY,
  TIEUDE     VARCHAR2(100),
  NOIDUNG    CLOB,
  THOIGIAN TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  DIADIEM    NVARCHAR2(50),
  OLS_LABEL  NUMBER   -- Cột nhãn bảo mật (OLS)
);
--cấp quyền
GRANT ALL ON QLTDH.THONGBAO TO LBACSYS;
GRANT ALL ON QLTDH.THONGBAO TO QLTDH;

-------------------------------------------------------------------------------------

--Tạo ols policy
ALTER SESSION SET CONTAINER = QUANLYTRUONGDAIHOC;

-- Xoá chính sách nếu đã tồn tại
-- BEGIN
--     SA_SYSDBA.DROP_POLICY('THONGBAO_POLICY');
-- END;
-- /

BEGIN
    SA_SYSDBA.CREATE_POLICY(
        policy_name => 'THONGBAO_POLICY',
        column_name => 'OLS_LABEL'
    );
END;
/

--Tạo level (độ nhạy cảm)
BEGIN
  SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY', 100, 'THAP',   'Thông báo thường');
  SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY', 200, 'TRUNG',  'Thông báo nội bộ');
  SA_COMPONENTS.CREATE_LEVEL('THONGBAO_POLICY', 300,'CAO',    'Thông báo mật');
END;
/

--Tạo compartment
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 10, 'TOAN',   'Khoa Toán');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 20, 'LY',     'Khoa Lý');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 30, 'HOA',    'Khoa Hóa');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 40, 'TCHC',   'Phòng Hành chính');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 50, 'PKT',    'Phòng Khảo thí');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 60, 'PDT',    'Phòng Đào tạo');
  SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_POLICY', 70, 'CTSV',   'Phòng CTSV');
END;
/

--Tạo group
BEGIN
  SA_COMPONENTS.CREATE_GROUP('THONGBAO_POLICY', 1, 'CS1', 'Cơ sở 1');
  SA_COMPONENTS.CREATE_GROUP('THONGBAO_POLICY', 2, 'CS2', 'Cơ sở 2');
END;
/

-------------------------------------------------------------------------------------

-- Tạo nhãn dữ liệu
BEGIN
  -- t1: Tất cả Trưởng đơn vị
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 300,
    label_value => 'CAO::',
    data_label  => TRUE
  );

  -- t2: Tất cả Nhân viên
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 200,
    label_value => 'TRUNG::',
    data_label  => TRUE
  );
  -- t3: Tất cả Sinh viên (thay thế t7)
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 100,
    label_value => 'THAP::',
    data_label  => TRUE
  );

  -- t4: Sinh viên khoa Hóa CS1
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 1,
    label_value => 'THAP:HOA:CS1',
    data_label  => TRUE
  );

  -- t5: Sinh viên khoa Hóa CS2
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 105,
    label_value => 'THAP:HOA:CS2',
    data_label  => TRUE
  );

  -- t6: Sinh viên khoa Hóa cả hai cơ sở
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 106,
    label_value => 'THAP:HOA:',
    data_label  => TRUE
  );

  -- t8: Trưởng khoa Hóa CS1
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 108,
    label_value => 'CAO:HOA:CS1',
    data_label  => TRUE
  );

  -- t9: Trưởng khoa Hóa cả hai cơ sở
  SA_LABEL_ADMIN.CREATE_LABEL(
    policy_name => 'THONGBAO_POLICY',
    label_tag   => 109,
    label_value => 'CAO:HOA:',
    data_label  => TRUE
  );
END;
/

-------------------------------------------------------------------------------------

--Gán nhãn cho người dùng
BEGIN
  -- u1: Trưởng đơn vị – đọc tất cả thông báo
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U1', 'CAO:TOAN,LY,HOA,TCHC,PKT,PDT,CTSV:CS1,CS2');

  -- u2: Trưởng khoa Hóa tại CS2
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U2', 'CAO:HOA:CS2');

  -- u3: Trưởng khoa Lý tại CS2
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U3', 'CAO:LY:CS2');

  -- u4: Nhân viên khoa Hóa tại CS2
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U4', 'TRUNG:HOA:CS2');

  -- u5: Sinh viên khoa Hóa tại CS2
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U5', 'THAP:HOA:CS2');

  -- u6: Trưởng đơn vị Hành chính
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U6', 'CAO:TCHC:CS1,CS2');

  -- u7: Nhân viên – đọc tất cả thông báo cho Nhân viên
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U7', 'TRUNG:TOAN,LY,HOA,TCHC,PKT,PDT,CTSV:CS1,CS2');

  -- u8: Nhân viên Hành chính tại CS1
  SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U8', 'TRUNG:TCHC:CS1');
END;
/

-------------------------------------------------------------------------------------

--Gán chính sách vào bảng thông báo
BEGIN
  SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    policy_name    => 'THONGBAO_POLICY',
    schema_name    => 'QLTDH',
    table_name     => 'THONGBAO',
    table_options  => 'READ_CONTROL',
    predicate => NULL
  );
END;
/

-- BEGIN
--   SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
--     policy_name    => 'THONGBAO_POLICY',
--     schema_name    => 'QLTDH',
--     table_name     => 'THONGBAO',
--     table_options  => 'NO_CONTROL'
--   );
-- END;
-- /


-- -- Xoá chính sách
-- BEGIN
--   SA_POLICY_ADMIN.REMOVE_TABLE_POLICY (
--     policy_name    => 'THONGBAO_POLICY',
--     schema_name    => 'QLTDH',
--     table_name     => 'THONGBAO'
--   );
-- END;
-- /

-------------------------------------------------------------------------------------

delete from qltdh.thongbao;
--Kiểm tra
-- Chèn dữ liệu mẫu có gán nhãn OLS
BEGIN
    INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
      1, 'Họp trưởng đơn vị', 'Họp tổng kết năm học', 'Phòng A1', 101
    );
    INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
      2, 'Lịch học Hóa CS2', 'Lịch thực hành bổ sung', 'CS2 - P.202', 105
    );
    
    INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
      3, 'Xét lương mới', 'Quy trình xét lương', 'Văn phòng', 102
    );
    
    INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
      4, 'Xét lương mới', 'Quy trình xét lương', 'Văn phòng', 106
    );
    COMMIT;
END;
/
select * from qltdh.thongbao;

-- --Xem danh sách label
-- SELECT
--   LABEL_TAG,
--   LABEL,
--   POLICY_NAME
-- FROM
--   ALL_SA_LABELS
-- WHERE
--   POLICY_NAME = 'THONGBAO_POLICY';

-- BEGIN
--   SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY','U5','THAP:HOA:CS1,CS2');
-- END;
-- /


-- CREATE USER U1 IDENTIFIED BY 123;
-- GRANT CONNECT TO U1;
-- GRANT SELECT ON QLTDH.THONGBAO TO U1;

-- CREATE USER U7 IDENTIFIED BY 123;
-- GRANT CONNECT TO U7;
-- GRANT SELECT ON QLTDH.THONGBAO TO U7;

-- CREATE USER U5 IDENTIFIED BY 123;
-- GRANT CONNECT TO U5;
-- GRANT SELECT ON QLTDH.THONGBAO TO U5;


-- BEGIN
--   SA_LABEL_ADMIN.CREATE_LABEL(
--     policy_name => 'THONGBAO_POLICY',
--     label_tag   => 103,
--     label_value => 'TRUNG::',
--     data_label  => TRUE
--   );
  
--   SA_LABEL_ADMIN.CREATE_LABEL(
--     policy_name => 'THONGBAO_POLICY',
--     label_tag   => 101,
--     label_value => 'THAP:HOA:CS2',
--     data_label  => TRUE
--   );
  
--   SA_LABEL_ADMIN.CREATE_LABEL(
--     policy_name => 'THONGBAO_POLICY',
--     label_tag   => 102,
--     label_value => 'THAP:HOA:',
--     data_label  => TRUE
--   );
-- END;
-- /

-- -- Cấu hình user U1
-- BEGIN
--   SA_USER_ADMIN.SET_USER_LABELS('THONGBAO_POLICY', 'U1', 'CAO:TOAN,LY,HOA,TCHC,PKT,PDT,CTSV:CS1,CS2');
-- END;
-- /

-- BEGIN
--   SA_USER_ADMIN.SET_USER_PRIVS(
--     policy_name => 'THONGBAO_POLICY',
--     user_name   => 'U1',
--     privileges  => 'READ'
--   );
-- END;
-- /


-- BEGIN
--   SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
--     policy_name    => 'THONGBAO_POLICY',
--     schema_name    => 'QLTDH',
--     table_name     => 'THONGBAO',
--     table_options  => 'READ_CONTROL',
--     predicate => NULL
--   );
-- END;
-- /

-- BEGIN
--     SA_SYSDBA.ENABLE_POLICY('THONGBAO_POLICY');
-- END;
-- /
-- SELECT policy_name, status FROM dba_sa_policies WHERE policy_name = 'THONGBAO_POLICY';

-- -- Xóa dữ liệu cũ và insert mới
-- DELETE FROM qltdh.thongbao;

-- BEGIN
--     INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
--       1, 'Họp trưởng đơn vị', 'Họp tổng kết năm học', 'Phòng A1', 101
--     );
--     INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
--       2, 'Thông báo khoa Hóa CS2', 'Họp khoa Hóa cơ sở 2', 'Phòng B1', 102
--     );
--     INSERT INTO QLTDH.THONGBAO (MATB, TIEUDE, NOIDUNG, DIADIEM, OLS_LABEL) VALUES (
--       3, 'Thông báo khoa Hóa', 'Họp tất cả khoa Hóa', 'Phòng C1', 103
--     );
--     COMMIT;
-- END;
-- /
