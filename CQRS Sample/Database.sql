-- database QLSV
set dateformat DMY
create table SINHVIEN
(
	MSSV nvarchar(10) primary key not null,
	HoTen nvarchar(100),
	NgaySinh datetime
)
select * from SINHVIEN
select * from SINHVIEN where MSSV like '%%' 
SELECT MSSV, HoTen, NgaySinh FROM SINHVIEN
drop table SINHVIEN