-- ====== CS#6: Người dùng có VAITRO là “Sinh viên” có quyền hạn: ======
-- 6.1 Trên quan hệ SINHVIEN, sinh viên chỉ được xem thông tin của chính mình, được
-- Chỉnh sửa thông tin địa chỉ (ĐCHI) và số điện thoại liên lạc (ĐT) của chính sinh viên.

-- NẾU NGƯỜI DÙNG LÀ SINH VIÊN THÌ CHỈ ĐƯỢC XEM THÔNG TIN CỦA CHÍNH MÌNH --
CREATE OR REPLACE FUNCTION SV_POLICY1
 (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    ROLE_NAME VARCHAR2(100);
BEGIN
    -- Lấy tên vai trò của người dùng
    SELECT MAX(granted_role)
      INTO ROLE_NAME
      FROM dba_role_privs
     WHERE grantee = SYS_CONTEXT('USERENV', 'SESSION_USER');

    -- Kiểm tra nếu vai trò là SINHVIEN
    IF ROLE_NAME = 'SINHVIEN' THEN
        RETURN 'USERNAME = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')';
    ELSE
        RETURN '1 = 1';
    END IF;
END;
/
BEGIN 
 DBMS_RLS.ADD_POLICY (
OBJECT_SCHEMA => 'U_ADMIN',
OBJECT_NAME => 'SINHVIEN',
POLICY_NAME => 'SV_PC1',
POLICY_FUNCTION => 'SV_POLICY1',
FUNCTION_SCHEMA => 'U_ADMIN',
STATEMENT_TYPES => 'SELECT, UPDATE',
SEC_RELEVANT_COLS =>'DCHI, DT',
UPDATE_CHECK => TRUE 
);
END;

BEGIN
  DBMS_RLS.DROP_POLICY (
    OBJECT_SCHEMA => 'U_ADMIN',
    OBJECT_NAME   => 'SINHVIEN',
    POLICY_NAME   => 'SV_PC2'
  );
END;
/
-- SINH VIÊN KHÔNG ĐƯỢC CẬP NHẬT CÁC CỘT CÒN LẠI TRỪ CỘT DCHI, DT --
CREATE OR REPLACE FUNCTION SV_POLICY2
 (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
 ROLE_NAME VARCHAR2(100);
BEGIN
    -- Lấy tên vai trò của người dùng
    SELECT MAX(granted_role)
      INTO ROLE_NAME
      FROM dba_role_privs
     WHERE grantee = SYS_CONTEXT('USERENV', 'SESSION_USER');

    -- Kiểm tra nếu vai trò là SINHVIEN
    IF ROLE_NAME = 'SINHVIEN' THEN
        RETURN ' 1 = 0 ';
    ELSE
        RETURN '1 = 1';
    END IF;
END;

/

BEGIN 
 DBMS_RLS.ADD_POLICY (
OBJECT_SCHEMA => 'U_ADMIN',
OBJECT_NAME => 'SINHVIEN',
POLICY_NAME => 'SV_PC2',
POLICY_FUNCTION => 'SV_POLICY2',
FUNCTION_SCHEMA => 'U_ADMIN',
STATEMENT_TYPES => 'UPDATE',
SEC_RELEVANT_COLS =>'MASV, HOTEN, PHAI, NGSINH, MACT, MANGANH, SOTCTL, DTBTL',
UPDATE_CHECK => FALSE 
);
END;
grant select, UPDATE on U_ADMIN.SINHVIEN to SINHVIEN
-- 6.2 Xem danh sách tất cả học phần (HOCPHAN), kế hoạch mở môn (KHMO) của chương
-- trình đào tạo mà sinh viên đang theo học.
create or replace FUNCTION SV_POLICY3
    (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    MA VARCHAR2(5);
    STRSQL VARCHAR2(2000);
    ROLE_NAME VARCHAR2(100);
    CURSOR CUR IS (SELECT MAHP
                   FROM U_ADMIN.KHMO KH , U_ADMIN.SINHVIEN SV
                   WHERE SV.USERNAME = SYS_CONTEXT('USERENV','SESSION_USER') 
                   AND KH.MACT = SV.MACT);
BEGIN
    SELECT MAX(granted_role)
      INTO ROLE_NAME
      FROM dba_role_privs
     WHERE grantee = SYS_CONTEXT('USERENV', 'SESSION_USER');
    -- Kiểm tra nếu vai trò là SINHVIEN
    IF ROLE_NAME = 'SINHVIEN' THEN
    OPEN CUR;
    LOOP
        FETCH CUR INTO MA;
        EXIT WHEN CUR%NOTFOUND;

        IF (STRSQL IS NOT NULL) THEN
            STRSQL := STRSQL ||''',''';
        END IF;
        STRSQL := STRSQL || MA;
    END LOOP;
    RETURN 'MAHP IN ('''||STRSQL||''')';
    ELSE
        RETURN '1 = 1';
    END IF;
END;

BEGIN 
 DBMS_RLS.ADD_POLICY (
OBJECT_SCHEMA => 'U_ADMIN',
OBJECT_NAME => 'HOCPHAN',
POLICY_NAME => 'SV_PC3',
POLICY_FUNCTION => 'SV_POLICY3',
FUNCTION_SCHEMA => 'U_ADMIN',
STATEMENT_TYPES => 'SELECT'
);
END;

-- 6.3 Thêm, Xóa các dòng dữ liệu đăng ký học phần (ĐANGKY) liên quan đến chính sinh
-- viên đó trong học kỳ của năm học hiện tại (nếu thời điểm hiệu chỉnh đăng ký còn hợp
-- lệ).
-- 6.4 Sinh viên không được chỉnh sửa trên các trường liên quan đến điểm
CREATE OR REPLACE FUNCTION SV_POLICY6
    (P_SCHEMA VARCHAR2, P_OBJ VARCHAR2)
RETURN VARCHAR2
AS
    ROLE_NAME VARCHAR2(100);
    MASV NUMBER;
BEGIN
    SELECT MAX(granted_role)
    INTO ROLE_NAME
    FROM dba_role_privs
    WHERE grantee = SYS_CONTEXT('USERENV', 'SESSION_USER');
    IF ROLE_NAME = 'SINHVIEN' THEN
        SELECT TO_NUMBER(SUBSTR(SYS_CONTEXT('USERENV', 'SESSION_USER'), 4)) 
        INTO MASV FROM DUAL;
        RETURN 'MASV = ' || MASV;
    ELSE

        RETURN '1 = 1';
    END IF;
END;
/
BEGIN 
 DBMS_RLS.ADD_POLICY (
OBJECT_SCHEMA => 'U_ADMIN',
OBJECT_NAME => 'DANGKY',
POLICY_NAME => 'SV_PC6',
POLICY_FUNCTION => 'SV_POLICY6',
FUNCTION_SCHEMA => 'U_ADMIN',
STATEMENT_TYPES => 'UPDATE',
SEC_RELEVANT_COLS =>'DIEMTH, DIEMQT, DIEMCK, DIEMTK',
UPDATE_CHECK => FALSE 
);
END;

-- 6.5 Sinh viên được Xem tất cả thông tin trên quan hệ DANGKY tại các dòng dữ liệu liên quan đến chính sinh viên.

BEGIN 
 DBMS_RLS.ADD_POLICY (
OBJECT_SCHEMA => 'U_ADMIN',
OBJECT_NAME => 'DANGKY',
POLICY_NAME => 'SV_PC7',
POLICY_FUNCTION => 'SV_POLICY6',
FUNCTION_SCHEMA => 'U_ADMIN',
STATEMENT_TYPES => 'SELECT'
);
END;
grant select on U_ADMIN.HOCPHAN to SINHVIEN
grant select on U_ADMIN.KHMO to SINHVIEN
grant select on U_ADMIN.DANGKY to SINHVIEN
grant select, UPDATE on U_ADMIN.SINHVIEN to SINHVIEN