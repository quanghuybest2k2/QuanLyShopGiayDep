--- quan ly shop giay dep
CREATE DATABASE QuanLyShopGiayDep
GO
	
USE QuanLyShopGiayDep
GO

--- loai giay dep
CREATE TABLE LoaiGD
(
	ID_LGD INT NOT NULL IDENTITY(1,1),
	Ten_LGD NVARCHAR(100) NOT NULL,
	Is_Active BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE HinhGD
(
	ID_HGD INT NOT NULL IDENTITY(1,1),
	HinhGD IMAGE NOT NULL,
	HinhGDP NVARCHAR(MAX) NOT NULL,
	ID_GD INT NOT NULL
)
GO

CREATE TABLE GiayDep
(
	ID_GD INT NOT NULL IDENTITY(1,1),
	Ten_GD NVARCHAR(100) NOT NULL,
	Size CHAR(5) NOT NULL,
	ID_LGD INT NOT NULL,
	GiaBan FLOAT NOT NULL,
	SoLuong INT NOT NULL,
	GhiChu NVARCHAR(MAX) NULL,
	Is_Active BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE LoaiTaiKhoan
(
	ID_LTK INT NOT NULL IDENTITY(1,1),
	Ten_LTK NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE QuanTriVien
(
	ID_QTV INT NOT NULL IDENTITY(1,1),
	TenDangNhap NVARCHAR(50) NOT NULL,
	MatKhau NVARCHAR(50) NOT NULL,
	ID_LTK INT NOT NULL
)
GO

CREATE TABLE KhachHang
(
	ID_KH INT NOT NULL IDENTITY(1,1),
	HoTen NVARCHAR(50) NOT NULL,
	SDT NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(MAX) NULL
)
GO

CREATE TABLE BanHang
(
	ID_BH INT NOT NULL IDENTITY(1,1),
	ID_KH INT NOT NULL,
	ID_GiaoDich NVARCHAR(50) DEFAULT NULL, -- NULL: Khách hàng chưa thanh toán tiền OR 'yyyyddmmhhMMss': thời gian hóa đơn được thanh toán
	NgayBanHang DATETIME DEFAULT GETDATE(),
	Discount FLOAT DEFAULT 0
)
GO

CREATE TABLE ChiTietBanHang
(
	ID_CTBH INT NOT NULL IDENTITY(1,1),
	ID_GD INT NOT NULL,
	ID_BH INT NOT NULL,
	SoLuongSanPham INT NOT NULL
	-- GiaBan FLOAT NOT NULL
)
GO

--------------------------------------------------------------------------------
--                                PRIMARY KEY                                 --
--------------------------------------------------------------------------------
ALTER TABLE LoaiGD WITH NOCHECK ADD CONSTRAINT PK_LoaiQA PRIMARY KEY CLUSTERED 
(
	ID_LGD ASC 
)
GO

ALTER TABLE HinhGD WITH NOCHECK ADD CONSTRAINT PK_HinhQA PRIMARY KEY CLUSTERED 
(
	ID_HGD ASC 
)
GO

ALTER TABLE GiayDep WITH NOCHECK ADD CONSTRAINT PK_QuanAo PRIMARY KEY CLUSTERED 
(
	ID_GD ASC 
)
GO

ALTER TABLE LoaiTaiKhoan WITH NOCHECK ADD CONSTRAINT PK_KieuTaiKhoan PRIMARY KEY CLUSTERED 
(
	ID_LTK ASC 
)
GO

ALTER TABLE QuanTriVien WITH NOCHECK ADD CONSTRAINT PK_QuanTriVien PRIMARY KEY CLUSTERED 
(
	ID_QTV ASC 
)
GO

ALTER TABLE KhachHang WITH NOCHECK ADD CONSTRAINT PK_KhachHang PRIMARY KEY CLUSTERED 
(
	ID_KH ASC 
)
GO

ALTER TABLE ChiTietBanHang WITH NOCHECK ADD CONSTRAINT PK_ChiTietBanHang PRIMARY KEY CLUSTERED 
(
	ID_CTBH ASC 
)
GO

ALTER TABLE BanHang WITH NOCHECK ADD CONSTRAINT PK_BanHang PRIMARY KEY CLUSTERED 
(
	ID_BH ASC 
)
GO

--------------------------------------------------------------------------------
--                                FOREIGN KEY                                 --
--------------------------------------------------------------------------------
ALTER TABLE HinhGD
ADD CONSTRAINT FK_GiayDep_HinhGiayDep
FOREIGN KEY (ID_GD) REFERENCES GiayDep(ID_GD)
GO

ALTER TABLE GiayDep
ADD CONSTRAINT FK_LoaiGD_GiayDep
FOREIGN KEY (ID_LGD) REFERENCES LoaiGD(ID_LGD)
GO

ALTER TABLE QuanTriVien
ADD CONSTRAINT FK_LoaiTaiKhoan_QuanTriVien
FOREIGN KEY (ID_LTK) REFERENCES LoaiTaiKhoan(ID_LTK)
GO

ALTER TABLE ChiTietBanHang
ADD CONSTRAINT FK_GiayDep_ChiTietBanHang
FOREIGN KEY (ID_GD) REFERENCES GiayDep(ID_GD)
GO

ALTER TABLE ChiTietBanHang
ADD CONSTRAINT FK_BanHang_ChiTietBanHang
FOREIGN KEY (ID_BH) REFERENCES BanHang(ID_BH)
GO

ALTER TABLE BanHang
ADD CONSTRAINT FK_KhachHang_BanHang
FOREIGN KEY (ID_KH) REFERENCES KhachHang(ID_KH)
GO

--------------------------------------------------------------------------------
--                                Du lieu mau                                 --
--------------------------------------------------------------------------------

INSERT LoaiGD(Ten_LGD)
VALUES 
	(N'Giày'),
	(N'Dép'),
	(N'Guốc'),
	(N'Boot')
GO
SELECT * FROM LoaiGD

INSERT GiayDep(Ten_GD, ID_LGD, Size, SoLuong, GiaBan, GhiChu)
VALUES
	(N'Giày Nike', 1, 'M', 130, 100000, N'Giày Nike cao cấp mang thương hiệu nước ngoài'),
	(N'Dép tổ ong', 2, 'L', 400, 120000, N'Dép huyền thoại chưa bao giờ lỗi thời'),
	(N'Guốc cao', 3, 'S', 70, 50000, N'Guốc cao cho chị em chiều cao khiêm tốn'),
	(N'Dép cá sấu', 2, 'S', 40, 50000, N'Dép cá sấu cho các bác nông dân'),
	(N'Boot dày', 4, 'L', 10, 50000, N'Boot dày hơn cả xi-măng'),
	(N'Giày Rebook', 1, 'M', 70, 150000, N'Giày Rebook cao cấp'),
	(N'Guốc thấp', 3, 'XL', 60, 200000, N'Guốc thấp cho chị em quá cao'),
	(N'Boot Chống nước', 4, 'M', 65, 300000, N'Boot chống nước cho ai sợ mưa')
SELECT * FROM GiayDep

INSERT LoaiTaiKhoan(Ten_LTK)
VALUES 
	(N'Quản trị viên'),
	(N'Nhân viên')

SELECT * FROM LoaiTaiKhoan

INSERT QuanTriVien(TenDangNhap, MatKhau,ID_LTK)
VALUES
	(N'DOANQUANGHUY', N'huycan',1),
	(N'DOQUOCSANG', N'sangvlog',1),
	(N'NGUYENTHANHDAT', N'datg',1),
	(N'DOHOAINAM', N'namidol',1),
	(N'DIEMQUYNH', N'hihi',2)

SELECT * FROM QuanTriVien

INSERT KhachHang(HoTen, SDT, DiaChi)
VALUES
	(N'Đoàn Quang Huy', '0859476166', N'Ninh Thuận'),
	(N'Đỗ Quốc Sang', '0123456789', N'Đà Lạt'),
	(N'Trần Nhật Duật', '0312456789', N'Thanh Hóa')

SELECT * FROM KhachHang

INSERT BanHang(ID_KH, ID_GiaoDich, Discount, NgayBanHang)
VALUES
	(1, '202206031054', 30, GETDATE()),
	(2, '202206031055', 50, GETDATE()),
	(3, '202206032054', 10, GETDATE())
SELECT * FROM BanHang
SELECT * FROM GiayDep

INSERT ChiTietBanHang(ID_BH, ID_GD, SoLuongSanPham)
VALUES
	(1, 1, 2),
	(1, 2, 2),
	(1, 3, 1),
	(2, 4, 1),
	(2, 5, 2),
	(1, 6, 3),
	(3, 7, 5),
	(3, 8, 1)
SELECT * FROM ChiTietBanHang
GO

INSERT GiayDep(Ten_GD, ID_LGD, Size, SoLuong, GiaBan, GhiChu)
VALUES
	(N'Giày Fila', 1, 'M', 100, 100000, N'Giày Fila siêu hấp dẫn cao cấp');
	GO

-- Procedure bo sung
CREATE PROC sp_select_cacsanphamkhongbanduoc
AS
	BEGIN
	SELECT ID_GD, Ten_GD
	FROM GiayDep
	WHERE ID_GD NOT IN (
		SELECT DISTINCT ID_GD FROM ChiTietBanHang
	)
END
GO

EXEC sp_select_cacsanphamkhongbanduoc
GO

CREATE PROC sp_select_Doanhthubanhangcuatungthangtrongnam
(
	@Year INT
)
AS 
	BEGIN
		SELECT MONTH(BanHang.NgayBanHang) AS THANG, SUM(SoLuongSanPham * GiaBan) AS DOANHTHU
		FROM  ChiTietBanHang 
		JOIN BanHang ON BanHang.ID_BH = ChiTietBanHang.ID_BH
		JOIN  GiayDep ON	ChiTietBanHang.ID_GD = GiayDep.ID_GD
		WHERE YEAR(NgayBanHang) = @Year
		GROUP BY MONTH(NgayBanHang)
	END
GO

EXEC sp_select_Doanhthubanhangcuatungthangtrongnam 2022
GO

CREATE PROC sp_select_top5KhachHangcosolanmuahangnhieunhat
AS
	BEGIN
		SELECT ID_KH,HoTen
		FROM KhachHang
		WHERE ID_KH IN (
			SELECT TOP 5 ID_KH
			FROM BanHang
			GROUP BY ID_KH
			ORDER BY COUNT(DISTINCT ID_BH) DESC
		)
	END
GO

EXEC sp_select_top5KhachHangcosolanmuahangnhieunhat
GO

CREATE PROCEDURE sp_select_Master_LoaiGD
AS
BEGIN
	SELECT LoaiGD.ID_LGD, COUNT(GiayDep.ID_LGD)  AS SoLuongSanPham, Ten_LGD
	FROM GiayDep JOIN LoaiGD ON GiayDep.ID_LGD = LoaiGD.ID_LGD
	WHERE GiayDep.ID_LGD = LoaiGD.ID_LGD
	GROUP BY LoaiGD.ID_LGD,Ten_LGD
END
GO

-- EXEC sp_select_Master_LoaiQA
-- GO


CREATE proc sp_select_sanphambanchaynhat
as
	begin
		Select Top 5 Ten_GD, SUM(SoLuongSanPham) as SoLuongSanPham
		from GiayDep, ChiTietBanHang
		where GiayDep.ID_GD = ChiTietBanHang.ID_GD
		group by Ten_GD
		order by SoLuongSanPham desc
	end
go

EXEC sp_select_sanphambanchaynhat
GO

-- Số lượng sản phẩm bán được của 1 sản phẩm
create proc sp_select_sanphambandduoc
(@ID_GD int)
as
	begin
		select  SUM(SoLuongSanPham) as SoLuongSanPham
		from GiayDep, ChiTietBanHang
		where GiayDep.ID_GD = ChiTietBanHang.ID_GD and QuanAo.ID_GD =  @ID_GD
	end
GO

Create proc Sp_ThongKeMatHangBanDuocTrongMoiThangVaTrongCaNam
(@YEAR int
)
AS
BEGIN
SELECT b.ID_GD,Ten_GD, 
	SUM(CASE MONTH(NgayBanHang) WHEN 1 THEN b.SoLuongSanPham ELSE 0 END) AS Thang1,
	SUM(CASE MONTH(NgayBanHang) WHEN 2 THEN b.SoLuongSanPham ELSE 0 END) AS Thang2,
	SUM(CASE MONTH(NgayBanHang) WHEN 3 THEN b.SoLuongSanPham ELSE 0 END) AS Thang3,
	SUM(CASE MONTH(NgayBanHang) WHEN 4 THEN b.SoLuongSanPham ELSE 0 END) AS Thang4,
	SUM(CASE MONTH(NgayBanHang) WHEN 5 THEN b.SoLuongSanPham ELSE 0 END) AS Thang5,
	SUM(CASE MONTH(NgayBanHang) WHEN 6 THEN b.SoLuongSanPham ELSE 0 END) AS Thang6,
	SUM(CASE MONTH(NgayBanHang) WHEN 7 THEN b.SoLuongSanPham ELSE 0 END) AS Thang7,
	SUM(CASE MONTH(NgayBanHang) WHEN 8 THEN b.SoLuongSanPham ELSE 0 END) AS Thang8,
	SUM(CASE MONTH(NgayBanHang) WHEN 9 THEN b.SoLuongSanPham ELSE 0 END) AS Thang9,
	SUM(CASE MONTH(NgayBanHang) WHEN 10 THEN b.SoLuongSanPham ELSE 0 END) AS Thang10,
	SUM(CASE MONTH(NgayBanHang) WHEN 11 THEN b.SoLuongSanPham ELSE 0 END) AS Thang11,
	SUM(CASE MONTH(NgayBanHang) WHEN 12 THEN b.SoLuongSanPham ELSE 0 END) AS Thang12,
	SUM(b.SoLuongSanPham) AS CaNam
FROM (BanHang AS a INNER JOIN ChiTietBanHang AS b 
ON a.ID_BH=b.ID_BH) 
INNER JOIN GiayDep AS c ON b.ID_GD =c.ID_GD
WHERE YEAR(NgayBanHang) = @YEAR
GROUP BY b.ID_GD,Ten_GD
END
-----------------
select * from banhang
select * from chitietbanhang
select * from GiayDep
select * from hinhgd
select * from khachhang
select * from loaigd
select * from loaitaikhoan
select * from quantrivien