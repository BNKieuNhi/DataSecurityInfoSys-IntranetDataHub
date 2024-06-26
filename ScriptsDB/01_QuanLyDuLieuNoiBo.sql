-- ====== Chạy với user U_ADMIN ======
-- ====== 1. Xóa các bảng ======
DROP TABLE PHANCONG;
DROP TABLE DANGKY;
DROP TABLE KHMO;
DROP TABLE HOCPHAN;
DROP TABLE SINHVIEN;
DROP TABLE DONVI;
DROP TABLE NHANSU;

--====== 2. Tạo CSDL ======
CREATE TABLE  NHANSU(
    MANV NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    HOTEN VARCHAR2(255),
    PHAI VARCHAR2(10),
    NGSINH DATE,
    PHUCAP NUMBER,
    DT NUMBER(12),
    VAITRO VARCHAR2(50),
    MADV NUMBER,
    USERNAME VARCHAR(255)
);

CREATE TABLE  SINHVIEN(
    MASV NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    HOTEN VARCHAR2(255),
    PHAI VARCHAR2(10),
    NGSINH DATE,
    DCHI VARCHAR2(255),
    DT NUMBER(12),
    MACT  VARCHAR2(50),
    MANGANH  VARCHAR2(50),
    SOTCTL NUMBER(3),
    DTBTL NUMBER(2,1),
    USERNAME VARCHAR(255)
);

CREATE TABLE DONVI (
    MADV NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    TENDV VARCHAR2(255),
    TRGDV NUMBER
);

CREATE TABLE HOCPHAN (
    MAHP NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    TENHP VARCHAR2(255),
    SOTC NUMBER(2),
    STLT NUMBER (3),
    STTH NUMBER (3),
    SOSVTD NUMBER (4),
    MADV NUMBER
);

CREATE TABLE KHMO (
    MAHP NUMBER,
    HK NUMBER(1),
    NAM VARCHAR2(15),
    MACT  VARCHAR2(50),
    
    CONSTRAINT HOCPHAN_PK PRIMARY KEY (MAHP,HK,NAM,MACT)
);

CREATE TABLE DANGKY (
    MAGV NUMBER,
    MAHP NUMBER,
    HK NUMBER(1),
    NAM VARCHAR2(15),
    MACT  VARCHAR2(50),
    MASV NUMBER,
    DIEMTH NUMBER(3,2),
    DIEMQT NUMBER(3,2),
    DIEMCK NUMBER(3,2),
    DIEMTK NUMBER(3,2),
    
    CONSTRAINT DANGKY_PK PRIMARY KEY (MAGV,MAHP,HK,NAM,MACT,MASV)
);

CREATE TABLE PHANCONG (
    MAGV NUMBER,
    MAHP NUMBER,
    HK NUMBER(1),
    NAM VARCHAR2(15),
    MACT  VARCHAR2(50),
    
    CONSTRAINT PHANCONG_PK PRIMARY KEY (MAGV,MAHP,HK,NAM,MACT)
);

--====== 3. Tạo khóa ngoại ======
ALTER TABLE NHANSU
ADD CONSTRAINT FK_NHANSU_DONVI
FOREIGN KEY (MADV)
REFERENCES DONVI (MADV);

ALTER TABLE DONVI
ADD CONSTRAINT FK_DONVI_NHANSU
FOREIGN KEY (TRGDV)
REFERENCES NHANSU (MANV);

ALTER TABLE HOCPHAN
ADD CONSTRAINT FK_HOCPHAN_DONVI
FOREIGN KEY (MADV)
REFERENCES DONVI (MADV);

ALTER TABLE KHMO
ADD CONSTRAINT FK_KHMO_HOCPHAN
FOREIGN KEY (MAHP)
REFERENCES HOCPHAN (MAHP);

ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_NHANSU
FOREIGN KEY (MAGV)
REFERENCES NHANSU (MANV);

ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_HOCPHAN
FOREIGN KEY (MAHP)
REFERENCES HOCPHAN (MAHP);

ALTER TABLE DANGKY
ADD CONSTRAINT FK_DANGKY_SINHVIEN
FOREIGN KEY (MASV)
REFERENCES SINHVIEN (MASV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_NHANSU
FOREIGN KEY (MAGV)
REFERENCES NHANSU (MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_HOCPHAN
FOREIGN KEY (MAHP)
REFERENCES HOCPHAN (MAHP);

CREATE OR REPLACE TRIGGER tinh_diem_tong_ket
BEFORE INSERT ON DANGKY
FOR EACH ROW
DECLARE
    -- Khai báo biến để lưu trữ điểm thực hành, quá trình và cuối kỳ
    diem_thuc_hanh NUMBER;
    diem_qua_trinh NUMBER;
    diem_cuoi_ky NUMBER;
    diem_tong_ket NUMBER;
    v_dtbtl NUMBER(5, 2);
    v_sotctl NUMBER(2, 0);
    BEGIN
    -- Lấy điểm thực hành, quá trình và cuối kỳ từ dữ liệu mới được chèn hoặc cập nhật
    diem_thuc_hanh := :NEW.DIEMTH;
    diem_qua_trinh := :NEW.DIEMQT;
    diem_cuoi_ky := :NEW.DIEMCK;
    
    -- Tính toán điểm tổng kết dựa trên công thức tỉ lệ cho trước
    diem_tong_ket := diem_thuc_hanh*0.4 + diem_qua_trinh*0.1 + diem_cuoi_ky*0.5;
    
    -- Gán giá trị điểm tổng kết vào cột ĐIEMTK
    :NEW.DIEMTK := diem_tong_ket;


    -- Calculate DTBTL
    IF :NEW.DIEMTK >= 5 THEN
        BEGIN
            -- Calculate SOTCTL
            SELECT SUM(h.SOTC)
            INTO v_sotctl
            FROM HOCPHAN h
            JOIN DANGKY d ON h.MAHP = d.MAHP
            WHERE d.MASV = :NEW.MASV
            AND d.DIEMTK >= 5;

            -- Calculate DTBTL
            SELECT SUM(:NEW.DIEMTK * h.SOTC) / v_sotctl
            INTO v_dtbtl
            FROM HOCPHAN h
            WHERE h.MAHP = :NEW.MAHP;

            -- Update DTBTL in SINHVIEN table
            UPDATE SINHVIEN
            SET DTBTL = v_dtbtl, SOTCTL = v_sotctl
            WHERE MASV = :NEW.MASV;
        EXCEPTION
            WHEN NO_DATA_FOUND THEN
                v_dtbtl := 0;
        END;
    END IF;
END;
/
CREATE OR REPLACE TRIGGER TRG_CAP_NHAT_DIEMTK
BEFORE UPDATE OF DIEMTH, DIEMQT, DIEMCK ON DANGKY
FOR EACH ROW
BEGIN
    -- Tính toán điểm tổng kết dựa trên công thức tỉ lệ cho trước
    :NEW.DIEMTK := :NEW.DIEMTH * 0.4 + :NEW.DIEMQT * 0.1 + :NEW.DIEMCK * 0.5;
END;
/
CREATE OR REPLACE TRIGGER trg_update_username_nhansu
BEFORE INSERT ON NHANSU
FOR EACH ROW
DECLARE
    v_username VARCHAR2(50);
BEGIN
    -- Tạo username mới từ vaitro và manv
    -- Chuyển manv thành chuỗi và thêm tiền tố phù hợp
    IF :NEW.vaitro = 'TRUONG KHOA' THEN
        v_username := 'TK_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'NHAN VIEN CO BAN' THEN
        v_username := 'NVCB_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'TRUONG DON VI' THEN
        v_username := 'TDV_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'GIANG VIEN' THEN
        v_username := 'GV_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'GIAO VU' THEN
        v_username := 'GVU_' || TO_CHAR(:NEW.manv);
    ELSE
        -- Trong trường hợp không khớp với bất kỳ vai trò nào khác,
        -- giữ nguyên giá trị của username
        v_username := :NEW.username;
    END IF;

    -- Cập nhật giá trị username mới
    :NEW.username := v_username;
END;
/

CREATE OR REPLACE TRIGGER trg_update_username_nhansu_2
BEFORE INSERT ON NHANSU
FOR EACH ROW
DECLARE
    v_username VARCHAR2(50);
BEGIN
    -- Tạo username mới từ vaitro và manv
    -- Chuyển manv thành chuỗi và thêm tiền tố phù hợp
    IF :NEW.vaitro = 'TRUONGKHOA' THEN
        v_username := 'TK_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'NVCB' THEN
        v_username := 'NVCB_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'TRUONGDONVI' THEN
        v_username := 'TDV_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'GIANGVIEN' THEN
        v_username := 'GV_' || TO_CHAR(:NEW.manv);
    ELSIF :NEW.vaitro = 'GIAOVU' THEN
        v_username := 'GVU_' || TO_CHAR(:NEW.manv);
    ELSE
        -- Trong trường hợp không khớp với bất kỳ vai trò nào khác,
        -- giữ nguyên giá trị của username
        v_username := :NEW.username;
    END IF;

    -- Cập nhật giá trị username mới
    :NEW.username := v_username;
END;
/

CREATE OR REPLACE TRIGGER trg_update_username
BEFORE INSERT OR UPDATE ON SINHVIEN
FOR EACH ROW
DECLARE
    v_username VARCHAR2(50);
BEGIN
    -- Tạo username mới từ masv
    -- Chuyển masv thành chuỗi và thêm tiền tố "SV_"
    v_username := 'SV_' || TO_CHAR(:NEW.masv);

    -- Cập nhật giá trị username mới
    :NEW.username := v_username;
END;
/
