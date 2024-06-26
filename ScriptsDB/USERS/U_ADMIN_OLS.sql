-- ===== CHAY DUOI QUYEN U_ADMIN =====
SELECT * FROM DBA_ROLE_PRIVS;
SHOW USER;
/
SELECT * FROM U_ADMIN.NHANSU;
SELECT * FROM KHMO;
SELECT * FROM SINHVIEN;
SELECT * FROM PHANCONG;
/
--B3: BẮT ĐẦU TẠO CHÍNH SÁCH OLS (CONNECT VÀO TÀI KHOẢN U_ADMIN)
-- TẠO CHÍNH SÁCH OLS (KHỞI ĐỘNG LẠI SQLDEV ĐỂ CẬP NHẬT OLS ENABLE)
BEGIN
SA_SYSDBA.CREATE_POLICY(
    policy_name => 'THONGBAO_OLS',
    column_name => 'row_label'
);
END;
/
--ENABLE POLICY VỪA TẠO -> KHOI DONG LẠI SQLDEV
EXEC SA_SYSDBA.ENABLE_POLICY ('THONGBAO_OLS');
/
SHUTDOWN IMMEDIATE;
STARTUP;
/
--TẠO COMPONENT CỦA LABEL
--->TẠO LEVEL
BEGIN
SA_COMPONENTS.CREATE_LEVEL(
    POLICY_NAME => 'THONGBAO_OLS',
    LONG_NAME => 'Truong khoa',
    SHORT_NAME => 'TK',
    LEVEL_NUM => 600);

SA_COMPONENTS.CREATE_LEVEL(
    POLICY_NAME => 'THONGBAO_OLS',
    LONG_NAME => 'Truong don vi',
    SHORT_NAME => 'TDV',
    LEVEL_NUM => 500);

SA_COMPONENTS.CREATE_LEVEL(
    POLICY_NAME => 'THONGBAO_OLS',
    LONG_NAME => 'Giang vien',
    SHORT_NAME => 'GV',
    LEVEL_NUM => 400);
    
SA_COMPONENTS.CREATE_LEVEL(
    POLICY_NAME => 'THONGBAO_OLS',
    LONG_NAME => 'Giao vu',
    SHORT_NAME => 'GVU',
    LEVEL_NUM => 300);

SA_COMPONENTS.CREATE_LEVEL(
    POLICY_NAME => 'THONGBAO_OLS',
    LONG_NAME => 'Nhan vien',
    SHORT_NAME => 'NV',
    LEVEL_NUM => 200);

SA_COMPONENTS.CREATE_LEVEL(
    POLICY_NAME => 'THONGBAO_OLS',
    LONG_NAME => 'Sinh vien',
    SHORT_NAME => 'SV',
    LEVEL_NUM => 100);
END;
--->TẠO COMPARTMENT: HTTT, CNPM, KHMT, CNTT, TGMT, MMT
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_OLS',1000,'HTTT','He thong thong tin');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_OLS',1200,'CNPM','Cong nghe phan mem');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_OLS',1400,'KHMT','Khoa hoc may tinh');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_OLS',1600,'CNTT','Cong nghe thong tin');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_OLS',1800,'TGMT','Thi giac may tinh');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('THONGBAO_OLS',2000,'MMT','Mang may tinh');
--->TẠO GROUP
EXECUTE SA_COMPONENTS.CREATE_GROUP('THONGBAO_OLS',20,'CS1','Co so 1');
EXECUTE SA_COMPONENTS.CREATE_GROUP('THONGBAO_OLS',40,'CS2','Co so 2');
-- XOÁ BẢNG
DROP TABLE THONGBAO PURGE;
--B5: TẠO BẢNG DỮ LIỆU TEST
CREATE TABLE THONGBAO(
    NOIDUNG VARCHAR2(255),
    NGAYGIO DATE,
    DIADIEM VARCHAR2(255),
    CAPBACTHAMGIA NUMBER, -- 1.Trưởng khoa, 2.Trưởng don vi, 3.Giảng viên, 4.Giáo vụ, 5.Nhân viên, 6.Sinh viên
    LINHVUC NUMBER, -- 1.HTTT, 2.CNPM, 3.KHMT, 4.CNTT, 5.TGMT, 6.MMT
    COSO NUMBER -- 1.Cơ sở 1, 2.Cơ sở 2
);
-- Them du lieu vao bang THONGBAO
-- Chèn thông báo minh họa
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao cuoc hop quan trong ve ke hoach giang day lop He thong thong tin', TO_DATE('2023/12/16', 'yyyy/mm/dd '), 'Quan 5', 1, 1, 1);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve lich nghi le tet', TO_DATE('2024/02/05', 'yyyy/mm/dd '), 'Thu Duc', 4, 0, 2);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve viec nop bai tap lon', TO_DATE('2023/10/06', 'yyyy/mm/dd '), 'Quan 5', 3, 0, 1);
-- Chèn thông báo cho giáo vụ
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve lich hoc moi cua hoc ky sau', TO_DATE('2023/12/16', 'yyyy/mm/dd '), 'Quan 5', 6, 0, 1);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve ke hoach to chuc thi cuoi ky cho lop Thi giac may tinh', TO_DATE('2024/02/21', 'yyyy/mm/dd '), 'Quan 5', 6, 5, 1);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve viec phan cong do an cuoi khoa', TO_DATE('2024/01/31', 'yyyy/mm/dd '), 'Thu Duc', 6, 0, 2);
-- Chèn thông báo cho trưởng don vi
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve lich hoc moi cua phong A', TO_DATE('2024/03/26', 'yyyy/mm/dd '), 'Thu Duc', 2, 0, 2);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve ke hoach to chuc hoi thao', TO_DATE('2024/05/11', 'yyyy/mm/dd '), 'Thu Duc', 2, 0, 2);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve viec to chuc sinh nhat cua don vi', TO_DATE('2024/01/31', 'yyyy/mm/dd '), 'Quan 5', 2, 0, 1);
-- Chèn thông báo cho sinh viên HTTT
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve lich hoc moi cua hoc ky sau cua lop He thong thong tin', TO_DATE('2023/12/16', 'yyyy/mm/dd'), 'Quan 5', 6, 1, 1);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao ve ke hoach to chuc thi cuoi ky cho lop He thong thong tin', TO_DATE('2024/02/21', 'yyyy/mm/dd'), 'Quan 5', 6, 1, 1);
INSERT INTO THONGBAO (NOIDUNG, NGAYGIO, DIADIEM, CAPBACTHAMGIA, LINHVUC, COSO)
VALUES ('Thong bao bao ve luan van tot nghiep', TO_DATE('2024/01/31', 'yyyy/mm/dd'), 'Thu Duc', 6, 0, 2);
/
SELECT * FROM THONGBAO;
--B7: CẬP NHẬT NHÃN TRONG BẢNG
SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    POLICY_NAME => 'THONGBAO_OLS',
    SCHEMA_NAME => 'U_ADMIN',
    TABLE_NAME => 'THONGBAO',
    TABLE_OPTIONS => 'NO_CONTROL');
END;
/
--B6: TẠO NHÃN
----TẠO THỦ CÔNG BẰNG LỆNH
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2330,'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2450,'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2560,'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2230,'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',1250,'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2210,'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1');

EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2000,'GVU:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2001,'SV');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2002,'SV:HTTT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2003,'TDV:KHMT:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2004,'TDV:KHMT:CS1,CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2005,'SV::CS1,CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2006,'SV:CNPM:CS1');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2007,'SV:TGMT');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2008,'GVU::CS1,CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2009,'NV:KHMT:CS1,CS2');
EXECUTE SA_LABEL_ADMIN.CREATE_LABEL('THONGBAO_OLS',2010,'SV:HTTT:CS1,CS2');
--B8: UPDATE ĐỂ KHỞI TẠO LABEL TRONG BẢNG THONGBAO (OPTION=NO_CONTROL)
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'GVU:HTTT:CS1')
WHERE CAPBACTHAMGIA <= 4 AND LINHVUC = 1 AND COSO = 1;
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'SV')
WHERE CAPBACTHAMGIA = 6 AND LINHVUC = 0;
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'SV::CS1,CS2')
WHERE CAPBACTHAMGIA = 4 AND LINHVUC = 0;
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'SV::CS1')
WHERE CAPBACTHAMGIA = 3 AND LINHVUC = 0 AND COSO = 1;
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'SV:TGMT')
WHERE CAPBACTHAMGIA = 6 AND LINHVUC = 5 AND COSO = 1;
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'NV:KHMT:CS1,CS2')
WHERE CAPBACTHAMGIA = 2 AND LINHVUC = 0 AND COSO = 2;
UPDATE THONGBAO 
SET ROW_LABEL = CHAR_TO_LABEL('THONGBAO_OLS', 'NV:KHMT:CS1,CS2')
WHERE CAPBACTHAMGIA = 6 AND LINHVUC = 1 AND COSO = 1;
--B9: ÁP DỤNG OLS VÀO BẢNG
BEGIN
SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('THONGBAO_OLS','U_ADMIN','THONGBAO');
SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    POLICY_NAME  => 'THONGBAO_OLS',
    SCHEMA_NAME  => 'U_ADMIN',
    TABLE_NAME  => 'THONGBAO',
    TABLE_OPTIONS  => 'READ_CONTROL',
    PREDICATE => NULL);
END;
--B10: TẠO USER ĐỂ TEST (CONNECT VÀO SYS)
--B12: CẤP QUYỀN CONNECT CHO CÁC TÀI KHOẢN TEST (CONNECT VÀO SYS)
-- ===== CHAY DUOI QUYEN U_ADMIN =====
--B13: GÁN LABEL CHO USER
BEGIN
SA_USER_ADMIN.SET_USER_LABELS ('THONGBAO_OLS','TK_1','TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); --a. Trưởng khoa có thể đọc được toàn bộ thông báo.
SA_USER_ADMIN.SET_USER_LABELS ('THONGBAO_OLS','TDV_2','TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS2'); --b. Trưởng bộ môn phụ trách Cơ sở 2 có thể đọc được toàn bộ thông báo dành cho trưởng bộ môn không phân biệt vị trí địa lý.
SA_USER_ADMIN.SET_USER_LABELS ('THONGBAO_OLS','GVU_88','GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); --c.  Giáo vụ có thể đọc toàn bộ thông báo dành cho giáo vụ 
SA_USER_ADMIN.SET_USER_LABELS ('THONGBAO_OLS','SV_1','SV:HTTT:CS1'); --e. Sinh viên thuộc ngành HTTT học ở Cơ sở 1.
SA_USER_ADMIN.SET_USER_LABELS ('THONGBAO_OLS','TDV_3','TDV:KHMT:CS1');  --f. Trưởng bộ môn KHMT ở Cơ sở 1.
SA_USER_ADMIN.SET_USER_LABELS ('THONGBAO_OLS','TDV_3','TDV:KHMT:CS1,CS2');  --g. Trưởng bộ môn KHMT ở Cơ sở 1, Cơ sở 2.
END;
/
SELECT * FROM ALL_SA_LABELS;
--B14:CONNECT VÀO USER TEST ĐỂ TEST THỬ (UER: SV_1)
--CONNECT SV_1/SV_1;
--SELECT * FROM U_ADMIN.THONGBAO;
--SHOW USER;