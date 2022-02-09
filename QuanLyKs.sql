use  master	
go

 create database  FinalQLyKs
 go 

 use  FinalQLyKs
 go
 
 create table Tbl_KhachHang
 (
	MAKHACHHANG varchar(10) primary key,
	TENKHACHHANG nvarchar(30),
	DIACHI nvarchar (50),
	GIOTINH nvarchar(30),
	SDT char(12),
	CMND varchar(30),
	NGAYDEN date ,
	NGAYDI date,
	MAPHONG nvarchar(20),
	QUOCTICH nvarchar(30),
	foreign key (MAPHONG) references Tbl_Phong(MAPHONG),
 )

 create table Tbl_LoaiPhong
 (
 MALOAIPHONG nvarchar(20) primary key,
 TENLOAIPHONG nvarchar(30),
 GIAPHONG int,

 )

 create table  Tbl_Phong
 (
 MAPHONG nvarchar(20) primary key,
 TENPHONG nvarchar(30),
 TINHTRANG nvarchar(30),
 MALOAIPHONG nvarchar(20),
 foreign key (MALOAIPHONG)  references Tbl_LoaiPhong(MALOAIPHONG),
 )

 create table Tbl_HoaDon
 (
 MAHOADON varchar(20) primary key,
 MAKHACHHANG varchar(10),
 DONVI varchar(10),
 foreign key (MAKHACHHANG) references Tbl_KhachHang(MAKHACHHANG)
 )

 
 --KHACHHANG
 --MAKHACHHANG TENKHACHHANG	DIACHI 	GIOTINH SDT CMND QUOCTICH
insert into Tbl_KhachHang values ('KH01',N'Đặng Tuấn Anh','Q8',N'Nam','034654065','2123454',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M102','VietNam')
insert into Tbl_KhachHang  values('KH02',N'Phạm Gia Minh','Q2',N'Nam','038798065','2154147',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M101','VietNam')
insert into Tbl_KhachHang  values('KH03',N'Phạm Xuân Hòa','Q3',N'Nữ','91178065','24897127',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M104','VietNam')
insert into Tbl_KhachHang  values('KH04',N'Đỗ Hoàng Mỹ','Q4',N'Nam','03478714','89898565',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M105','VietNam')
insert into Tbl_KhachHang  values('KH05',N'	Đàm Yến Nhi','Q5',N'Nam','01567125','7895642',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M106','VietNam')
insert into Tbl_KhachHang  values('KH06',N'	Nguyễn Công Thành','Q9',N'Nam','45781655','54981312',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M107','VietNam')
insert into Tbl_KhachHang  values('KH07',N'	Đặng Huyền Thi','Q1',N'Nam','56741871','06546216',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M103','VietNam')

 --LoaiPhong
 --MAPHONG TENLOAIPHONG
 insert into Tbl_LoaiPhong values ('PL1',N'Thường Đơn',1000000)
 insert into Tbl_LoaiPhong values ('PL2',N'Thường Đôi',1500000)
 insert into Tbl_LoaiPhong values ('PL3',N'Vip Đơn',2000000)
 insert into Tbl_LoaiPhong values ('PL4',N'Vip Đôi',3000000)

 --Phong
 --MAPHONG TENPHONG TINHTRANG MALOAIPHONG GIAPHONG DONVI
 -- MAPHONG 
 --TENPHONG 
 --TINHTRANG 
 --MALOAIPHONG 
 --MAKHACHHANG
 --NGAYDEN
 --NGAYDI
 insert into Tbl_Phong values ('M102',N'Phòng 1',N'Trống','PL1')
 insert into Tbl_Phong values ('M101',N'Phòng 2',N'Trống','PL2')
 insert into Tbl_Phong values ('M103',N'Phòng 3',N'Trống','PL3')
 insert into Tbl_Phong values ('M104',N'Phòng 4',N'Trống','PL4')
 insert into Tbl_Phong values ('M105',N'Phòng 5',N'Trống','PL4')
 insert into Tbl_Phong values ('M106',N'Phòng 6',N'Trống','PL4')
 insert into Tbl_Phong values ('M107',N'Phòng 7',N'Trống','PL4')


 --PhieuDK
 --MAPHIEUDK MAKHACHHANG NGAYDEN  NGAYDI MAPHONG TRATRUOC  DONVI 
--insert into Tbl_PhieuDK values ('PDK1','KH01',CONVERT(date,'01/08/2020',103),CONVERT(date,'30/08/2020',103),'M107','10000000',N'VNĐ')
--insert into Tbl_PhieuDK values ('PDK2','KH02',CONVERT(date,'01/08/2020',103),CONVERT(date,'20/08/2020',103),'M102','50000000',N'VNĐ')
--insert into Tbl_PhieuDK values ('PDK3','KH04',CONVERT(date,'01/08/2020',103),CONVERT(date,'05/08/2020',103),'M101','20000000',N'VNĐ')
--insert into Tbl_PhieuDK values ('PDK5','KH03',CONVERT(date,'01/08/2020',103),CONVERT(date,'10/08/2020',103),'M103','10000000',N'VNĐ') 
--insert into Tbl_PhieuDK values ('PDK6','KH05',CONVERT(date,'01/08/2020',103),CONVERT(date,'8/08/2020',103),'M104','30000000',N'VNĐ')
--insert into Tbl_PhieuDK values ('PDK7','KH06',CONVERT(date,'01/08/2020',103),CONVERT(date,'15/08/2020',103),'M105','60000000',N'VNĐ')
--insert into Tbl_PhieuDK values ('PDK4','KH07',CONVERT(date,'01/08/2020',103),CONVERT(date,'23/08/2020',103),'M106','70000000',N'VNĐ')
 

select * from Tbl_LoaiPhong



select Tbl_Phong.MAPHONG,Tbl_Phong.TENPHONG,Tbl_Phong.TINHTRANG ,Tbl_KhachHang.TENKHACHHANG,Tbl_KhachHang.DIACHI,Tbl_KhachHang.CMND,Tbl_KhachHang.NGAYDEN,Tbl_KhachHang.NGAYDI,Tbl_Phong.MALOAIPHONG
from Tbl_Phong
join Tbl_KhachHang on Tbl_Phong.MAPHONG = Tbl_KhachHang.MAPHONG



select DATEDIFF(day,Tbl_KhachHang.NGAYDEN,Tbl_KhachHang.NGAYDI ) from Tbl_KhachHang
 * Tbl_LoaiPhong.GIAPHONG 
                            from  Tbl_Phong Inner  Join  Tbl_LoaiPhong
                            on  Tbl_Phong.MALOAIPHONG = Tbl_LoaiPhong.MALOAIPHONG
                             WHERE Tbl_Phong.MAPHONG='M101'
	delete from Tbl_KhachHang where MAKHACHHANG='KH06'					 						
select * from Tbl_KhachHang						 
select * from Tbl_Phong									 
select * from Tbl_LoaiPhong
select * from Tbl_HoaDon

select Tbl_LoaiPhong.GIAPHONG from Tbl_Phong
join Tbl_LoaiPhong on Tbl_Phong.MALOAIPHONG = Tbl_LoaiPhong.MALOAIPHONG
where Tbl_Phong.MAPHONG = 'M102'
select Tbl_LoaiPhong.GIAPHONG from Tbl_Phong
                                join Tbl_LoaiPhong on Tbl_Phong.MALOAIPHONG = Tbl_LoaiPhong.MALOAIPHONG
                                where Tbl_Phong.MAPHONG ='M103'
--Duo chua ?
--Lay ra nhan voi cai Label nay 

