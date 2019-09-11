

--Họ và tên : Nguyễn Văn Vương
--MSSV: 1510289
--Lớp: CTK39


-----------------------------------Tạo lập CDSL--------------------------create database LAB15_QuanLyChuyenBay
go
use LAB15_QuanLyChuyenBay
go
--drop database LAB15_QuanLyChuyenBay
--------------Xóa các bảng đã tồn tại trong CSDL---------------------------
Drop table PhanCong
go
Drop table DatCho
go
Drop table LichBay
go
Drop table MayBay
go
Drop table ChuyenBay 
go
Drop table KhaNang
go
Drop table  LoaiMB
go
Drop table KhachHang
go
Drop table  NhanVien 
go
-------------Tạo lập cấu trúc bảng -------------------------------
Create table KhachHang
(
	MaKH nchar(15) primary key,
	Ten nvarchar(15),
	DChi nvarchar(50),
	DT nchar (12)
)
go
Create table ChuyenBay 
(	
	MaCB nchar(4) primary key,
	SBDI  nchar(4),
	SBDEN nchar(4),
	GioDi time,
	GioDen time
)
go
Create table LoaiMB
(
	MaLoai NCHAR(15) primary key,
	HangSX nchar(15)
)
go
Create table MayBay
(
	SoHieu int,
	MaLoai nchar(15) references LoaiMB(MaLoai),
	primary key(SoHieu,MaLoai)
)
go
Create table LichBay
(
	NgayDi datetime,
	MaCB nchar (4) references ChuyenBay(MaCB),
	SoHieu int ,
	MaLoai nchar(15) ,
	primary key (NgayDi,MaCB),
	foreign key (SoHieu, MaLoai) references MayBay(SoHieu, MaLoai)
)
go
Create table DatCho
(
	MaKH nchar(15) references KhachHang(MaKH),
	NgayDi datetime ,
	MaCB nchar (4) ,
	foreign key (NgayDi,MaCB) references LichBay (NgayDi,MaCB)
)
go


Create table NhanVien 
(
	MaNV nchar(15) primary key,
	Ten nvarchar(15),
	DChi nchar(50),
	DT nchar(12),
	Luong int,
	LoaiNV BIT
)
go



Create TABLE KhaNang
(
	MaNV nchar (15) references NhanVien(MaNV),
	MaLoai nchar(15) references LoaiMB(MaLoai)
	primary key (MaNV,MaLoai)
)

go

Create table PhanCong
(
	MaNV nchar (15) references NhanVien(MaNV),
	NgayDi datetime ,
	MaCB nchar (4) ,
	primary key (MaNV, NgayDi, MaCB),
	foreign key (NgayDi,MaCB) references LichBay (NgayDi,MaCB)
)



-------------------------------Nhập dữ liệu chi bảng NHAN VIEN------------------------------
delete from NhanVien
insert into NhanVien values ('1006','Chi','12/6 Nguyen Kiem','8120012','150000',0)
insert into NhanVien values('1005','Giao','65 Nguyen Thai Son','8324467','500000',0)
insert into NhanVien values('1001','Huong','8 Dien Bien PHu','8330733','500000',1)
insert into NhanVien values('1002','Phong','1 Ly Thuong Kiet','8308117','450000',1)
insert into NhanVien values('1004','Phuong','351 Lac Long Quan','8238155','250000',0)
insert into NhanVien values('1003','Quang','78 Truong Dinh','8234461','350000',1)
insert into NhanVien values('1007','Tam','36 Nguyen Van Cu','8458188','500000',0)
select *from NhanVien
-------------------------------Nhập dữ liệu chi bảng KHACHHANG------------------------------
delete from KhachHang
insert into KhachHang values('0009','Nga','223 Nguyen Trai','8932320')
insert into KhachHang values('0101','Anh','567 Tran Phu','8826729')
insert into KhachHang values('0045','Thu','285 Le Loi','8932203')
insert into KhachHang values('0012','Ha','435 Quang Trung','8932232')
insert into KhachHang values('0238','Hung','456 Pasteur','9812101')
insert into KhachHang values('0397','Thanh','234 Le Van Si','8952943')
insert into KhachHang values('0582','Mai','789 Nguyen Du','')
insert into KhachHang values('0934','Minh','678 Lê Lai','')
insert into KhachHang values('0091','Hai','345 Hung Vuong','8893223')
insert into KhachHang values('0314','Phuong','395 Vo Van Tan','8232320')
insert into KhachHang values('0613','Vu','348 CMT8','8343232')
insert into KhachHang values('0586','Son','123 Bach Dang','8556223')
insert into KhachHang values('0422','Tien','75 Nguyen Thong','8332222')
select *from KhachHang 
---------------------------Nhập dữ liệu cho bảng máy bay-----------------------------
delete from MayBay
insert into LoaiMB values('A310','Airbus')
insert into LoaiMB values('A320','Airbus')
insert into LoaiMB values('A330','Airbus')
insert into LoaiMB values('A340','Airbus')
insert into LoaiMB values('B727','Boeing')
insert into LoaiMB values('B747','Boeing')
insert into LoaiMB values('B757','Boeing')
insert into LoaiMB values('DC9','MD')
insert into LoaiMB values('DC10','MD')
select *from LoaiMB

--------------------thêm dữ liệu cho bảng khả năng--------------------
delete from KhaNang
insert into KhaNang values('1001','B727')
insert into KhaNang values('1001','B747')
insert into KhaNang values('1001','DC9')
insert into KhaNang values('1001','DC10')
insert into KhaNang values('1002','A320')
insert into KhaNang values('1002','A340')
insert into KhaNang values('1002','B757')
insert into KhaNang values('1002','DC9')
insert into KhaNang values('1003','A310')
insert into KhaNang values('1003','DC9')
select *from KhaNang

-------------------Thêm dữ liệu vào bảng chuyến bay----------------------
delete from ChuyenBay
insert into ChuyenBay values('100','SLC','BOS','08:00','17:50')
insert into ChuyenBay values('112','DCA','DEN','14:00','18:07')
insert into ChuyenBay values('121','STL','SLC','07:00','09:13')
insert into ChuyenBay values('122','STL','YYV','08:30','10:19')
insert into ChuyenBay values('206','DFW','STL','09:00','11:40')
insert into ChuyenBay values('330','JFK','YYV','16:00','18:53')
insert into ChuyenBay values('334','ORD','MIA','12:00','14:14')
insert into ChuyenBay values('335','MIA','ORD','15:00','17:14')
insert into ChuyenBay values('336','ORD','MIA','18:00','20:14')
insert into ChuyenBay values('337','MIA','ORD','20:30','23:53')
insert into ChuyenBay values('394','DFW','MIA','19:00','21:30')
insert into ChuyenBay values('395','MIA','DFW','21:00','23:43')
insert into ChuyenBay values('449','CDG','DEN','10:00','19:29')
insert into ChuyenBay values('930','YYV','DCA','13:00','16:10')
insert into ChuyenBay values('931','DCA','YYV','17:00','18:10')
insert into ChuyenBay values('932','DCA','YYV','18:00','19:10')
insert into ChuyenBay values('991','BOS','ORD','17:00','18:22')
select *from ChuyenBay


----------------------Nhập dữ liệu cho bảng máy bay-----------------------
delete from MayBay
insert into MayBay values('10','B747')
insert into MayBay values('11','B727')
insert into MayBay values('13','B727')
insert into MayBay values('13','B747')
insert into MayBay values('21','DC10')
insert into MayBay values('21','DC9')
insert into MayBay values('22','B757')
insert into MayBay values('22','DC9')
insert into MayBay values('23','DC9')
insert into MayBay values('24','DC9')
insert into MayBay values('70','A310')
insert into MayBay values('80','A310')
insert into MayBay values('93','B757')
select *from MayBay

--LICHBAY--
delete from LichBay
set dateformat mdy
insert into LichBay values('11/01/2000','100','80','A310')
insert into LichBay values('11/01/2000','112','21','DC10')
insert into LichBay values('11/01/2000','206','22','DC9')
insert into LichBay values('11/01/2000','334','10','B747')
insert into LichBay values('11/01/2000','395','23','DC9')
insert into LichBay values('11/01/2000','991','22','B757')
insert into LichBay values('11/01/2000','337','10','B747')
insert into LichBay values('10/31/2000','100','11','B727')
insert into LichBay values('10/31/2000','112','11','B727')
insert into LichBay values('10/31/2000','206','13','B727')
insert into LichBay values('10/31/2000','334','10','B747')
insert into LichBay values('10/31/2000','335','10','B747')
insert into LichBay values('10/31/2000','337','24','DC9')
insert into LichBay values('10/31/2000','449','70','A310')
----thêm dữ liệu thử phép chia

insert into LichBay values('11/27/2001','100','10','B747')
insert into LichBay values('11/27/2010','100','10','B747')
insert into LichBay values('11/14/2002','100','93','B757')
insert into LichBay values('12/11/2003','112','10','B747')

-----
select *from LichBay

--DATCHO--
delete from DatCho
set dateformat mdy
insert into DatCho values('0009','11/01/2000','100')
insert into DatCho values('0009','10/31/2000','449')
insert into DatCho values('0045','11/01/2000','991')
insert into DatCho values('0012','10/31/2000','206')
insert into DatCho values('0238','10/31/2000','334')
insert into DatCho values('0582','11/01/2000','991')
insert into DatCho values('0091','11/01/2000','100')
insert into DatCho values('0314','10/31/2000','449')
insert into DatCho values('0613','11/01/2000','100')
insert into DatCho values('0586','11/01/2000','991')
insert into DatCho values('0586','10/31/2000','100')
insert into DatCho values('0422','10/31/2000','449')
select *from DatCho

--PHANCONG--
delete from PhanCong
set dateformat mdy
insert into PhanCong values('1001','11/01/2000','100')
insert into PhanCong values('1001','10/31/2000','100')
insert into PhanCong values('1002','11/01/2000','100')
insert into PhanCong values('1002','10/31/2000','100')
insert into PhanCong values('1003','10/31/2000','100')
insert into PhanCong values('1003','10/31/2000','337')
insert into PhanCong values('1004','10/31/2000','100')
insert into PhanCong values('1004','10/31/2000','337')
insert into PhanCong values('1005','10/31/2000','337')
insert into PhanCong values('1006','11/01/2000','991')
insert into PhanCong values('1006','10/31/2000','337')
insert into PhanCong values('1007','11/01/2000','112')
insert into PhanCong values('1007','11/01/2000','991')
insert into PhanCong values('1007','10/31/2000','206')
select *from PhanCong


------------------------------------------------------------------
------Câu 1: Tìm các phi công đã từng lái máy bay b747--------

select NhanVien.MaNV,NhanVien.Ten,NhanVien.DChi,NhanVien.DT
from PhanCong,NhanVien
where PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV=1 and PhanCong.MaCB in 
															(	select LichBay.MaCB
																from LichBay
																where LichBay.MaLoai='B747' and LichBay.NgayDi<getdate()
																group by MaCB
															)
-----Câu 2:Cho biết mã số và ngày đi của các chuyến bay xuất phát 
-----từ sân bay DCA trong khoảng thời gian từ 14h tới 18h-----

select a.MaCB,Convert(nvarchar(10),b.NgayDi,103) as Ngày_Đi
from ChuyenBay a,LichBay b
where a.MaCB=b.MaCB and ( DatePart(Hour,a.GioDi) between 14 and 18)and a.SBDI = 'DCA' 


-----Câu 3:Cho biết tên nhân viên được phân công trên chuyến bay có mã số 100 xuất phát từ sân bay SLC 
select  a.Ten
from NhanVien a,PhanCong b,LichBay c,ChuyenBay d
where a.MaNV=b.MaNV and b.NgayDi=c.NgayDi and c.MaCB=d.MaCB and b.MaCB in (select a.MaCB
																			from ChuyenBay a
																				where a.SBDI='SLC' and a.MaCB=100)
group by a.Ten


-------Câu 4:Cho biết số hiệu và mã loại máy bay đã từng xuất phát từ sân bay MIA

select a.SoHieu,a.MaLoai,a.MaCB
from LichBay a,ChuyenBay b
where a.MaCB=b.MaCB  and b.SBDI='MIA' and a.NgayDi<getdate()


------Câu 5:Cho biết mã chuyến bay,ngày đi,tên địa chỉ,điện thoại của tất cả các hành khách đi trên chuyến bay đó sắp xếp 
------theo thứ tự tăng dần của mã chuyến bay và ngày đi giảm dần

select a.MaCB,Convert(nvarchar(10),b.NgayDi,103),d.Ten,d.DChi,d.DT
from ChuyenBay a,LichBay b,DatCho c,KhachHang d
where a.MaCB=b.MaCB and b.MaCB = c.maCB and b.NgayDi=c.NgayDi and c.MaKH=d.MaKH
order by  a.MaCB ASC,b.NgayDi DESC

------Câu 6:Cho biết mã chuyến bay ,ngày đi cùng tên địa chỉ điện thoại của tất cả những nhân viên được phân công trên chuyến bay đó
------Tăng dần theo mã chuyển bay và giảm dần theo ngày đi

select d.MaCB,b.NgayDi,a.Ten,a.DChi,a.DT
from NhanVien a,PhanCong b,LichBay c,ChuyenBay d
where a.MaNV=b.MaNV and b.NgayDi=c.NgayDi and c.MaCB=d.MaCB
order by d.MaCB ASC,c.NgayDi DESC


--------Câu 7:Cho biết tên,mã nhân viên,mã chuyến bay và ngày đi của những phi công được phân công đáp xuống sân bay ORD
select distinct d.MaNV,d.Ten,c.MaCB,Convert(nvarchar(10),b.NgayDi,103) as NgayDi
from NhanVien d,PhanCong c,LichBay b,ChuyenBay a
where d.MaNV=c.MaNV and c.NgayDi=b.NgayDi and b.MaCB=a.MaCB and d.LoaiNV=1 and c.MaCB in (select h.MaCB
																						from ChuyenBay h
																						where h.SBDEN='ORD')


------Câu 8: Cho biết mã chuyến bay,ngày đi và tên phi công có mã 1001 được phân công vào chuyến bay đó
select distinct a.MaNV,a.Ten,Convert(nvarchar(10),b.NgayDi,103) as NgayDi
from NhanVien a,PhanCong b
where a.MaNV=b.MaNV  and a.MaNV='1001'

------CÂu 9:Cho biết thông tin những chuyến bay hạ cánh xuống "DEN",liệt kê giảm dần theo ngày đi và tăng dần theo sân bay đi
select a.MaCB,a.SBDI,a.SBDEN,Convert(nvarchar(10),b.NgayDi,103) as NgayDi,CONVERT(varchar(5), a.GioDi,108) as GioDi,CONVERT(varchar(5), a.GioDen,108) as GioDen
from ChuyenBay a,LichBay b
where a.MaCB=b.MaCB and a.SBDEN='DEN'
order by b.NgayDi DESC ,a.SBDI ASC



------Câu 10:Cho biết hãng sản xuất và mã máy bay và mã loại máy bay mà phi công không có khả năng bay

select distinct  a.MaLoai
from LoaiMB a,KhaNang b
where a.MaLoai not in (select distinct b.MaLoai
									from KhaNang b)





------Câu 11:Cho biết mã phi công,tên phi công đã láu chuyến may mã 100 ngày 11/1/2000
set dateformat mdy
select distinct a.MaNV,a.Ten
from NhanVien a,PhanCong b
where a.MaNV=b.MaNV and a.LoaiNV=1 and b.MaCB='100' and b.NgayDi= '11/01/2000'


--------Câu 12:Cho biết mã chuyến bay,mã nhân viên,tên nhân viên được phân công vào chuyến bay xuất phát vào lúc 20:30
-------tại sân bay MIA ngày 10/31/2000

select distinct PhanCong.MaNV,NhanVien.Ten,ChuyenBay.MaCB
from ChuyenBay,LichBay,PhanCong,NhanVien 
where LichBay.MaCB=ChuyenBay.MaCB and LichBay.MaCB=PhanCong.MaCB and PhanCong.MaNV=NhanVien.MaNV
 and ChuyenBay.SBDI='MIA' and ChuyenBay.GioDi='20:30'




----Câu 13:Cho biết thông tin về chuyeens bay  mà phi công Quang đã từng lái
select distinct c.MaLoai,e.HangSX,c.MaCB,c.SoHieu
from LichBay c,MayBay d,LoaiMB e
where c.MaLoai=d.MaLoai and d.MaLoai=e.MaLoai and c.MaCB in (select distinct  b.MaCB
																from NhanVien a,PhanCong b
																where a.MaNV=b.MaNV and a.Ten='Quang' and b.NgayDi<getdate()
																)
------Câu 14:Tên phi công chưa được phân lái chuyến nào


---=-=->Mọi phi công đều đã được phân công lái
select distinct a.Ten
from NhanVien a
where a.LoaiNV=1 and a.MaNV not in (select distinct b.MaNV 
										from PhanCong b)

--------Câu 15: Tên khách hàng đã đi máy bay hãng boing

select distinct KhachHang.MaKH,KhachHang.Ten
from LichBay ,MayBay ,LoaiMB,DatCho,KhachHang
where LoaiMB.MaLoai=MayBay.MaLoai and MayBay.SoHieu=LichBay.SoHieu and LichBay.MaCB=DatCho.MaCB and DatCho.MaKH=KhachHang.MaKH
 and LoaiMB.HangSX='Boeing' and LichBay.NgayDi<getdate();


 -------Câu 16:Cho biết các chuyến bay chỉ bay với mã hiệu là 10 và loại máy bay là B747

 select distinct ChuyenBay.MaCB,ChuyenBay.SBDI,ChuyenBay.SBDEN,ChuyenBay.GioDi,ChuyenBay.GioDen
 from LichBay,ChuyenBay
 where LichBay.MaCB=ChuyenBay.MaCB and LichBay.SoHieu=10 and LichBay.MaLoai='B747'



 -----------------------Gom Nhóm và Hàm
 ------Câu 17:Với mỗi sân bay đến,cho biết số lượng chuyến bay hạ cánh xuống sân bay đó,sắp tăng dần theo sân bay đến
 select distinct ChuyenBay.SBDEN,COUNT( ChuyenBay.SBDEN) as Số_Lần_hạ_cánh
 from ChuyenBay
  group by ChuyenBay.SBDEN
 order by ChuyenBay.SBDEN ASC



  ------Câu 18:Với mỗi sân bay xuất phát,cho biết số lượng chuyến bay cất cánh ở sân bay đó,sắp tăng dần theo sân bay xuất phát
  select ChuyenBay.SBDI,COUNT( ChuyenBay.SBDI) as Số_lần_cất_cánh
  from ChuyenBay
  group by ChuyenBay.SBDI
  order by ChuyenBay.SBDI



  ------Câu 19:Với mỗi san bay đi,cho biết số lượng chuyến bay xuất phát theo từng ngày
  select  ChuyenBay.SBDI,Convert(nvarchar(10),LichBay.NgayDi,103) as Ngày_đi, count( ChuyenBay.SBDI) as Số_Lần_cất_cánh
  from ChuyenBay,LichBay
  where ChuyenBay.MaCB=LichBay.MaCB
  group by ChuyenBay.SBDI,LichBay.NgayDi


  ------Câu 20:Với mỗi san bay đến,cho biết số lượng chuyến bay hạ cánh theo từng ngày
  select ChuyenBay.SBDEN,Convert(nvarchar(10), LichBay.NgayDi,103) as Ngày_đi,COUNT ( ChuyenBay.SBDEN ) as Số_lần_hạ_cánh
  from ChuyenBay,LichBay
  where ChuyenBay.MaCB=LichBay.MaCB
  group by ChuyenBay.SBDEN,LichBay.NgayDi


  -----Câu 21:Cho biết mã chuyến bay,ngày đi cùng số lượng nhân viên khoonbg phải phi công của chuyến bay đó
  
  select PhanCong.MaCB,Convert (nvarchar(10),PhanCong.NgayDi,103) as Ngày_đi,count ( PhanCong.MaNV) as Số_lượng_NV
  from PhanCong,NhanVien
  where PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV =0
  group by PhanCong.MaCB,PhanCong.NgayDi 


  -----Câu 22:số lượng máy bay xuất phát từ sân bay MIA vào ngày 11/01/2000
  ----->không có ngày 11/1/2000 trong cơ sở dữ liệu-->kết quả trả về rỗng
  set dateformat dmy
  select distinct ChuyenBay.MaCB,LichBay.NgayDi,ChuyenBay.SBDI,count (LichBay.Sohieu) as Số_lượng_máy_bay_xuất_phát
  from ChuyenBay,LichBay
  where ChuyenBay.MaCB=LichBay.MaCB and ChuyenBay.SBDI='MIA'  and LichBay.NgayDi='11/1/2000'
  group by ChuyenBay.MaCB,LichBay.NgayDi,ChuyenBay.SBDI
  ------>giả sử trường hợp là ngày 1/11/2000
  set dateformat dmy
  select distinct ChuyenBay.MaCB,LichBay.NgayDi,ChuyenBay.SBDI,count (LichBay.Sohieu) as Số_lượng_máy_bay_xuất_phát
  from ChuyenBay,LichBay
  where ChuyenBay.MaCB=LichBay.MaCB and ChuyenBay.SBDI='MIA'  and LichBay.NgayDi='1/11/2000'
  group by ChuyenBay.MaCB,LichBay.NgayDi,ChuyenBay.SBDI





  --------Câu 23:với mỗi chuyến bay,cho biết mã chuyến bay,ngày đi,số nhân viên được phân công trên chuyến bay đó
  --------Sắp xếp theo thứ tự giảm dần của số lượng

  select PhanCong.MaCB,PhanCong.NgayDi,COUNT (PhanCong.MaNV) as Số_nhân_viên_trên_máy_bay
  from PhanCong
	group by  PhanCong.MaCB,PhanCong.NgayDi
	order  by Số_nhân_viên_trên_máy_bay Desc




----------Câu 24: với mỗi chuyến bay,cho biết mã chuyến bay,ngày đi cùng với ố lượng hành khách đã đặt chỗ của chuyến bay đó
----------sắp xếp theo thứ tự giảm dần của số lượng
select DatCho.MaCB,count ( DatCho.MaKH) as Số_lượng_khách_hàng
from DatCho 
group by DatCho.MaCB
order by Số_lượng_khách_hàng Desc





---------Câu 25:Với mỗi chuyến bay,cho biết ngày đi,tổng lương của phi hành đoàn
---------Sắp tăng dần theo tổng lương
select PhanCong.MaCB,sum(NhanVien.Luong) as Tổng_lương_PHD
from PhanCong, NhanVien
where PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV=1
group by PhanCong.MaCB
order by Tổng_lương_PHD ASC




---------Câu 26:Cho biết lương trung bình của các nhân viên không phải phi công
select count(NhanVien.MaNV) as Số_NV_Thường, AVG(NhanVien.Luong) as Lương_TB
from NhanVien
where NhanVien.LoaiNV=0



--------Câu 27:Cho biết mức lương trung bình của các phi công
select count (NhanVien.MaNV) as Số_lượng_phi_hành_đoàn,AVG(NhanVien.Luong) as Lương_TB
from NhanVien
where NhanVien.LoaiNV=1




---------Câu 28:Với mỗi loại máy bay,cho biết số lượng chuyến bay đã bay trên loại máy bay đó hạ cánh xuống ORD
select LichBay.MaLoai,COUNT (ChuyenBay.MaCB) as Số_lần_hạ_cánh
from ChuyenBay ,LichBay
where ChuyenBay.MaCB=LichBay.MaCB and ChuyenBay.SBDEN='ORD'
group by LichBay.MaLoai



---------Câu 29:Cho biết sân bay đi và số chuyến bay có nhiều hơn 2 chuyến xuất phát trong khoảng 10-22h
select ChuyenBay.SBDI,COUNT(ChuyenBay.GioDi) as Số_lần_xuất_phát
from ChuyenBay
where (DATEPART(hour,ChuyenBay.GioDi)between 10 and 22)
group by ChuyenBay.SBDI
having COUNT(ChuyenBay.GioDi)>2;



------Câu 30:cho biết phi công được phân ít nhất 2 chuyến bay trong cùng một ngày
select PhanCong.NgayDi,PhanCong.MaNV,NhanVien.MaNV,NhanVien.Ten,count(PhanCong.MaCB) as Số_lần_bay_trong_1_Ngày
from PhanCong,NhanVien
where PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV=1
group by  PhanCong.NgayDi,PhanCong.MaNV,NhanVien.MaNV,NhanVien.Ten
having count(PhanCong.MaCB)>=2



------Câu 31:Cho biết mã và ngày đi của những chuyến bay có ít hơn 3 hành khách đặt chỗ
select ChuyenBay.MaCB,LichBay.NgayDi,count (DatCho.MaKH) as Số_hành_khách_đặt_chỗ
from ChuyenBay,LichBay,DatCho
where ChuyenBay.MaCB=LichBay.MaCB and LichBay.MaCB=DatCho.MaCB
group by ChuyenBay.MaCB,LichBay.NgayDi
having count (DatCho.MaKH)<3




------Câu 32:Cho biết số hiệu máy bay và loại máy bay mà phi công 1001 đã được phân công lái trên 2 lần
------>Kết quả trống vì nhân viên 1001 chỉ được giao lái 2 lần trên 2 loại máy bay khác nhau
select LichBay.SoHieu,LichBay.MaLoai,count(LichBay.MaCB) as Số_lần_lái
from LichBay
where LichBay.MaCB=(
					select distinct PhanCong.MaCB
					from LichBay,PhanCong
					where PhanCong.MaNV='1001')
group by LichBay.SoHieu,LichBay.MaLoai
having count(LichBay.MaCB)>2





-------Câu 33:Với mỗi hãng sản xuất ,cho biết số lượng máy bay họ đã sản xuất
select LoaiMB.HangSX,count( LoaiMB.MaLoai) as Số_lượng_máy_bay
from LoaiMB
group by LoaiMB.HangSX



--------Câu 34:Cho biết hãng sản xuất,mã loại,số hiệu của hãng máy bay được sử dụng nhiều nhất

select LoaiMB.HangSX,LoaiMB.MaLoai,MayBay.SoHieu,COUNT(LichBay.MaCB) as Số_lần_sử_dụng
from MayBay,LoaiMB,LichBay
where LoaiMB.MaLoai=MayBay.MaLoai and MayBay.MaLoai=LichBay.MaLoai
group by LoaiMB.HangSX,LoaiMB.MaLoai,MayBay.SoHieu
having COUNT(LichBay.MaCB)>=all(
									select count(LichBay.MaCB)
									from LichBay
									group by LichBay.MaLoai)




--------Câu 35:Cho biết tên tên nhân viên được phân nhiều chuyến bay nhiều nhất
select NhanVien.Ten,count (PhanCong.MaCB)  as Số_lần_bay
from PhanCong,NhanVien
where PhanCong.MaNV=NhanVien.MaNV
group by NhanVien.Ten
having count (PhanCong.MaCB)>=all(
								select count (PhanCong.MaCB)
								from PhanCong,NhanVien
								where PhanCong.MaNV=NhanVien.MaNV
								group by PhanCong.MaNV

								)


--------Câu 36:Cho biết tên,địa chỉ,điện thoại của  phi công lái nhiều chuyến bay  nhất
select NhanVien.Ten,NhanVien.DChi,NhanVien.DT,count (PhanCong.MaCB)  as Số_lần_bay
from PhanCong,NhanVien
where PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV=1 
group by NhanVien.Ten,NhanVien.DChi,NhanVien.DT
having count (PhanCong.MaCB)>=all(
								select count (PhanCong.MaCB)
								from PhanCong,NhanVien
								where PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV=1
								group by PhanCong.MaNV

								)
----------Câu 37:Cho biết sân bay đến và số lượng chuyến bay của san bay có ít chuyến bay đáp xuống nhất
select ChuyenBay.SBDEN,count(ChuyenBay.MaCB) as Số_lần_đáp
from ChuyenBay
group by ChuyenBay.SBDEN
having count(ChuyenBay.MaCB) <= all(
									select count(ChuyenBay.MaCB)
									from ChuyenBay
									group by ChuyenBay.SBDEN)
---------Câu 38:Cho biết sân bay đi và số lượng chuyến bay của sân bay đó có nhiều lượt cất cánh nhất
select ChuyenBay.SBDI,count(ChuyenBay.MaCB) as Số_lần_cất_cánh
from ChuyenBay
group by ChuyenBay.SBDI
having count(ChuyenBay.MaCB)>=all (
									select count(ChuyenBay.MaCB)
									from ChuyenBay
									group by ChuyenBay.SBDI)
--------Câu 39 Cho biết tên,địa chỉ,số didejn thoại của khách hàng đã đi nhiều chuyến bay nhất
select KhachHang.Ten,KhachHang.DChi,KhachHang.DT,COUNT(DatCho.MaKH) as Số_lần_đi
from KhachHang,DatCho
where KhachHang.MaKH=DatCho.MaKH
group by KhachHang.Ten,KhachHang.DChi,KhachHang.DT
having COUNT(DatCho.MaKH)>=all(
							select COUNT(DatCho.MaKH)
							from DatCho
							group by DatCho.MaKH
							)
--------Câu 40:Cho biết mã số,tên và lương của các phi công có khả năng lái nhiều loại máy bay nhất
select NhanVien.MaNV,NhanVien.Ten,NhanVien.Luong,count( KhaNang.MaLoai) as Số_lượng_máy_bay_biết_lái
from NhanVien,KhaNang
where NhanVien.MaNV=KhaNang.MaNV
group by NhanVien.MaNV,NhanVien.Ten,NhanVien.Luong
having count( KhaNang.MaLoai) >=all(
									select count(KhaNang.MaLoai)
									from KhaNang
									group by KhaNang.MaNV
									)
---------Câu 41:Cho biết thông tin nhân viên có mức lương cao nhất
select *
from NhanVien
where NhanVien.Luong>=(
						select Max(NhanVien.Luong)
						from NhanVien
						)
---------Câu 42:Cho biết tên,địa chỉ của các nhân viên có lương cao nhất trong phi hành đoàn
select NhanVien.Ten,NhanVien.DChi,NhanVien.Luong
from NhanVien
where NhanVien.LoaiNV=1 and NhanVien.Luong>=
											(
											select Max(NhanVien.Luong)
											from NhanVien
											where NhanVien.LoaiNV=1
											)
---------Câu 43:Cho biết mã chuyến bay,giờ đi và giờ đến của chuyến bay bay sớm nhất trong ngày
select LichBay.NgayDi,ChuyenBay.MaCB,Convert(nvarchar(5),ChuyenBay.GioDi,108) as Giờ_đi,Convert(nvarchar(5),ChuyenBay.GioDen,108) as Giờ_đến
from ChuyenBay,LichBay
where ChuyenBay.MaCB=LichBay.MaCB
group by LichBay.NgayDi,ChuyenBay.MaCB,ChuyenBay.GioDi,ChuyenBay.GioDen
having  Min(ChuyenBay.GioDi) <=all(

									select Min(ChuyenBay.GioDi)
									from ChuyenBay,LichBay
									where ChuyenBay.MaCB=LichBay.MaCB
									group by LichBay.NgayDi
									)
---------Câu 44:Cho biết chuyến bay có thời gian bay dài nhất
select ChuyenBay.MaCB,ChuyenBay.SBDI,ChuyenBay.SBDEN,Convert(nvarchar(5),ChuyenBay.GioDi,108) as Giờ_đi,Convert(nvarchar(5),ChuyenBay.GioDen,108) as Giờ_đến
from ChuyenBay
where datediff(MINUTE,ChuyenBay.GioDi,ChuyenBay.GioDen)>=all(
																select datediff(MINUTE,ChuyenBay.GioDi,ChuyenBay.GioDen) as Thời_gian_bay
																from chuyenbay
																)




---------Câu 45:Cho biết chuyến bay có thời gian ngắn nhất
select ChuyenBay.MaCB,ChuyenBay.SBDI,ChuyenBay.SBDEN,Convert(nvarchar(5),ChuyenBay.GioDi,108) as Giờ_đi,Convert(nvarchar(5),ChuyenBay.GioDen,108) as Giờ_đến
from ChuyenBay
where datediff(MINUTE,ChuyenBay.GioDi,ChuyenBay.GioDen)<=all(
																select datediff(MINUTE,ChuyenBay.GioDi,ChuyenBay.GioDen) as Thời_gian_bay
																from chuyenbay
																)



--------Câu 46:Cho biết mã chuyến bay và ngày đi của những chuyến bay bay trên máy bay  B747 nhiều nhất
-----Xuất thông tin chuyến bay đó ra-------
select a.MaCB,a.NgayDi
from LichBay a
where a.MaLoai='B747' and a.MaCB in (
												---Lấy mã chuyến bay của chuyến bay sử dụng nhiều B747 nhất
												select LichBay.MaCB
												from LichBay
												where LichBay.MaLoai='B747' 
												group by LichBay.MaCB
												having  count(LichBay.MaLoai)>=all( 
																					---đếm số lần sử dụng B747----
																					select  count(LichBay.MaLoai)
																					from LichBay
																					where LichBay.MaLoai='B747'
																					group by LichBay.MaCB
																					)
											)



----------Câu 47:với mỗi chuyến bay có trên 3 hành khách,xuất ma chuyến bay cùng số lượng nhân viên trên chuyến bay đó
select PhanCong.MaCB,PhanCong.NgayDi,count ( PhanCong.MaNV) as Số_nhân_viên_trên_MB
from PhanCong 
group by PhanCong.MaCB,PhanCong.NgayDi
having PhanCong.MaCB in(
						select DatCho.MaCB
						from DatCho
						group by DatCho.MaCB,DatCho.NgayDi
						having count (DatCho.MaKH)>=3
						)
---------Câu 48:Với mỗi loại nhân viên có tổng lương trên 600000,cho biết số lượng nhân vien trong từng loại nhân viên đó

select a.LoaiNV,count (a.maNV) as Số_lượng_nhân_viên
from NhanVien a
group by a.LoaiNV
having  a.LoaiNV in(
							select NhanVien.LoaiNV
							from NhanVien
							group by NhanVien.LoaiNV
							having Sum(NhanVien.Luong)>600000)



-------Câu 49:với mỗi chuyến bay có trên 3 nhân viên,xuất mã chuyến bay cùng số lượng khách hàng đã đặt chỗ trên chuyến bay đó
select DatCho.MaCB,Datcho.NgayDi,count (DatCho.MaKH) as Số_lượng_khách_hàng
from DatCho
group by DatCho.MaCB,DatCho.NgayDi
having DatCho.MaCB in (
					select PhanCong.MaCB
					from PhanCong
					group by PhanCong.MaCB,PhanCong.NgayDi
					having count(PhanCong.MaNV)>3
					)




-------Câu 50:Vỡi mỗi loại máy bay có nhiều hơn một chiếc,cho biết số lượng chuyến bay đã bay được bố trí bay bằng máy bay đó

select LichBay.MaLoai, count(LichBay.MaCB) as Số_lượt_bố_trí
from LichBay
group by LichBay.MaLoai
having LichBay.MaLoai in (
						select MayBay.MaLoai
						from MayBay
						group by  MayBay.MaLoai
						having count (MayBay.SoHieu)>1
						)

---Câu 51:Cho biết chuyến bay nào đã bay tất cả các máy bay của hãng boeing
--->Không có chuyến bay nào đã bay qua hết các loại máy bay của hãng boeing trong CSDL

------Working-------------------
select LichBay.MaCB,count( distinct LichBay.MaLoai) as Số_loại_MB
from LichBay
where LichBay.MaLoai like 'B%'
group by LichBay.MaCB
having count (distinct LichBay.MaLoai)=(
										select count( LoaiMB.MaLoai) 
										from LoaiMB
										where LoaiMB.HangSX='boeing' 
										)



-------Câu 52:cho biết phi công có khả năng lái tất cả các loại máy bay của hãng Airbus
------->Không có phi công nào lái được tất cả các loại máy bay của hãng Airbus
select KhaNang.MaNV,count( distinct KhaNang.MaLoai) as Số_loại_MB
from KhaNang
where KhaNang.MaLoai like 'A%'
group by KhaNang.MaNV
having count (distinct KhaNang.MaLoai)=				
										(
										select count (a.MaLoai)
										from LoaiMB a
										where a.HangSX='Airbus'	
										)	
--------Câu 53:Cho biết tên nhan viên (không phải phi công) được phân công bay tất cả các chuyến bay có mã là 100

select PhanCong.MaNV,NhanVien.ten,count ( PhanCong.NgayDi)
from PhanCong,NhanVien
where PhanCong.MaCB=100 and  PhanCong.MaNV=NhanVien.MaNV and NhanVien.LoaiNV!=1
group by PhanCong.MaNV,NhanVien.ten
having count(distinct PhanCong.NgayDi)>=(
									  ,,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                	select count ( distinct PhanCong.NgayDi)
										from PhanCong
										where   PhanCong.MaCB=100
										group by PhanCong.MaCB
										)