--drop database QLCuocDT 
create database QLCuocDT
go
use QLCuocDT

create table SIM
(
	SIMID int identity(1,1) primary key,
	TenSim nvarchar(20) not null,
	SDT varchar(20) not null,
	Flag bit not null
)
create table KhachHang
(
	KhachHangID int identity(1,1) primary key,
	TenKH nvarchar(20) not null,
	CMND varchar(20) not null,
	NgheNghiep nvarchar(20) not null,
	ChucVu nvarchar(20) not null,
	DiaChi nvarchar(100) not null,
	Flag bit not null
)

create table HoaDonDangKy
(
	HoaDonDangKyID int identity(1,1) primary key,
	KhachHangID int not null,
	SIMID int not null,
	NgayDK datetime not null,
	ChiPhiDK INT not null,
	TinhTrangThanhToan bit not null,
	Flag bit not null,
	FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
	FOREIGN KEY (SIMID) REFERENCES SIM(SIMID)	
)
create table HoaDonTinhCuoc
(
	HoaDonTinhCuocID int identity(1,1) primary key,
	KhachHangID int not null,
	NgayBD datetime not null,
	NgayKT datetime not null,
	CuocThueBao int default 50000 not null, -- 50 000 VNĐ
	ThanhTien int not null, -- =Tổng (*)
	TongTien int not null, -- =CuocThueBao+ThanhTien
	Flag bit not null,
	FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)

)
create table ChitietHDTC
(
	ChitietHDTCID int identity(1,1) primary key,
	HoaDonTinhCuocID int not null,
	SoPhutSD int not null,
	GiaCuoc int not null,
	ThanhTien int not null, -- = SoPhutSD*GiaCuoc
	Flag bit not null,
	FOREIGN KEY (HoaDonTinhCuocID) REFERENCES HoaDonTinhCuoc(HoaDonTinhCuocID)	
)	
create table GiaCuoc
(
	GiaCuocID int identity(1,1) primary key,
	GioBD varchar(20),
	GioKT varchar(20),
	GiaTien int,
	Flag bit
)