--FGA
--Update DANGKY khi vai tro khong phai GIANGVIEN
SHOW CON_NAME;
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'U_ADMIN',
  object_name        => 'DANGKY',
  policy_name        => 'UPDATE_DIEM_NOTGV');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_ADMIN',
   object_name        => 'DANGKY',
   policy_name        => 'UPDATE_DIEM_NOTGV',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'DIEMQT,DIEMTH,DIEMCK',
   audit_condition    => 'USER NOT LIKE ''%GV_%''',
   audit_column_opts   => DBMS_FGA.ANY_COLUMNS,
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/
-- tao policy
--TEST
SELECT DBUID, OBJ$SCHEMA, OBJ$NAME, LSQLTEXT, NTIMESTAMP# 
FROM SYS.FGA_LOG$
WHERE OBJ$NAME = 'DANGKY';
/

--Xem phu cap cua user khac
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'U_ADMIN',
  object_name        => 'NHANSU',
  policy_name        => 'XEMPHUCAP_CUANGKHAC');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_ADMIN',
   object_name        => 'NHANSU',
   policy_name        => 'XEMPHUCAP_CUANGKHAC',
   enable             =>  TRUE,
   statement_types    => 'SELECT',
   audit_column       => 'PHUCAP',
   audit_condition    => 'USERNAME != USER',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/
--TEST
SELECT DBUID, OBJ$SCHEMA, OBJ$NAME, LSQLTEXT, NTIMESTAMP#
FROM SYS.FGA_LOG$
WHERE OBJ$NAME = 'NHANSU';