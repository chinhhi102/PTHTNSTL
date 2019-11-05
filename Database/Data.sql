USE [QLNhanSu]
GO
/****** Object:  Table [dbo].[tbl_ChucVu]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ChuyenMon]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChuyenMon](
	[MaCM] [int] IDENTITY(1,1) NOT NULL,
	[TenCM] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ChuyenMon] PRIMARY KEY CLUSTERED 
(
	[MaCM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_HopDongLaoDong]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HopDongLaoDong](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[LoaiHD] [int] NULL,
	[TuNgay] [date] NULL,
	[DenNgay] [date] NULL,
 CONSTRAINT [PK_tbl_HopDongLaoDong] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Luong]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Luong](
	[BacLuong] [int] IDENTITY(1,1) NOT NULL,
	[LuongCB] [float] NULL,
	[HSLuong] [float] NULL,
	[HSPC] [float] NULL,
 CONSTRAINT [PK_tbl_Luong] PRIMARY KEY CLUSTERED 
(
	[BacLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[GioiTinh] [bit] NOT NULL,
	[DanToc] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[MaPB] [int] NULL,
	[MaCV] [int] NULL,
	[MaTDHV] [int] NULL,
	[BacLuong] [int] NULL,
	[NgayPhongVan] [date] NULL,
	[NgayThuViec] [date] NULL,
	[NgayNopHS] [date] NULL,
	[KetQuaPhongVan] [int] NULL,
	[MaCM] [int] NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PhongBan]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhongBan](
	[MaPB] [int] IDENTITY(1,1) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDTPB] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TaiKhoan]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TaiKhoan](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[permission] [int] NOT NULL CONSTRAINT [DF_tbl_TaiKhoan_permission]  DEFAULT ((2)),
	[ten] [nvarchar](50) NOT NULL,
	[ho] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TrinhDoHocVan]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TrinhDoHocVan](
	[MaTDHV] [int] IDENTITY(1,1) NOT NULL,
	[TTDHV] [nvarchar](50) NULL,
	[CNganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_TrinhDoHocVan] PRIMARY KEY CLUSTERED 
(
	[MaTDHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoChuyenMon]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_BaoCaoChuyenMon]
(	
	-- Add the parameters for the function here
	@TuNgay date,
	@DenNgay date
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT TenCM as ChuyenMon, count(MaNV) as hosonhan, 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam, 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as SoLuotPV,
			sum(case when NgayThuViec is not null then 1 else 0 end) as SoUngVienTrungTuyen
	FROM  dbo.tbl_ChuyenMon INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_ChuyenMon.MaCM = dbo.tbl_NhanVien.MaCM
	where NgayNopHS between @TuNgay and @DenNgay
	group by TenCM
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoHoSoNhan]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_BaoCaoHoSoNhan]
(	
	-- Add the parameters for the function here
	@TuNgay date,
	@DenNgay date
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT *
	FROM  dbo.tbl_NhanVien
	where NgayNopHS between @TuNgay and @DenNgay
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoPhongBan]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_BaoCaoPhongBan]
(	
	-- Add the parameters for the function here
	@TuNgay date,
	@DenNgay date
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT TenPB as PhongBan, count(MaNV) as hosonhan, 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam, 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as SoLuotPV,
			sum(case when NgayThuViec is not null then 1 else 0 end) as SoUngVienTrungTuyen
	FROM  dbo.tbl_PhongBan INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_PhongBan.MaPB = dbo.tbl_NhanVien.MaPB
	where NgayNopHS between @TuNgay and @DenNgay
	group by TenPB
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoTienLuong]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_BaoCaoTienLuong]
(	
	-- Add the parameters for the function here
	@TuNgay date,
	@DenNgay date
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT LuongCB as LuongYeuCau, count(MaNV) as hosonhan, 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam, 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as SoLuotPV,
			sum(case when NgayThuViec is not null then 1 else 0 end) as SoUngVienTrungTuyen
	FROM  dbo.tbl_Luong INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_Luong.BacLuong = dbo.tbl_NhanVien.BacLuong
	where NgayNopHS between @TuNgay and @DenNgay
	group by LuongCB
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoViTri]    Script Date: 11/5/2019 8:54:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_BaoCaoViTri]
(	
	-- Add the parameters for the function here
	@TuNgay date,
	@DenNgay date
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT TenCV as vitri, count(MaNV) as hosonhan, 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam, 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as SoLuotPV,
			sum(case when NgayThuViec is not null then 1 else 0 end) as SoUngVienTrungTuyen
	FROM  dbo.tbl_ChucVu INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_ChucVu.MaCV = dbo.tbl_NhanVien.MaCV
	where NgayNopHS between @TuNgay and @DenNgay
	group by TenCV
)

GO
SET IDENTITY_INSERT [dbo].[tbl_ChucVu] ON 

INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (1, N'Kế Toán Viên')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (2, N'Trưởng Phòng Kế Toán')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (3, N'Maketing')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (4, N'Trường Phòng Marketing')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (5, N'PR')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV]) VALUES (6, N'Môi giới')
SET IDENTITY_INSERT [dbo].[tbl_ChucVu] OFF
SET IDENTITY_INSERT [dbo].[tbl_ChuyenMon] ON 

INSERT [dbo].[tbl_ChuyenMon] ([MaCM], [TenCM]) VALUES (1, N'WebDeveloper')
INSERT [dbo].[tbl_ChuyenMon] ([MaCM], [TenCM]) VALUES (2, N'.NET')
INSERT [dbo].[tbl_ChuyenMon] ([MaCM], [TenCM]) VALUES (3, N'C#')
SET IDENTITY_INSERT [dbo].[tbl_ChuyenMon] OFF
SET IDENTITY_INSERT [dbo].[tbl_HopDongLaoDong] ON 

INSERT [dbo].[tbl_HopDongLaoDong] ([MaHD], [MaNV], [LoaiHD], [TuNgay], [DenNgay]) VALUES (6, 3, 1, CAST(N'2019-12-01' AS Date), CAST(N'2020-12-01' AS Date))
INSERT [dbo].[tbl_HopDongLaoDong] ([MaHD], [MaNV], [LoaiHD], [TuNgay], [DenNgay]) VALUES (7, 4, 2, CAST(N'2019-12-01' AS Date), CAST(N'2020-12-01' AS Date))
INSERT [dbo].[tbl_HopDongLaoDong] ([MaHD], [MaNV], [LoaiHD], [TuNgay], [DenNgay]) VALUES (8, 7, 3, CAST(N'2019-12-01' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[tbl_HopDongLaoDong] OFF
SET IDENTITY_INSERT [dbo].[tbl_Luong] ON 

INSERT [dbo].[tbl_Luong] ([BacLuong], [LuongCB], [HSLuong], [HSPC]) VALUES (1, 5000000, 6.2, 1.25)
INSERT [dbo].[tbl_Luong] ([BacLuong], [LuongCB], [HSLuong], [HSPC]) VALUES (2, 6000000, 6.25, 1.22)
INSERT [dbo].[tbl_Luong] ([BacLuong], [LuongCB], [HSLuong], [HSPC]) VALUES (3, 7000000, 6.26, 1)
INSERT [dbo].[tbl_Luong] ([BacLuong], [LuongCB], [HSLuong], [HSPC]) VALUES (4, 4000000, 4.25, 3)
INSERT [dbo].[tbl_Luong] ([BacLuong], [LuongCB], [HSLuong], [HSPC]) VALUES (5, 4500000, 2.25, 6.2)
SET IDENTITY_INSERT [dbo].[tbl_Luong] OFF
SET IDENTITY_INSERT [dbo].[tbl_NhanVien] ON 

INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (3, N'Đoàn Công Chính', CAST(N'1999-01-23' AS Date), N'Lâm Đồng', 1, N'Kinh', N'0933798706', 1, 1, 1, 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (4, N'Nguyễn Văn A', CAST(N'1999-02-23' AS Date), N'Lâm Đồng', 1, N'Kinh', N'0933798706', 2, 2, 2, 2, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (7, N'Nguyễn Thị B', CAST(N'1998-02-24' AS Date), N'Gia Lai', 0, N'Kinh', N'0933454568', 2, 2, 2, 3, NULL, NULL, NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[tbl_NhanVien] OFF
SET IDENTITY_INSERT [dbo].[tbl_PhongBan] ON 

INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [DiaChi], [SDTPB]) VALUES (1, N'Phòng Hành Chính', N'Lầu 1', N'0123456789')
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [DiaChi], [SDTPB]) VALUES (2, N'Phòng Kinh Doanh', N'Lầu 2', N'0123456798')
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [DiaChi], [SDTPB]) VALUES (3, N'Phòng Kế Toán', N'Lầu 3', N'0123456799')
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [DiaChi], [SDTPB]) VALUES (4, N'Văn Phòng Đại Diện', N'Lầu 4', N'0123456777')
INSERT [dbo].[tbl_PhongBan] ([MaPB], [TenPB], [DiaChi], [SDTPB]) VALUES (5, N'Phòng Kỹ Thuật', N'Lầu 5', N'0123456778')
SET IDENTITY_INSERT [dbo].[tbl_PhongBan] OFF
INSERT [dbo].[tbl_TaiKhoan] ([username], [password], [permission], [ten], [ho]) VALUES (N'admin', N'admin', 1, N'admin', N'admin')
INSERT [dbo].[tbl_TaiKhoan] ([username], [password], [permission], [ten], [ho]) VALUES (N'chinhhi', N'123456', 1, N'Chính', N'Đoàn')
INSERT [dbo].[tbl_TaiKhoan] ([username], [password], [permission], [ten], [ho]) VALUES (N'user', N'user', 2, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[tbl_TrinhDoHocVan] ON 

INSERT [dbo].[tbl_TrinhDoHocVan] ([MaTDHV], [TTDHV], [CNganh]) VALUES (1, N'Đại Học', N'Kinh Tế')
INSERT [dbo].[tbl_TrinhDoHocVan] ([MaTDHV], [TTDHV], [CNganh]) VALUES (2, N'Đại Học', N'Giáo Dục')
SET IDENTITY_INSERT [dbo].[tbl_TrinhDoHocVan] OFF
ALTER TABLE [dbo].[tbl_HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDongLaoDong_tbl_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_HopDongLaoDong] CHECK CONSTRAINT [FK_tbl_HopDongLaoDong_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhanVien_tbl_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tbl_ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_tbl_NhanVien_tbl_ChucVu]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhanVien_tbl_ChuyenMon] FOREIGN KEY([MaCM])
REFERENCES [dbo].[tbl_ChuyenMon] ([MaCM])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_tbl_NhanVien_tbl_ChuyenMon]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhanVien_tbl_Luong] FOREIGN KEY([BacLuong])
REFERENCES [dbo].[tbl_Luong] ([BacLuong])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_tbl_NhanVien_tbl_Luong]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhanVien_tbl_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[tbl_PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_tbl_NhanVien_tbl_PhongBan]
GO
ALTER TABLE [dbo].[tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_NhanVien_tbl_TrinhDoHocVan] FOREIGN KEY([MaTDHV])
REFERENCES [dbo].[tbl_TrinhDoHocVan] ([MaTDHV])
GO
ALTER TABLE [dbo].[tbl_NhanVien] CHECK CONSTRAINT [FK_tbl_NhanVien_tbl_TrinhDoHocVan]
GO
