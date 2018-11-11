--drop database QLCuocDT 
create database QLCuocDT
go
use QLCuocDT

create table SIM
(
	MaSIM int identity(1,1) primary key,
	TenSim nvarchar(20),
	SDT varchar(20),
	Flag bit
)
create table KhachHang
(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(20),
	CMND varchar(20),
	NgheNghiep nvarchar(20),
	ChucVu nvarchar(20),
	DiaChi nvarchar(100),
	Flag bit
)

create table HoaDonDangKy
(
	MaKH int,
	MaSIM int,
	NgayDK datetime,
	ChiPhiDK INT,
	TinhTrangThanhToan bit,
	Flag bit,
	FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
	FOREIGN KEY (MaSIM) REFERENCES SIM(MaSIM)	
)
create table HoaDonTinhCuoc
(
	MaHD int identity(1,1) primary key,
	MaKH int,
	NgayBD datetime,
	NgayKT datetime,
	CuocThueBao int, -- 50 000 VNĐ
	ThanhTien int, -- =Tổng (*)
	TongTien int, -- =CuocThueBao+ThanhTien
	Flag bit,
	FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)

)
create table ChitietHDTC
(
	MaHD int,
	SoPhutSD int,
	GiaCuoc int,
	ThanhTien int, -- = SoPhutSD*GiaCuoc
	Flag bit,
	FOREIGN KEY (MaHD) REFERENCES HoaDonTinhCuoc(MaHD)	
)	
create table GiaCuoc
(
	GioBD varchar(20),
	GioKT varchar(20),
	GiaTien int,
	Flag bit
)