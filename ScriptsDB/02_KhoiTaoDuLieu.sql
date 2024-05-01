-- Chạy với user U_ADMIN
-----------------------------------------
DELETE FROM DONVI;
ALTER TABLE DONVI MODIFY (MADV GENERATED ALWAYS AS IDENTITY (START WITH 0));
INSERT INTO DONVI (TENDV) VALUES ('Van phong khoa');
INSERT INTO DONVI (TENDV) VALUES ('Bo mon HTTT');
INSERT INTO DONVI (TENDV) VALUES ('Bo mon CNPM');
INSERT INTO DONVI (TENDV) VALUES ('Bo mon KHMT');
INSERT INTO DONVI (TENDV) VALUES ('Bo mon CNTT');
INSERT INTO DONVI (TENDV) VALUES ('Bo mon TGMT');
INSERT INTO DONVI (TENDV) VALUES ('Bo mon MMT va Vien thong');
/
UPDATE DONVI SET TENDV = 'Van phong khoa' WHERE TENDV = 'Văn phòng khoa';
UPDATE DONVI SET TENDV = 'Bo mon HTTT' WHERE TENDV = 'Bộ môn HTTT';
UPDATE DONVI SET TENDV = 'Bo mon CNPM' WHERE TENDV = 'Bộ môn CNPM';
UPDATE DONVI SET TENDV = 'Bo mon KHMT' WHERE TENDV = 'Bộ môn KHMT';
UPDATE DONVI SET TENDV = 'Bo mon CNTT' WHERE TENDV = 'Bộ môn CNTT';
UPDATE DONVI SET TENDV = 'Bo mon TGMT' WHERE TENDV = 'Bộ môn TGMT';
UPDATE DONVI SET TENDV = 'Bo mon MMT va Vien thong' WHERE TENDV = 'Bộ môn MMT và Viễn thông';
/
SELECT * FROM DONVI;
/
DELETE FROM NHANSU;
ALTER TABLE NHANSU MODIFY (MANV GENERATED ALWAYS AS IDENTITY (START WITH 1));
/
INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Nguyen Van A', 'Nam', TO_DATE('1990-01-01', 'YYYY-MM-DD'), 5000000, 123456789, 'TRUONG KHOA', 1, 'TK_1');

INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Tran Thi B', 'Nu', TO_DATE('1990-01-02', 'YYYY-MM-DD'),30000000 , 0123456668, 'TRUONG DON VI', 2, 'TDV_2');

INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Pham Van C', 'Nu', TO_DATE('1990-01-03', 'YYYY-MM-DD'), 20000000 , 0933384111, 'TRUONG DON VI', 3, 'TDV_3');

INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Le Thi D', 'Nu', TO_DATE('1990-01-04', 'YYYY-MM-DD'), 25000000 , 0933384112, 'TRUONG DON VI', 4, 'TDV_4');

INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Phan Van E', 'Nu', TO_DATE('1990-01-03', 'YYYY-MM-DD'), 20000000 , 0933384113, 'TRUONG DON VI', 5, 'TDV_5');

INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Huynh Van F', 'Nam', TO_DATE('1990-01-03', 'YYYY-MM-DD'), 21000000 , 0933384114, 'TRUONG DON VI', 6, 'TDV_6');

INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) 
VALUES ('Tran Quoc E', 'Nam', TO_DATE('1990-01-03', 'YYYY-MM-DD'), 22000000 , 0933384115, 'TRUONG DON VI', 7, 'TDV_7');
/
UPDATE NHANSU
SET vaitro = 
    CASE 
        WHEN vaitro = 'TRƯỞNG KHOA' THEN 'TRUONG KHOA'
        WHEN vaitro = 'NHÂN VIÊN CƠ BẢN' THEN 'NHAN VIEN CO BAN'
        WHEN vaitro = 'TRƯỞNG ĐƠN VỊ' THEN 'TRUONG DON VI'
        WHEN vaitro = 'GIẢNG VIÊN' THEN 'GIANG VIEN'
        WHEN vaitro = 'GIÁO VỤ' THEN 'GIAO VU'
        ELSE vaitro
    END;

SELECT * FROM SINHVIEN;
select * from DONVI;
delete from sinhvien;
ALTER TABLE sinhvien MODIFY (MASV GENERATED ALWAYS AS IDENTITY (START WITH 1));
SET SERVEROUT ON
/
DECLARE
    v_names VARCHAR2(255) := 'Nguyen,Tran,Le,Pham,Hoang,Phan,Vu,Vo,Dang,Bui';
    v_first_names VARCHAR2(255) := 'Anh,Bao,Chau,Dat,Diem,Đức,Giang,Hoa,Hung,Khanh,Linh,Long,Ly,Minh,My,Nam,Ngoc,Nga,Nguyen,Nguyet,Phong,Phuc,Phuong,Quan,Quoc,Sang,Tam,Tan,Thanh,Thao,Thien,Thi,Thuan,Tien,Tu,Tuan,Tuyen,Vi,Vinh,Yen';
    v_random_num NUMBER;
    v_phone_number VARCHAR2(20);
    streets VARCHAR2(255) := 'CMT8,TRAN PHU,VO VAN TAN,PHAM VAN DONG,HOA MAI,HOA PHUONG,DUONG BA TRAC,LU GIA,LY THUONG KIET,TRAN HUNG DAO,NGUYEN VAN CU';
    v_address VARCHAR2(255);
    v_dob DATE;
    v_gender VARCHAR2(10);
    v_last_name VARCHAR2(255);
    v_first_name VARCHAR2(255);
    v_ct VARCHAR2(255) := '0,CQ,CLC,CTTT,VP,1';
    v_mact VARCHAR2(50);
    v_sotctl NUMBER(3);
    v_dtbtl NUMBER(3,2);
BEGIN
    FOR i IN 1..30 LOOP
        -- Chọn ngẫu nhiên một họ và tên đệm
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 10)); -- Số ngẫu nhiên từ 1 đến 10
        v_last_name := SUBSTR(v_names, INSTR(v_names, ',', 1, v_random_num) + 1, INSTR(v_names, ',', 1, v_random_num + 1) - INSTR(v_names, ',', 1, v_random_num) - 1);
        
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 40)); -- Số ngẫu nhiên từ 1 đến 40
        v_first_name := SUBSTR(v_first_names, INSTR(v_first_names, ',', 1, v_random_num) + 1, INSTR(v_first_names, ',', 1, v_random_num + 1) - INSTR(v_first_names, ',', 1, v_random_num) - 1);
        
        -- Tạo số điện thoại ngẫu nhiên
        v_phone_number := '0' || TRUNC(DBMS_RANDOM.VALUE(100000000, 999999999));
        
        -- Tạo ngày sinh ngẫu nhiên
       
        v_dob := ADD_MONTHS(TO_DATE('1967-01-01', 'YYYY-MM-DD'), 12 * TRUNC(DBMS_RANDOM.VALUE(11, 25))); -- Trừ đi số tháng ngẫu nhiên từ 11 đến 25
        v_dob := v_dob + TRUNC(DBMS_RANDOM.VALUE(11, 365));
        
        -- Tạo giới tính ngẫu nhiên 
        v_gender := CASE WHEN DBMS_RANDOM.VALUE() < 0.5 THEN 'Nam' ELSE 'Nu' END;
        
        -- Tạo địa chỉ ngẫu nhiên         
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 11)); -- Số ngẫu nhiên từ 1 đến 10
        v_address := SUBSTR(streets, INSTR(streets, ',', 1, v_random_num) + 1, INSTR(streets, ',', 1, v_random_num + 1) - INSTR(streets, ',', 1, v_random_num) - 1);
        
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 1000));
        v_address := 'So ' || v_random_num || ' ' || v_address;
        
        -- Tạo chương trình ngẫu nhiên 
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 5)); -- Số ngẫu nhiên từ 1 đến 4
        v_mact := SUBSTR(v_ct, INSTR(v_ct, ',', 1, v_random_num) + 1, INSTR(v_ct, ',', 1, v_random_num + 1) - INSTR(v_ct, ',', 1, v_random_num) - 1);
        
        -- Tạo số tín chỉ tích lũy ngẫu nhiên 
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 180));
        v_sotctl := v_random_num;
        
        -- Tạo điểm trung bình tích lũy ngẫu nhiên 
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(500, 1000));
        v_dtbtl := v_random_num / 100;
        
        -- Chèn dữ liệu vào bảng SINHVIEN

        DBMS_OUTPUT.PUT_LINE('INSERT INTO SINHVIEN (HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL, USERNAME) VALUES (' 
        || v_last_name || ' ' || v_first_name || ',' || v_gender || ',' ||  v_dob || ',' ||  v_address || ' , ' ||  v_phone_number || ' , ' || v_mact || ', CNTT , ' || v_sotctl || 
        ',' || v_dtbtl || ', SV_' || i || ')' );
        
        INSERT INTO SINHVIEN (HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL, USERNAME)
        VALUES (v_last_name || ' ' || v_first_name, v_gender, v_dob, v_address, v_phone_number, v_mact,'CNTT' , v_sotctl , v_dtbtl, 'SV_' || i);
        
    END LOOP;
END;
/
UPDATE DONVI 
SET TRGDV = 1
WHERE TENDV = 'Van phong khoa';
UPDATE DONVI 
SET TRGDV = 2
WHERE TENDV = 'Bo mon HTTT';
UPDATE DONVI 
SET TRGDV = 3
WHERE TENDV = 'Bo mon CNPM';
UPDATE DONVI 
SET TRGDV = 4
WHERE TENDV = 'Bo mon KHMT';
UPDATE DONVI 
SET TRGDV = 5
WHERE TENDV = 'Bo mon CNTT';
UPDATE DONVI 
SET TRGDV = 6
WHERE TENDV = 'Bo mon TGMT';
UPDATE DONVI 
SET TRGDV = 7
WHERE TENDV = 'Bo mon MMT va Vien thong';
/

DECLARE
    v_names VARCHAR2(255) := 'Nguyen,Tran,Le,Pham,Hoang,Phan,Vu,Vo,Dang,Bui';
    v_first_names VARCHAR2(255) := 'Anh,Bao,Chau,Dat,Diem,Đức,Giang,Hoa,Hung,Khanh,Linh,Long,Ly,Minh,My,Nam,Ngoc,Nga,Nguyen,Nguyet,Phong,Phuc,Phuong,Quan,Quoc,Sang,Tam,Tan,Thanh,Thao,Thien,Thi,Thuan,Tien,Tu,Tuan,Tuyen,Vi,Vinh,Yen';
    v_random_num NUMBER;
    v_phone_number VARCHAR2(20);
    v_dob DATE;
    v_gender VARCHAR2(10);
    v_salary NUMBER;
    v_last_name VARCHAR2(255);
    v_first_name VARCHAR2(255);
BEGIN
    FOR i IN 8..107 LOOP
        -- Chọn ngẫu nhiên một họ và tên đệm
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 10)); -- Số ngẫu nhiên từ 1 đến 10
        v_last_name := SUBSTR(v_names, INSTR(v_names, ',', 1, v_random_num) + 1, INSTR(v_names, ',', 1, v_random_num + 1) - INSTR(v_names, ',', 1, v_random_num) - 1);
        
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 40)); -- Số ngẫu nhiên từ 1 đến 40
        v_first_name := SUBSTR(v_first_names, INSTR(v_first_names, ',', 1, v_random_num) + 1, INSTR(v_first_names, ',', 1, v_random_num + 1) - INSTR(v_first_names, ',', 1, v_random_num) - 1);
        
        -- Tạo số điện thoại ngẫu nhiên
        v_phone_number := '0' || TRUNC(DBMS_RANDOM.VALUE(100000000, 999999999));
        
        -- Tạo ngày sinh ngẫu nhiên
       
        v_dob := ADD_MONTHS(TO_DATE('1967-01-01', 'YYYY-MM-DD'), 12 * TRUNC(DBMS_RANDOM.VALUE(11, 25))); -- Trừ đi số tháng ngẫu nhiên từ 11 đến 25
        v_dob := v_dob + TRUNC(DBMS_RANDOM.VALUE(11, 365));
        
        -- Tạo lương ngẫu nhiên
        v_salary := TRUNC(DBMS_RANDOM.VALUE(5000000, 20000000)); -- Lương từ 5 triệu đến 20 triệu
         
        v_gender := CASE WHEN DBMS_RANDOM.VALUE() < 0.5 THEN 'Nam' ELSE 'Nu' END;
        
        v_random_num := TRUNC(DBMS_RANDOM.VALUE(1, 7)); -- Số ngẫu nhiên từ 1 đến 7
        -- Chèn dữ liệu vào bảng NHANSU
        
        IF i < 88 
        THEN
        DBMS_OUTPUT.PUT_LINE('INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) VALUES (' 
        || v_last_name || ' ' || v_first_name || ',' || v_gender || ',' ||  v_dob || ',' ||  v_salary || ' , ' ||  v_phone_number || ' , GIẢNG VIÊN , ' || v_random_num || 
        ', GV_' || i || ')' );
        
        INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME)
        VALUES (v_last_name || ' ' || v_first_name, v_gender, v_dob, v_salary, v_phone_number, 'GIANG VIEN', v_random_num, 'GV_' || i);
        
        ELSIF  i >= 88 AND i < 98
        THEN
        DBMS_OUTPUT.PUT_LINE('INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) VALUES (' 
        || v_last_name || ' ' || v_first_name || ',' || v_gender || ',' ||  v_dob || ',' ||  v_salary || ' , ' ||  v_phone_number || ' , GIÁO VỤ , ' || v_random_num || 
        ', GVU_' || i || ')' );
        
        INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME)
        VALUES (v_last_name || ' ' || v_first_name, v_gender, v_dob, v_salary, v_phone_number, 'GIAO VU', v_random_num, 'GVU_' || i);
        
        ELSE
        DBMS_OUTPUT.PUT_LINE('INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME) VALUES (' 
        || v_last_name || ' ' || v_first_name || ',' || v_gender || ',' ||  v_dob || ',' ||  v_salary || ' , ' ||  v_phone_number || ' , NHÂN VIÊN CƠ BẢN , ' || v_random_num || 
        ', NVCB_' || i || ')' );
        
        INSERT INTO NHANSU (HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, USERNAME)
        VALUES (v_last_name || ' ' || v_first_name, v_gender, v_dob, v_salary, v_phone_number, 'NHAN VIEN CO BAN', v_random_num, 'NVCB_' || i);
        END IF;
    END LOOP;
END;
/

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('LAP TRINH MANG', 2, 100, 50, 60, 1);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('AN NINH MANG', 4, 120, 60, 65, 1);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('NHAP MON MA HOA', 4, 150, 75, 70, 1);

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('AN TOAN VA BAO MAT HTTT', 4, 100, 50, 60, 2);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('HE QUAN TRI CSDL', 2, 120, 60, 65, 2);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('CO SO DU LIEU NANG CAO', 3, 150, 75, 70, 2);

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('LAP TRINH WINDOWS', 4, 100, 50, 60, 3);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('LAP TRINH ANDROID', 2, 120, 60, 65, 3);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('KIEM THU PHAN MEM', 3, 150, 75, 70, 3);

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('NHAP MON HOC MAY', 4, 100, 50, 60, 4);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('CO SO TRI TUE NANG CAO', 3, 120, 60, 65, 4);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('NHAP MON HOC SAU', 3, 150, 75, 70, 4);

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('THIET KE GIAO DIEN', 4, 100, 50, 60, 5);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('PHAN TICH YEU CAU DOANH NGHIEP', 4, 120, 60, 65, 5);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('DO HOA MAY TINH', 2, 150, 75, 70, 5);

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('KHAI THAC DU LIEU DO THI', 3, 100, 50, 60, 6);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('UNG DUNG PHAN TAN', 4, 120, 60, 65, 6);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('NHAP MON DU LIEU LON', 3, 150, 75, 70, 6);

INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('LAP TRINH MANG', 2, 100, 50, 60, 7);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('AN NINH MANG', 2, 120, 60, 65, 7);
INSERT INTO HOCPHAN (TENHP, SOTC, STLT, STTH, SOSVTD, MADV)
VALUES ('NHAP MON MA HOA', 4, 150, 75, 70, 7);

/

SELECT * FROM KHMO;
-- Dữ liệu cho bảng KHMO
DELETE FROM KHMO;
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (1, 1, '2023-2024', 'CQ');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (2, 2, '2023-2024', 'CLC');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (3, 1, '2023-2024', 'CQ');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (4, 2, '2022-2023', 'CTTT');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (5, 1, '2023-2024', 'VP');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (6, 2, '2022-2023', 'CLC');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (7, 1, '2024-2025', 'CQ');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (8, 2, '2023-2024', 'CTTT');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (9, 2, '2021-2022', 'CLC');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (10, 2, '2021-2022', 'VP');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (1, 3, '2020-2021', 'CQ');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (2, 1, '2023-2024', 'CLC');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (3, 3, '2024-2025', 'CQ');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (4, 1, '2021-2022', 'CLC');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES (5, 1, '2023-2024', 'CLC');
/
-- Dữ liệu cho bảng DANGKY
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (1, 1, 1, '2023-2024', 'CQ', 1, 8.5, 7.5, 9.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (2, 2, 1, '2023-2024', 'CLC', 2, 7.0, 8.0, 8.5);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (3, 3, 1, '2023-2024', 'CLC', 3, 9.0, 8.0, 7.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (4, 4, 2, '2023-2024', 'VP', 4, 5.0, 8.0, 8.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (5, 1, 2, '2021-2022', 'CTTT', 5, 7.5, 7.5, 8.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (6, 2, 2, '2021-2022', 'CTTT', 1, 7.0, 9.0, 8.5);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (7, 3, 3, '2021-2022', 'CLC', 2, 8.5, 5.0, 8.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (8, 4, 3, '2021-2022', 'VP', 3, 6.0, 8.0, 5.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (9, 4, 3, '2020-2021', 'CQ', 4, 5.5, 8.5, 9.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (1, 5, 3, '2021-202', 'CQ', 1, 8.5, 7.5, 9.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (2, 5, 2, '2023-2024', 'CLC', 2, 7.0, 8.0, 8.5);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (3, 6, 2, '2023-2024', 'CLC', 3, 9.0, 8.5, 9.5);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (4, 6, 3, '2023-2024', 'VP', 4, 6.0, 8.5, 8.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (5, 7, 1, '2023-2024', 'CTTT', 5, 7.5, 7.5, 8.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (6, 7, 3, '2021-2022', 'CTTT', 1, 7.0, 9.0, 8.5);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (7, 8, 2, '2021-2022', 'CLC', 2, 8.5, 9.0, 4.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (8, 8, 2, '2021-2022', 'VP', 3, 6.0, 7.5, 5.0);
INSERT INTO DANGKY (MAGV, MAHP, HK, NAM, MACT, MASV, DIEMTH, DIEMQT, DIEMCK)
VALUES (9, 9, 1, '2020-2021', 'CQ', 4, 5.5, 8.5, 9.0);
/
SELECT * FROM DANGKY;
SELECT * FROM SINHVIEN;
-- Dữ liệu cho bảng PHANCONG
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (1, 1, 1, '2021-2022', 'CQ');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (2, 2, 2, '2023-2024', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (3, 3, 1, '2023-2024', 'CTTT');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (4, 4, 2, '2021-2022', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (5, 5, 3, '2023-2024', 'CQ');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (6, 1, 1, '2021-2022', 'VP');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (7, 2, 2, '2022-2023', 'CTTT');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (8, 3, 1, '2023-2024', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (9, 4, 2, '2023-2024', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (10, 5, 3, '2022-2023', 'CLC');

INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (1, 6, 2, '2021-2022', 'CQ');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (2, 7, 3, '2023-2024', 'CQ');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (3, 8, 3, '2023-2024', 'CTTT');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (4, 9, 1, '2021-2022', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (5, 10, 2, '2023-2024', 'CQ');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (6, 6, 2, '2021-2022', 'VP');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (7, 7, 3, '2022-2023', 'VP');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (8, 8, 2, '2023-2024', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (9, 9, 3, '2023-2024', 'CLC');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (10, 10, 2, '2022-2023', 'CTTT');
/
SELECT * FROM PHANCONG;
