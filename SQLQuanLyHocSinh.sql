create database QuanLyHocSinh
go

use QuanLyHocSinh
go

create table HOCSINH
(
	MaHS		char(5) primary key,
	HoTen		nvarchar(50) not null,
	QueQuan		nvarchar(50) not null,
	Tuoi		tinyint
)
go



