--ALTER SESSION SET CONTAINER = CDB$ROOT; --chuyen session 
ALTER SESSION SET CONTAINER = PDBQLDLNB; --chuyen session 
SHOW CON_NAME;

--TẠO USER U_ADMIN
---> TẠO ADMIN OLS & CẤP QUYỀN CHO U_ADMIN
alter session set "_ORACLE_SCRIPT" = TRUE; 
DROP USER U_ADMIN CASCADE;
/
CREATE USER U_ADMIN IDENTIFIED BY 123 CONTAINER = CURRENT;
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;

-- CẤP QUYỀN CHO U_ADMIN
GRANT CONNECT,RESOURCE TO U_ADMIN;
GRANT ALL PRIVILEGES TO U_ADMIN with ADMIN OPTION;
GRANT GRANT ANY PRIVILEGE TO U_ADMIN;
GRANT ALTER SESSION TO U_ADMIN;

GRANT SELECT ON DBA_ROLE_PRIVS TO U_ADMIN WITH GRANT OPTION;
GRANT SELECT ON DBA_TAB_PRIVS TO U_ADMIN WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO U_ADMIN WITH GRANT OPTION;

GRANT SELECT ON dba_tables to U_ADMIN WITH GRANT OPTION;

GRANT SELECT ON dba_users to U_ADMIN WITH GRANT OPTION;

GRANT SELECT ON USER_ROLE_PRIVS to U_ADMIN WITH GRANT OPTION;
GRANT SELECT ON DBA_ROLES to U_ADMIN WITH GRANT OPTION;

-- CẤP QUYỀN EXECUTE CHO U_ADMIN
grant execute on DBMS_RLS to U_ADMIN;
grant execute on DBMS_CRYPTO to U_ADMIN;

GRANT SELECT ON dba_audit_trail TO U_ADMIN;

GRANT SELECT ON dba_audit_trail TO U_ADMIN;
GRANT EXECUTE ON DBMS_FGA TO U_ADMIN;
GRANT SELECT ON SYS.FGA_LOG$ TO U_ADMIN;
