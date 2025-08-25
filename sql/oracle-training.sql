create table employees(
employee_id number(6,0) not null primary key,
first_name varchar2(20 byte),
last_name varchar2(25 byte) not null,
email varchar2(25 byte) not null,
phone_number varchar2(20 byte),
hire_date date not null,
job_id varchar2(10 byte) not null,
salary number(8,2),
commission_pct number(2,2),
manager_id number(6,0),
department_id number(4,0),
constraint fk_department
foreign key (department_id)
references departments(department_id)
);
--alter table employees
   -- modify email null;

create table departments(
department_id number(4,0) not null primary key,
department_name varchar2(30 byte) not null,
manager_id number(6,0),
location_id number(4,0)
);

create table job_grades(
grade char(1 byte) not null,
lowest_sal number(8,2) not null,
highest_sal number(8,2) not null
);

select * from employees
alter table employees add(email varchar2(25 byte) not null)

create table emp2(
id number(6,0) not null primary key,
first_name varchar2(20 byte),
last_name varchar2(25 byte) not null,
salary number(8,2),
dep_id number(4,0),
constraint fk_dep
foreign key (dep_id)
references departments(department_id)
);


insert into employees (employee_id, first_name, last_name, email,
phone_number, hire_date, job_id, salary, commission_pct, manager_id, department_id) values 
(100,'Steven', 'King', 'SKING','5151234567',To_date('17-06-1987', 'DD-MM-YYYY'), 'AD_PRES', 24000,null,null,90);
insert into employees values
(101,'Neena', 'Kochhar', 'NKOCHHAR','5151234568',To_date('21-09-1989', 'DD-MM-YYYY'), 'AD_VP', 17000,null,100,90);
insert into employees values
(102,'Lex', 'De Haan', 'LDEHAAN','5151234569',To_date('13-01-1993', 'DD-MM-YYYY'), 'AD_VP', 17000,null,100,90);
insert into employees values
(103,'Alexander', 'Hunold', 'AHUNOLD','5904234567',To_date('03-01-1990', 'DD-MM-YYYY'), 'IT_PROG', 9000,null,102,60);
insert into employees values
(104,'Bruce', 'Ernst', 'BERNST','5904234568',To_date('21-05-1991', 'DD-MM-YYYY'), 'IT_PROG', 6000,null,103,60);
insert into employees values
(107,'Diana', 'Lorentz', 'DLORENTZ','5904235567',To_date('07-02-1999', 'DD-MM-YYYY'), 'IT_PROG', 4200,null,103,60);
insert into employees values
(124,'Kevin', 'Mourgos', 'KMOURGOS','6501235234',To_date('16-11-1999', 'DD-MM-YYYY'), 'ST_MAN', 5800,null,100,50);
insert into employees values
(141,'Trenna', 'Rajs', 'TRAJS','6501218009',To_date('17-10-1995', 'DD-MM-YYYY'), 'ST_CLERK', 3500,null,124,50);
insert into employees values
(142,'Curtis', 'Davies', 'CDAVIES','6501212994',To_date('29-01-1997', 'DD-MM-YYYY'), 'ST_CLERK', 3100,null,124,50);
insert into employees values
(143,'Randall', 'Matos', 'RMATOS','6501212874',To_date('15-03-1998', 'DD-MM-YYYY'), 'ST_CLERK', 2600,null,124,50);
insert into employees values
(144,'Peter', 'Vargas', 'PVARGAS','6501212004',To_date('09-07-1998', 'DD-MM-YYYY'), 'ST_CLERK', 2500,null,124,50);
insert into employees values
(149,'Eleni', 'Zlotkey', 'EZLOTKEY','011441344429018',To_date('29-01-2000', 'DD-MM-YYYY'), 'SA_MAN', 10500,0.2,100,80);
insert into employees values
(174,'Ellen', 'Abel', 'EABEL','011441644429267',To_date('11-05-1996', 'DD-MM-YYYY'), 'SA_REP', 11000,0.3,149,80);
insert into employees values
(176,'Jonathon', 'Taylor', 'JTAYLOR','011441644429265',To_date('24-03-1998', 'DD-MM-YYYY'), 'SA_REP', 8600,0.2,149,80);
insert into employees values
(178,'Kimberely', 'Grant', 'KGRANT','011441644429263',To_date('24-05-1999', 'DD-MM-YYYY'), 'SA_REP', 7000,0.15,149,null);
insert into employees values
(200,'Jennifer', 'Whalen', 'JWHALEN','5151234444',To_date('17-09-1987', 'DD-MM-YYYY'), 'AD_ASST', 4400,null,101,10);
insert into employees values
(201,'Michael', 'Hartstein', 'MHARTSTE','5151235555',To_date('17-02-1996', 'DD-MM-YYYY'), 'MK_MAN', 13000,null,100,20);
insert into employees values
(202,'Pat', 'Fay', 'PFAY','6031236666',To_date('17-08-1997', 'DD-MM-YYYY'), 'MK_REP', 6000,null,201,20);
insert into employees values
(205,'Shelley', 'Higgins', 'SHIGGINS','5151238080',To_date('07-06-1994', 'DD-MM-YYYY'), 'AC_MGR', 12000,null,101,110);
insert into employees values
(206,'William', 'Gietz', 'WGIETZ','5151238181',To_date('07-06-1994', 'DD-MM-YYYY'), 'AC_ACCOUNT', 8300,null,205,110);
insert into employees values
(207,'TEST', 'TEST', 'TEST','0841234567',To_date('17-06-2018', 'DD-MM-YYYY'), 'IT_PROG', 24000,null,null,60);


select * from departments
insert into departments (department_id, department_name, manager_id, location_id) values (10,'Administration',200,1700);
insert into departments (department_id, department_name, manager_id, location_id) values (20,'Marketing',201,1800);
insert into departments (department_id, department_name, manager_id, location_id) values (50,'Shipping',124,1500);
insert into departments (department_id, department_name, manager_id, location_id) values (60,'IT',103,1400);
insert into departments (department_id, department_name, manager_id, location_id) values (80,'Sales',149,2500);
insert into departments (department_id, department_name, manager_id, location_id) values (90,'Executive',100,1700);
insert into departments (department_id, department_name, manager_id, location_id) values (110,'Accounting',205,1700);
insert into departments (department_id, department_name, manager_id, location_id) values (190,'Contracting',null,1700);

select * from job_grades
insert into job_grades values ('A', 1000, 2999);
insert into job_grades values ('B', 3000, 5999);
insert into job_grades values ('C', 6000, 9999);
insert into job_grades values ('D', 10000, 14999);
insert into job_grades values ('E', 15000, 24999);
insert into job_grades values ('F', 25000, 40000);
insert into job_grades values ('G', 20000, 35000);

--Chapter 3
select * from employees where (job_id = 'SA_REP' or job_id = 'AD_PRES') and salary > 7000 


update job_grades
set 
lowest_sal = (select lowest_sal from job_grades where grade = 'A'),
highest_sal = (select highest_sal from job_grades where grade = 'A')
where grade = 'G'

Select e.employee_id, e.first_name,j.lowest_sal, e.salary, j.highest_sal
from employees e, job_grades j
where e.salary between j.lowest_sal and j.highest_sal
-- Practice trang 29 câu a
Select employee_id, last_name, salary,(salary*12) as annual_salary
from employees 
 -- câu b: true
 select last_name, job_id, salary as sal 
 from employees;
 -- câu c 
 select (null*2) from dual;
 select (null || 'name') from dual
-- câu d
select e.last_name, d.department_id as department_number, d.department_name 
from employees e, departments d
-- câu e
select (d.department_name || ', it`s assigned Manager Id: ' || d.manager_id) as department_and_Department from departments d
-- câu f
select * from job_grades;
-- update sal
update job_grades j
set 
j.lowest_sal = 40001,
j.highest_sal = 50000
where j.grade = 'G'
/* Explain: join 2 table employees và department with same department_id
                then join job_grade using on between to find grade of salary

*/
--cách 1: Risk
select e.last_name, e.job_id, d.department_name, e.salary, j.grade
from job_grades j,
    employees e inner join departments d
    on e.department_id = d.department_id
where e.salary between j.lowest_sal and j.highest_sal
order by e.salary asc 
--cách 2: Better solution
select e.last_name, e.job_id, d.department_name, e.salary, j.grade
from 
    employees e inner join departments d
    on e.department_id = d.department_id
    join job_grades j
on e.salary between j.lowest_sal and j.highest_sal
order by e.salary asc 

--câu g
select e.last_name, e.hire_date
from employees e
where e.hire_date > TO_DATE('29-01-1997', 'DD-MM-YYYY')

--câu h
select a.last_name, a.hire_date, b.last_name as Manager, b.hire_date as Manager_hire_date
from employees a
join employees b 
on a.manager_id = b.employee_id
where TO_DATE(b.hire_date,'DD-MM-YYYY') > TO_DATE(a.hire_date, 'DD-MM-YYYY')

--câu i
select n.employee_id, n.last_name, n.salary
from employees n

where n.salary > (select avg(salary) from employees)
order by salary asc

--câu m
SELECT e.last_name,
       e.department_id
FROM employees e
LEFT JOIN departments d 
       ON e.department_id = d.department_id;

SELECT d.department_id,
       d.department_name
FROM departments d
LEFT JOIN employees e
       ON d.department_id = e.department_id;
       
       --using compound query after get all data from each query
--cách 1
select  a.last_name, a.department_id, null as department_name  from employees a, departments b 
where a.department_id  = b.department_id (+)
union
select null as last_name, d.department_id, d.department_name  from departments d, employees e
where e.department_id  = d.department_id (+)

select  a.last_name, a.department_id, null as department_name from  employees a 
left join departments b on a.department_id = b.department_id
union
select null as last_name, d.department_id, d.department_name from departments d
 left join employees e on d.department_id = e.department_id
--cách 2
SELECT last_name, department_id, NULL AS department_name
FROM employees
UNION
SELECT NULL AS last_name, department_id, department_name
FROM departments;



-- test
select * from employees
select  a.last_name, a.department_id  from employees a full join departments b on 
 a.department_id = b.department_id (+)
union
select  d.department_name , d.department_id from departments d, employees e
where e.department_id = d.department_id (+)

--câu n
create table my_employee(
employee_id number(6,0) not null primary key,
first_name varchar2(20 byte),
lastname varchar2(25 byte) not null,
email varchar2(25 byte) not null,
phonenumber varchar2(20 byte),
hiredate date not null,
jobid varchar2(10 byte) not null,
salary number(8,2),
commissionpct number(2,2),
managerid number(6,0),
departmentid number(4,0)

);

insert into my_employee values
(207,'TEST', 'TEST', 'TEST','0841234567',To_date('17-06-2018', 'DD-MM-YYYY'), 'IT_PROG', 24000,null,null,60);

select * from my_employee
update my_employee e
set
e.lastname = 'FPTS'
where employee_id = 207
savepoint b

--chapter 4

GRANT CREATE VIEW TO viethadev;

create or replace view myemploy
as select d.employee_id,d.last_name,d.email,d.salary,d.hire_date,d.job_id
from employees d
where d.employee_id = 100;


select * from employees
select * from myemploy

update myemploy
set
last_name = 'King '

create or replace view checkOption
as select d.employee_id,d.last_name, d.salary, d.department_id
from employees d
where d.department_id = 20 with check option constraint checkoption_ck;

select * from checkOption
select * from departments

update checkoption
set 
last_name = 'Hartstein 2',
salary = 12000
where employee_id = 201

--complex view

create or replace view mycomplex (name,minsal,maxsal,avgsal)
as select d.department_name, min(e.salary), max(e.salary), avg(e.salary) 
from employees e join departments d on e.department_id = d.department_id
group by d.department_name 

select * from mycomplex

select m.name, m.avgsal from mycomplex m

--Practice chap 4
--question a
create or replace view vw_EMPLOYEES
as select e.employee_id,(e.first_name || ' ' || e.last_name) as employee,e.department_id from employees e

--question b
select * from vw_employees

--question c
select v.employee, v.department_id from vw_employees v

--question d

create or replace view DEPT50
as select e.employee_id as EMPNO, e.last_name as EMPLOYEE, e.department_id as DEPTNO
from employees e
where e.department_id = 50
with check option constraint DEPT50_ck

select * from dept50

--question e

update dept50 
set 
deptno = 80
where empno = 124

--chapter 5


savepoint v
select * from departments
--Practice chap 5

--question a
create sequence dept_seq
    increment by 10
    start with 200
    maxvalue 1000
    nocache
    nocycle;
    
--question b
insert into departments (department_id, department_name, manager_id, location_id)
values (dept_seq.NEXTVAL,'Spycologic',111, 1600);

--question c
alter sequence dept_seq
increment by 20
maxvalue 10000

--question d
create index dept_index_name
on departments (department_name)

explain plan for
select * from departments d where d.department_name = 'IT';
select * from table(dbms_xplan.display)

select * from employees where department_id = 60

create index emp_index_deptId
on employees(department_id)

explain plan for
select * from employees where department_id = 60;
select * from table(dbms_xplan.display)

--question e
--before using sysnonym
select * from emp
select * from employees
--create synonym after grant 
create synonym emp
for employees;
drop synonym emp

--chapter 6

--question a1
SET SERVEROUTPUT ON;
declare 
v_emp_name employees.first_name%TYPE;
begin 
select first_name into v_emp_name
from employees
where employee_id = 100;
dbms_output.put_line('Employee Name: ' || v_emp_name);
end;
/

--question a2
create or replace package my_pkg is
    v_empl_record employees%rowtype;
end my_pkg;
/
begin
select * into my_pkg.v_empl_record
 from employees
where employee_id = 100;

dbms_output.put_line('Employee: ' || my_pkg.v_empl_record.first_name || '' || my_pkg.v_empl_record.last_name);
end;
/

--question a3
declare
v_emps_name my_pkg.v_empl_record%TYPE;
begin
select * into v_emps_name
from employees
where employee_id = 100;
dbms_output.put_line('Employee: ' || v_emps_name.first_name || '' || v_emps_name.last_name);
end;
/

--question a4
declare 
vname my_pkg.v_empl_record%rowtype;
begin
select * into vname
from employees
where employee_id = 1011;

DBMS_OUTPUT.Put_Line( 'Employee Name: ' || upper(vname.last_name));
exception
when No_data_found then
DBMS_OUTPUT.Put_Line('No employee found!' );  
  
end;
/
select * from job_grades
--question b
select e.last_name, e.job_id, 
DECODE(nvl(e.job_id, 'X') ,
 'AD_PRES', 'A', 
 'ST_MAN', 'B', 
 'IT_PROG', 'C',
 'SA_REP', 'D', 
 'ST_CLERK', 'E', 
 'X', '0',
 '0') as grade
from employees e;

--question c

select e.last_name,e.job_id,
    (case e.job_id when 'AD_PRES' then 'A'
        when 'ST_MAN' then 'B'
        when 'IT_PROG' then 'C'
        when 'SA_REP' then 'D'
        when 'ST_CLERK' then 'E'
        else '0'
    end) grade 
from employees e;

--question d

--question e
create or replace package emp_salary_new is
v_emp_salary employees%rowtype;
end emp_salary_new;
/
declare
    v_lastname employees.last_name%TYPE;
    v_salary employees.salary%type;
    v_new_salary number;
begin
for rec in
(select e.last_name,e.salary from employees e) loop 
    v_lastname := rec.last_name;
    v_salary := rec.salary;
    v_new_salary := rec.salary+(rec.salary*15.5/100);

DBMS_OUTPUT.Put_Line( 'Last name: ' || v_lastname);  
DBMS_OUTPUT.Put_Line( 'Salary: ' || v_salary);
DBMS_OUTPUT.Put_Line( 'New salary: ' || v_new_salary);

end loop;
exception
when no_data_found then
DBMS_OUTPUT.Put_Line('NO data found, try again' );  
end;
/
select *from employees
DECLARE 
    rc SYS_REFCURSOR;
BEGIN 
    OPEN rc FOR
        SELECT e.employee_id, 
               e.last_name, 
               e.salary AS old_salary,
               ROUND(e.salary * 1.155, 2) AS new_salary
        FROM employees e;
    
    DBMS_SQL.RETURN_RESULT(rc);
END;
savepoint d
drop table customer

--chapter 7
---1. Single-row function
select * from employees
--nvl function
select e.last_name, e.salary, nvl(commission_pct, 0) from employees e
where e.department_id in (50,80)

--nvl2 if express 1 null return express 3, else return express 2
select e.last_name, e.salary, nvl(commission_pct, 0), nvl2(commission_pct, 'SAL+COME', 'SAL' ) as income from employees e
where e.department_id in (50,80)

--nullif compare 2 express if equal return null, else return the first express
select  d.first_name, (LENGTH(first_name)) as express1, d.last_name, (length(d.last_name)) as express2,
nullif((LENGTH(first_name)), length(last_name)) as result
from employees d

select  d.first_name, LENGTH(first_name) as express1, d.last_name, length(d.last_name) as express2,
nullif((LENGTH(first_name)), length(last_name)) as result
from employees d

--coalesce return the first non-null expression in the express list
select e.last_name, e.manager_id,commission_pct, coalesce(commission_pct, manager_id, 0) as r 
from employees e
where e.department_id in (50,80)

/*
the diffrences between nvl and nvl2 and coalesce is 
- nvl can only have 2 express, return express1 if not null, else return express2
- nvl2 only have exactly 3 express, return express3 if null, else return express2
- coalesce can have as many as wanted, return the first non-null express, set default value to catch null
*/

---2.Multi-row function
--Group by function

select last_name, department_id, avg(salary) "Average Sal"
from employees
group by last_name, department_id
having avg(salary)>5000
order by department_id  asc

-- create Function

create or replace function check_sal(v_empno employees.employee_id%type)
return boolean is
    v_empid employees.employee_id%type;
    v_depid employees.department_id%type;
    v_avg_sal employees.salary%type;
    v_sal employees.salary%type;
begin
select employee_id, department_id, salary into v_empid,v_depid,v_sal  
from employees
where employee_id = v_empno;
select avg(salary) into v_avg_sal 
from employees 
where department_id = v_depid;
if v_sal > v_avg_sal then
return true;
else 
return false;
end if;
exception when others then return false;
end;

--invoke
select * from employees where employees.employee_id = 1001
SET SERVEROUTPUT ON;
begin 
if (check_sal(103) is null) then
dbms_output.put_line('null');
elsif(check_sal(103)) then dbms_output.put_line('salary > avg_sal');
else dbms_output.put_line('salary < avg_sal');
end if;
end;


--Practice chapter 7
--question a
select e.last_name,Round(MONTHS_BETWEEN(sysdate, e.hire_date)) as MONTHS_WORKED 
from employees e

--question b
select (e.last_name || ' earns ' || e.salary ||  ' monthly but wants ' ||  e.salary*3) as  Dream_salary
from employees e
select last_name,salary from employees

--question c
select e.last_name,(lpad(e.salary,6,'$')) as salary from employees e
where trim('$' from (lpad(e.salary,6,'$')))<10000

--question d
select e.last_name, e.hire_date,e.salary from employees e


--question e
select e.last_name, coalesce(TO_CHAR(e.commission_pct), 'No Commission') as COMM from employees e

--question f
select  Max(e.salary) "Maximum", MIN(e.salary) "Minimum", SUM(e.salary) "Sum", ROUND(AVG(e.salary)) "Average" 
from employees e

--chapter 8 Procedure

/*
c?u trúc c?a store procedure
create (or replace) PROCEDURE nameProcedure(
    param1 IN datatype,
    param2 OUT datatype,
    param3 INOUT datatype
) 
IS
    Khai báo bi?n
Begin
    Logic
Exception when others then
    Error
END nameProcedure;

*/

create procedure demo
is
begin
dbms_output.put_line('HELLO WORLD');
END demo;
drop procedure empoo
exec empoo
--display employee name by id
create or replace procedure empoo(v_empid in employees.employee_id%type)
is
    v_last employees.last_name%TYPE;
    v_first employees.first_name%TYPE;
begin
select first_name , last_name into v_first, v_last  from employees 
where employee_id = v_empid;
DBMS_OUTPUT.PUT_LINE('Employee Name: ' || v_first || ' ' || v_last);
exception when others then
dbms_output.put_line('K');
end empoo;
exec empoo(200)

--display salary by empid
create or replace procedure salaryEmp(
    v_empid in employees.employee_id%TYPE,
    v_sal out employees.salary%TYPE
)
is
    v_last employees.last_name%TYPE;
begin
select last_name, salary into v_last, v_sal 
from employees
where employees.employee_id = v_empid;
dbms_output.put_line('Employee Name: ' || v_last || ', ' || 'Salary: ' || v_sal);
exception when others then
dbms_output.put_line('Not found');
end salaryEmp;
    exec salaryEmp(100, :v_sal)
    
--
create or replace procedure emp_get(
    c_emp out SYS_REFCURSOR
)
is
begin
open c_emp for
select * from employees a
order by a.first_name;
end;

--create procedure
create or replace procedure add_customer(
v_cusid in customer.customer_id%TYPE,
v_cusname in customer.full_name%TYPE,
v_cusphone in customer.phone_number%type,
v_gender in customer.gender%type,
v_email in customer.email%type
)
is 
    v_count number;
begin

select  count(*) into v_count from customer
where customer.customer_id = v_cusid;
if v_count > 0 then
dbms_output.put_line('Trùng id');
return;
end if;

select count(*) into v_count from customer
where customer.phone_number = v_cusphone;
if v_count > 0 then 
dbms_output.put_line('Trùng phone');
return;
end if;

select count(*) into v_count from customer
where customer.email = v_email;
if v_count > 0 then 
dbms_output.put_line('Trùng email');
return;
end if;
insert into customer(customer_id, full_name, phone_number,gender,email)
values (v_cusid,v_cusname,v_cusphone,v_gender,v_email);
dbms_output.put_line('Thêm thành công');
exception when others then
dbms_output.put_line('L?i: ' || SQLCODE || ' - ' || SQLERRM);
end;

exec add_customer(7,'FFF','023',2,'gu');
select * from customer
alter table customer  modify (partition null);

-----Practice chap8
--question a
select * from employees
create or replace procedure emp_insert(
    v_empid in employees.employee_id%TYPE,
    v_first in employees.first_name%TYPE,
    v_last in employees.last_name%TYPE,
    v_email in employees.email%TYPE,
    v_phone in employees.phone_number%TYPE,
    v_hiredate in employees.hire_date%TYPE,
    v_jobid in employees.job_id%TYPE,
    v_sal in employees.salary%TYPE,
    v_comm in employees.commission_pct%TYPE,
    v_managerid in employees.manager_id%TYPE,
    v_depid in employees.department_id%TYPE
)
is
    v_checkvalid number;
begin
--check id
select count(*) into v_checkvalid from employees where employees.employee_id = v_empid;
if v_checkvalid > 0 then 
dbms_output.put_line('Trùng Id');
return;
end if;
--check email
select count(*) into v_checkvalid from employees where employees.email = v_email;
if v_checkvalid > 0 then 
dbms_output.put_line('Trùng email');
return;
end if;
--check phone
select count(*) into v_checkvalid from employees where employees.phone_number = v_phone;
if v_checkvalid > 0 then 
dbms_output.put_line('Trùng sdt');
return;
end if;
--insert
Insert into employees e (e.employee_id, e.first_name, e.last_name,e.email, e.phone_number,e.hire_date,e.job_id, e.salary, e.commission_pct,e.manager_id,e.department_id)
values (v_empid,v_first,v_last,v_email,v_phone,v_hiredate,v_jobid,v_sal,v_comm,v_managerid,v_depid);
dbms_output.put_line('Thêm thành công');
exception when others then
dbms_output.put_line('L?i: ' || SQLCODE || ' - ' || SQLERRM);
end;

exec emp_insert(1000,'VHA','VHA','VHA','0967115300',To_date('17/06/1987', 'DD-MM-YYYY'),'AD_PRES',240000,null,null,90);
select * from employees 
where employees.employee_id = 1000

--update procedure
select * from customer
create or replace procedure update_customer(
    v_cusid in customer.customer_id%TYPE,
    v_name in customer.full_name%TYPE,
    v_phone in customer.phone_number%Type,
    v_gender in customer.gender%TYPE,
    v_email in customer.email%type
)
is
    v_count number;
begin
--check sdt
select count(*)into v_count from customer
where customer.phone_number = v_phone
    and customer_id <> v_cusid;
if v_count > 0 then
dbms_output.put_line('Trùng sdt');
return;
end if;
--check email
select count(*)into v_count from customer
where customer.email = v_email
    and customer_id <> v_cusid;
if v_count > 0 then
dbms_output.put_line('Trùng email');
return;
end if;
--update
    Update customer
    set
    customer.full_name = v_name,
    customer.phone_number = v_phone,
    customer.gender = v_gender,
    customer.email = v_email
    where customer.customer_id = v_cusid;
    dbms_output.put_line('c?p nh?t thành công');
    exception when others then
    dbms_output.put_line('L?i: ' || SQLCODE || ' - ' || SQLERRM);
end update_customer;

exec update_customer(6,'VHAAA','0987654135',1,'VHAAA');
select * from customer where customer_id = 6

--question b
create or replace procedure update_phone_emp(
    v_empid in employees.employee_id%TYPE,
    v_phone in employees.phone_number%type

)

is
    v_checkvalid number;
begin
--check phone
select count(*) into v_checkvalid from employees
where employees.phone_number = v_phone
    and employees.employee_id <> v_empid;
if v_checkvalid > 0 then 
dbms_output.put_line('Trùng sdt');
return;
end if;

update employees
set
employees.phone_number = v_phone
where employees.phone_number = v_empid;
dbms_output.put_line('C?p nh?t thành công');
exception when others then
dbms_output.put_line('L?i:' || SQLCODE || '' || SQLERRM);
end;

select e.employee_id ,e.last_name, e.phone_number from employees e
where e.employee_id = 1000
exec update_phone_emp(1000,'0961832618');

--question c
select * from departments
create or replace procedure insert_department(
    v_depid in departments.department_id%TYPE,
    v_depname in departments.department_name%TYPE,
    v_managerid in departments.manager_id%TYPE,
    v_location in departments.location_id%type
)
is
    v_checkvalid number;
begin
--check Id
select count(*) into v_checkvalid from departments
where departments.department_id = v_depid;
if v_checkvalid > 0 then 
dbms_output.put_line('Trùng Id');
return;
end if;
--check name
select count(*) into v_checkvalid from departments
where departments.department_name = v_depname;
if v_checkvalid > 0 then 
dbms_output.put_line('Trùng tên department');
return;
end if;
insert into departments (department_id,department_name,manager_id,location_id)
    values (v_depid,v_depname,v_managerid,v_location);
dbms_output.put_line('Thêm thành công');
exception when others then 
dbms_output.put_line('SQL: ' || SQLCODE || '' || SQLERRM);
end;

exec insert_department(1000, 'VHA DEPARTMENT', null, null)

--question d
create or replace procedure update_deparment(
    v_depid in departments.department_id%TYPE,
    v_depname in departments.department_name%TYPE,
    v_managerid in departments.manager_id%TYPE,
    v_location in departments.location_id%TYPE
)
is
    v_checkvalid number;
begin
--cehck id
    select count(*) into v_checkvalid from departments
    where departments.department_id = v_depid
        and departments.department_id <> v_depid;
    if v_checkvalid > 0 then
    dbms_output.put_line('Trùng id');
    return;
    end if;
--check name
select count(*) into v_checkvalid from departments
    where departments.department_name = v_depname
        and departments.department_id <> v_depid;
    if v_checkvalid > 0 then
    dbms_output.put_line('Trùng tên department');
    return;
    end if;
--check existing managerid
select count(*) into v_checkvalid from employees a 
join departments b on a.department_id = b.department_id
where a.employee_id = v_managerid;
if v_checkvalid < 0 then
dbms_output.put_line('Không có managerId');
return;
end if;
--update
    update departments
    set
    departments.department_name = v_depname,
    departments.manager_id = v_managerid,
    departments.location_id = v_location
    where departments.department_id = v_depid;
    dbms_output.put_line('C?p nh?t thành công');
    
    exception when others then
    dbms_output.put_line('SQL:' || SQLCODE || '' || SQLERRM);
end;
select * from departments where departments.department_id = 100
select * from employees where employees.employee_id = 10000
exec update_deparment(100,'VHA DEPARTMENT', 1222,100)

savepoint aa


--delete procedure
create or replace procedure delete_emp(
    v_empid in employees.employee_id%type
)
is
begin

update employees
set 
manager_id = null
where employees.manager_id = v_empid;

delete from employees
where employees.employee_id = v_empid;
dbms_output.put_line('Xóa thành công');
exception when others then
dbms_output.put_line('SQL: ' || SQLCODE || '' || SQLERRM);

end;
select * from employees

--update
create or replace procedure assign_emp_manager(
    v_empid in employees.employee_id%TYPE,
    v_managerid in employees.manager_id%type
)
is
begin
    update employees
    set 
    employees.manager_id = v_managerid
    where employees.employee_id = v_empid;
    dbms_output.put_line('C?p nh?t thành công');
    exception when others then
    dbms_output.put_line('SQL: ' || SQLCODE || '' || SQLERRM);
    
end;

exec assign_emp_manager(1001,1000)
exec emp_insert(1004,'Vi?t','Hà','mm@g4ail.cm', '01474302', to_date('03/04/2025', 'DD-MM-YYYY'), 'AD_PRES',23454,null,null,90)
exec delete_emp(1000)

--cursor d?c nhi?u dòng d? li?u
create or replace procedure increase_salary_emps(
    v_depid in employees.department_id%TYPE
)
as 
    cursor c_emp is
        select e.employee_id, e.last_name, e.salary from employees e
        where e.department_id = v_depid;
        
    v_empid employees.employee_id%TYPE;   
    v_name employees.last_name%TYPE;
    v_sal employees.salary%TYPE;
    
begin
    open c_emp;  
    loop
    fetch c_emp into v_empid, v_name, v_sal;
    exit when c_emp%notfound;
    
    update employees
    set
    employees.salary = v_sal*1.1
    where employees.employee_id = v_empid;
    dbms_output.put_line('Name: ' || v_name || 'new salary' || v_sal);
    end loop;
    dbms_output.put_line('c?p nh?t luong thành công');
    exception when others then
    dbms_output.put_line('SQL:' || SQLCODE || '' || SQLERRM);
    close c_emp;
end;

select * from employees
where employees.department_id = 90

exec increase_salary_emps(90)
SET SERVEROUTPUT ON;

--cursor out sys_refcursor
create or replace procedure get_emp_by_depart(
    v_manager in employees.manager_id%TYPE,
    v_cur out SYS_REFCURSOR
)
as
begin
    open v_cur for
    select e.employee_id, e.last_name, e.manager_id 
    from employees e
    where e.manager_id = v_manager;
end;


--
create or replace procedure get_emp_by_name(
    p_name in employees.last_name%type
)
as
    
cursor c_name is
    select e.employee_id, e.last_name from employees e
    where e.last_name = p_name;

    v_empid employees.employee_id%TYPE;
    v_namea employees.last_name%TYPE;
begin
    open c_name;
    loop
        fetch c_name into v_empid, v_namea;
        exit when c_name%notfound; 
        dbms_output.put_line('Id:' || v_empid || ' Name: ' || v_namea);
    end loop;
    close c_name;
end;

exec get_emp_by_name('Hà')
--
select * from customer

create table emp_audit(
log_id number generated as identity,
    emp_id number,
    action varchar2(20),
    action_date date

);

create or replace trigger emp_noti
AFTER INSERT  
ON employees
FOR EACH row
begin
INSERT INTO emp_audit(emp_id, action, action_date)
values (:NEW.employee_id, 'Insert',sysdate);
END;
drop trigger emp_noti
select * from emp_audit

create or replace trigger emp_noti_t
after insert or update or delete 
on employees
for each row
begin
if inserting then
    Insert into emp_audit(emp_id, action, action_date)
    values (:NEW.employee_id, 'Insert', sysdate);
elsif updating then
    Insert into emp_audit(emp_id, action, action_date)
    values (:OLD.employee_id,'Update',sysdate);
elsif deleting then 
    insert into emp_audit(emp_id, action, action_date)
    values (:OLD.employee_id, 'Delete', sysdate);
end if;
end;

exec delete_emp(1004)
exec emp_insert(emp_insert_seq.NEXTVAL,'Vi?t','Hà','mm@33ail.cm', '0137302', to_date('03/04/2025', 'DD-MM-YYYY'), 'AD_PRES',23454,null,null,90)

create sequence emp_insert_seq
    increment by 1
    start with 1000
    maxvalue 10000
    nocache
    nocycle;
    
    savepoint aaa
    
--udt table
select * from customer
create or replace Type udt_cus as object(
    id varchar2(5 byte),
    namee varchar2(20 byte),
    phone varchar2(20 byte)

);
drop type udt_cus_table
create or replace type udt_cus_table as table of udt_cus;

create or replace procedure get_cus(
c_cus out udt_cus_table) is

begin
    select udt_cus(c.customer_id,c.full_name,c.phone_number)
    bulk collect into c_cus
    from customer c;
end;

