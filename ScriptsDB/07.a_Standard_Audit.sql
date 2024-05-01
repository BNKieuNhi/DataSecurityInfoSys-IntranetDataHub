--Standard audit
--Record tat ca nhung thao tac cua tat ca nguoi dung tren csdl
GRANT AUDIT ANY TO U_ADMIN;

SELECT * FROM DBA_USERS WHERE USERNAME = 'U_ADMIN';

ALTER SYSTEM SET AUDIT_TRAIL=DB, EXTENDED SCOPE=SPFILE;
SHUTDOWN IMMEDIATE;
STARTUP;

SET SERVEROUT ON;
DECLARE
  v_sql VARCHAR2(4000);
BEGIN
  FOR user_rec IN (SELECT * FROM U_ADMIN.NHANSU) LOOP
    v_sql := 'AUDIT ALL BY ' || user_rec.username || ' BY ACCESS';
    EXECUTE IMMEDIATE v_sql;
    v_sql := 'AUDIT SELECT TABLE, UPDATE TABLE, INSERT TABLE, DELETE TABLE BY ' || user_rec.username || ' BY ACCESS';
    EXECUTE IMMEDIATE v_sql;
    DBMS_OUTPUT.PUT_LINE('AUDIT ALL BY ' || user_rec.username || ' BY ACCESS');
  END LOOP;
END;

-- Theo doi cac hanh vi thanh cong
AUDIT ALL WHENEVER SUCCESSFUL;

-- Theo doi cac hanh vi khong thanh cong
AUDIT ALL WHENEVER NOT SUCCESSFUL;

SELECT USERNAME, EXTENDED_TIMESTAMP, OWNER, OBJ_NAME, ACTION, ACTION_NAME 
FROM DBA_AUDIT_TRAIL
WHERE OWNER = 'U_ADMIN' 
ORDER BY EXTENDED_TIMESTAMP desc;

SELECT *
FROM DBA_AUDIT_TRAIL
WHERE OWNER = 'U_ADMIN' 
ORDER BY EXTENDED_TIMESTAMP desc;
