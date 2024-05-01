-- ====== Chạy với quyền SYS ======
ALTER SESSION SET CONTAINER = PDBQLDLNB;
SHOW CON_NAME;
/
--DELETE USER BASED ON ROLE
CREATE OR REPLACE PROCEDURE DROP_USERS_WITH_PREFIX (PREFIX IN VARCHAR2) AS
BEGIN
  FOR user_rec IN (
    SELECT username
    FROM dba_users
    WHERE username LIKE PREFIX ESCAPE '\'
  ) LOOP
    EXECUTE IMMEDIATE 'DROP USER ' || user_rec.username || ' CASCADE';
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.username || ' dropped.');
  END LOOP;
  DBMS_OUTPUT.PUT_LINE('User drop process completed.');
END;
/
BEGIN 
DROP_USERS_WITH_PREFIX('NVCB\_%');
DROP_USERS_WITH_PREFIX('GV\_%');
DROP_USERS_WITH_PREFIX('GVU\_%');
DROP_USERS_WITH_PREFIX('SV\_%');
DROP_USERS_WITH_PREFIX('TDV\_%');
DROP_USERS_WITH_PREFIX('TK\_%');
END;
/

--DROP ROLE
DROP ROLE NhanVienCoBan; 
DROP ROLE GiangVien; 
DROP ROLE GiaoVu; 
DROP ROLE TruongDonVi; 
DROP ROLE TruongKhoa; 
DROP ROLE SinhVien; 
/
--CREATE ROLE
CREATE ROLE NhanVienCoBan CONTAINER = CURRENT; 
CREATE ROLE GiangVien CONTAINER = CURRENT; 
CREATE ROLE GiaoVu CONTAINER = CURRENT; 
CREATE ROLE TruongDonVi CONTAINER = CURRENT; 
CREATE ROLE TruongKhoa CONTAINER = CURRENT; 
CREATE ROLE SinhVien CONTAINER = CURRENT; 
/

--CREATE USER
--CREATE 10 USERS FOR ROLE NhanVienCoBan 
CREATE OR REPLACE PROCEDURE CREATE_USERS_AND_ASSIGN_ROLE_NVCB (NUM IN NUMERIC) AS
BEGIN
  FOR user_rec IN (
    SELECT USERNAME
    FROM U_ADMIN.NHANSU
    WHERE VAITRO = 'NHAN VIEN CO BAN'
    AND ROWNUM <= NUM -- Limit to 10 users
  ) LOOP
    -- Generate SQL statements dynamically to create users and grant role
     -- Enable Oracle script
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE 'CREATE USER ' || user_rec.USERNAME || ' IDENTIFIED BY ' || user_rec.USERNAME || ' CONTAINER = CURRENT';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT SELECT ON U_ADMIN.THONGBAO TO ' || user_rec.USERNAME;

    EXECUTE IMMEDIATE 'GRANT NhanVienCoBan TO ' || user_rec.USERNAME;
    
    -- Print a message for each user created
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.USERNAME || ' created and assigned role.');
  END LOOP;
  
  -- Print a message after completing the user creation process
  DBMS_OUTPUT.PUT_LINE('User creation process completed.');
END;
/

EXEC CREATE_USERS_AND_ASSIGN_ROLE_NVCB (10); 

--CREATE 80 USERS FOR ROLE GiangVien 
CREATE OR REPLACE PROCEDURE CREATE_USERS_AND_ASSIGN_ROLE_GiangVien (NUM IN NUMERIC) AS
BEGIN
  FOR user_rec IN (
    SELECT USERNAME
    FROM U_ADMIN.NHANSU
    WHERE VAITRO = 'GIANG VIEN'
    AND ROWNUM <= NUM 
  ) LOOP
    -- Generate SQL statements dynamically to create users and grant role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE 'CREATE USER ' || user_rec.USERNAME || ' IDENTIFIED BY ' || user_rec.USERNAME || ' CONTAINER = CURRENT';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT SELECT ON U_ADMIN.THONGBAO TO ' || user_rec.USERNAME;
    
    EXECUTE IMMEDIATE 'GRANT GiangVien TO ' || user_rec.USERNAME;
    
    -- Print a message for each user created
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.USERNAME || ' created and assigned role.');
  END LOOP;
  
  -- Print a message after completing the user creation process
  DBMS_OUTPUT.PUT_LINE('User creation process completed.');
END;
/

EXEC CREATE_USERS_AND_ASSIGN_ROLE_GiangVien (80); 

--CREATE 10 USERS FOR ROLE GiaoVu
CREATE OR REPLACE PROCEDURE CREATE_USERS_AND_ASSIGN_ROLE_GiaoVu (NUM IN NUMERIC) AS
BEGIN
  FOR user_rec IN (
    SELECT USERNAME
    FROM U_ADMIN.NHANSU
    WHERE VAITRO = 'GIAO VU'
    AND ROWNUM <= NUM
  ) LOOP
    -- Generate SQL statements dynamically to create users and grant role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE 'CREATE USER ' || user_rec.USERNAME || ' IDENTIFIED BY ' || user_rec.USERNAME || ' CONTAINER = CURRENT';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT SELECT ON U_ADMIN.THONGBAO TO ' || user_rec.USERNAME;
     
    EXECUTE IMMEDIATE 'GRANT GiaoVu TO ' || user_rec.USERNAME;
    
    -- Print a message for each user created
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.USERNAME || ' created and assigned role.');
  END LOOP;
  
  -- Print a message after completing the user creation process
  DBMS_OUTPUT.PUT_LINE('User creation process completed.');
END;
/

EXEC CREATE_USERS_AND_ASSIGN_ROLE_GiaoVu (10); 

--CREATE 6 USERS FOR ROLE TruongDonVi 
CREATE OR REPLACE PROCEDURE CREATE_USERS_AND_ASSIGN_ROLE_TDV (NUM IN NUMERIC) AS
BEGIN
  FOR user_rec IN (
    SELECT USERNAME
    FROM U_ADMIN.NHANSU
    WHERE VAITRO = 'TRUONG DON VI'
    AND ROWNUM <= NUM -- Limit to 10 users
  ) LOOP
    -- Generate SQL statements dynamically to create users and grant role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE 'CREATE USER ' || user_rec.USERNAME || ' IDENTIFIED BY ' || user_rec.USERNAME || ' CONTAINER = CURRENT';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT SELECT ON U_ADMIN.THONGBAO TO ' || user_rec.USERNAME;
    
    EXECUTE IMMEDIATE 'GRANT TruongDonVi TO ' || user_rec.USERNAME;
    
    -- Print a message for each user created
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.USERNAME || ' created and assigned role.');
  END LOOP;
  
  -- Print a message after completing the user creation process
  DBMS_OUTPUT.PUT_LINE('User creation process completed.');
END;
/

EXEC CREATE_USERS_AND_ASSIGN_ROLE_TDV (6); 

--CREATE 1 USER FOR ROLE TruongKhoa 
CREATE OR REPLACE PROCEDURE CREATE_USERS_AND_ASSIGN_ROLE_TK (NUM IN NUMERIC) AS
BEGIN
  FOR user_rec IN (
    SELECT USERNAME
    FROM U_ADMIN.NHANSU
    WHERE VAITRO = 'TRUONG KHOA'
    AND ROWNUM <= NUM
  ) LOOP
    -- Generate SQL statements dynamically to create users and grant role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE 'CREATE USER ' || user_rec.USERNAME || ' IDENTIFIED BY ' || user_rec.USERNAME || ' CONTAINER = CURRENT';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT SELECT ON U_ADMIN.THONGBAO TO ' || user_rec.USERNAME;
     
    EXECUTE IMMEDIATE 'GRANT TruongKhoa TO ' || user_rec.USERNAME;
    
    -- Print a message for each user created
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.USERNAME || ' created and assigned role.');
  END LOOP;
  
  -- Print a message after completing the user creation process
  DBMS_OUTPUT.PUT_LINE('User creation process completed.');
END;
/

EXEC CREATE_USERS_AND_ASSIGN_ROLE_TK (1); 

--CREATE 30 USERS FOR ROLE SinhVien 
CREATE OR REPLACE PROCEDURE CREATE_USERS_AND_ASSIGN_ROLE_SV (NUM IN NUMERIC)AS
BEGIN
  FOR user_rec IN (
    SELECT USERNAME
    FROM U_ADMIN.SINHVIEN
    WHERE ROWNUM <= NUM
  ) LOOP
    -- Generate SQL statements dynamically to create users and grant role
    EXECUTE IMMEDIATE 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE 'CREATE USER ' || user_rec.USERNAME || ' IDENTIFIED BY ' || user_rec.USERNAME || ' CONTAINER = CURRENT';
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || user_rec.USERNAME; 
    EXECUTE IMMEDIATE 'GRANT SELECT ON U_ADMIN.THONGBAO TO ' || user_rec.USERNAME;

    EXECUTE IMMEDIATE 'GRANT SinhVien TO ' || user_rec.USERNAME;
    
    -- Print a message for each user created
    DBMS_OUTPUT.PUT_LINE('User ' || user_rec.USERNAME || ' created and assigned role.');
  END LOOP;
  
  -- Print a message after completing the user creation process
  DBMS_OUTPUT.PUT_LINE('User creation process completed.');
END;
/

EXEC CREATE_USERS_AND_ASSIGN_ROLE_SV(10); 
/

SELECT username
FROM all_users;
