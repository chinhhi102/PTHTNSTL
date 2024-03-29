USE [QLNhanSu]
GO
/****** Object:  Table [dbo].[tbl_ChucVu]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
	[NoiDungCV] [nvarchar](1000) NULL,
	[QuyenLoiCV] [nvarchar](1000) NULL,
 CONSTRAINT [PK_tbl_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ChuyenMon]    Script Date: 12/11/2019 2:58:43 PM ******/
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
/****** Object:  Table [dbo].[tbl_HopDongLaoDong]    Script Date: 12/11/2019 2:58:43 PM ******/
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
/****** Object:  Table [dbo].[tbl_Luong]    Script Date: 12/11/2019 2:58:43 PM ******/
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
/****** Object:  Table [dbo].[tbl_MauThongBao]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MauThongBao](
	[MaThongBao] [int] IDENTITY(1,1) NOT NULL,
	[NoiLamViec] [nvarchar](1000) NULL,
	[YeuCauKyThuat] [nvarchar](1000) NULL,
	[SoLuongThamGia] [nvarchar](1000) NULL,
	[SoNguoiCanTuyen] [nvarchar](1000) NOT NULL,
	[MaCV] [int] NULL,
	[YeuCauKhac] [nvarchar](1000) NULL,
	[YeuCauNgoaiNgu] [nvarchar](1000) NULL,
	[TuoiTu] [int] NULL,
	[TuoiDen] [int] NULL,
	[MucLuong] [nvarchar](1000) NULL,
	[ThoiGianLamViec] [nvarchar](1000) NULL,
	[TinhTrangHonNhan] [int] NULL,
	[HinhThucTuyen] [nvarchar](1000) NULL,
	[NgayDuKienXuatCanh] [nvarchar](1000) NULL,
	[NgayTaoMau] [date] NULL,
 CONSTRAINT [PK_tbl_MauThongBao] PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 12/11/2019 2:58:43 PM ******/
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
	[email] [nvarchar](50) NULL,
	[MaPB] [int] NULL,
	[MaCV] [int] NULL,
	[MaTDHV] [int] NULL,
	[BacLuong] [int] NULL,
	[NgayPhongVan] [date] NULL,
	[NgayThuViec] [date] NULL,
	[NgayKetThucThuViec] [date] NULL,
	[TrangThai] [int] NULL,
	[NgayNopHS] [date] NULL,
	[KetQuaPhongVan] [int] NULL,
	[MaCM] [int] NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PhongBan]    Script Date: 12/11/2019 2:58:43 PM ******/
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
/****** Object:  Table [dbo].[tbl_TaiKhoan]    Script Date: 12/11/2019 2:58:43 PM ******/
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
/****** Object:  Table [dbo].[tbl_TinhHinhThuViec]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TinhHinhThuViec](
	[MaTHTV] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[KhaNangLamViec] [nvarchar](500) NULL,
	[ThaiDoLamViec] [nvarchar](500) NULL,
	[KinhNghiemLamViec] [nvarchar](500) NULL,
	[HieuQuaLamViec] [nvarchar](500) NULL,
	[NgayCapNhap] [date] NULL,
 CONSTRAINT [PK_tbl_TinhHinhThuViec] PRIMARY KEY CLUSTERED 
(
	[MaTHTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TrinhDoHocVan]    Script Date: 12/11/2019 2:58:43 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoChuyenMon]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
	SELECT TenCM as N'Chuyên Môn', count(MaNV) as N'Hồ Sơ Nhận', 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam,
			sum(case when GioiTinh = 'true' then 0 else 1 end) as N'Nữ',
			sum(case when NgayPhongVan is not null then 1 else 0 end) as N'Số Lượt Phỏng Vấn',
			sum(case when NgayThuViec is not null then 1 else 0 end) as N'Số Ứng Cử Viên Trúng Tuyển'
	FROM  dbo.tbl_ChuyenMon INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_ChuyenMon.MaCM = dbo.tbl_NhanVien.MaCM
	where NgayNopHS between @TuNgay and @DenNgay
	group by TenCM
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoHoSoNhan]    Script Date: 12/11/2019 2:58:43 PM ******/
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
	SELECT MaNV as N'Mã Nhân Viên', HoTen as N'Họ Và Tên', NgaySinh as N'Ngày Sinh (mm/dd/yyyy)',
			QueQuan as N'Quê Quán', (case when GioiTinh = 'true' then 'Nam' else N'Nữ' end) as N'Giới Tính',
			DanToc as N'Dân Tộc', SoDienThoai as N'Số Điện Thoại', (case when NgayPhongVan is null then N'Chưa Đặt Lịch' else CONVERT(varchar, NgayPhongVan, 1) end) as N'Ngày Phỏng Vấn (mm/dd/yyyy)',
			(case when NgayThuViec is null then N'Chưa Có Kết Quả Phỏng Vấn' else CONVERT(varchar, NgayThuViec, 1) end) as N'Ngày Thử Việc (mm/dd/yyyy)', NgayNopHS as N'Ngày Nộp Hồ Sơ (mm/dd/yyyy)', 
			(case when KetQuaPhongVan = 1 then N'Đạt' when KetQuaPhongVan = 2 then N'Không Đạt' else N'Chưa Phỏng Vấn' end) as N'Kết Quả Phỏng Vấn'
	FROM  dbo.tbl_NhanVien
	where NgayNopHS between @TuNgay and @DenNgay
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoPhongBan]    Script Date: 12/11/2019 2:58:43 PM ******/
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
	SELECT TenPB as N'Phòng Ban', count(MaNV) as N'Số Hồ Sơ Nhận', 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as N'Nam',
			sum(case when GioiTinh = 'false' then 1 else 0 end) as N'Nữ', 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as N'Số Lượt Phỏng Vấn',
			sum(case when NgayThuViec is not null then 1 else 0 end) as N'Số Ứng Viên Trúng Tuyển'
	FROM  dbo.tbl_PhongBan INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_PhongBan.MaPB = dbo.tbl_NhanVien.MaPB
	where NgayNopHS between @TuNgay and @DenNgay
	group by TenPB
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoTienLuong]    Script Date: 12/11/2019 2:58:43 PM ******/
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
	SELECT LuongCB as N'Lương yêu cầu', count(MaNV) as N'Hồ Sơ Nhận', 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam, 
			sum(case when GioiTinh = 'false' then 1 else 0 end) as N'Nữ', 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as N'Số Lượt Phỏng Vấn',
			sum(case when NgayThuViec is not null then 1 else 0 end) as N'Số Ứng Cử Viên Trúng Tuyển'
	FROM  dbo.tbl_Luong INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_Luong.BacLuong = dbo.tbl_NhanVien.BacLuong
	where NgayNopHS between @TuNgay and @DenNgay
	group by LuongCB
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoViTri]    Script Date: 12/11/2019 2:58:43 PM ******/
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
	SELECT TenCV as N'Vị Trí', count(MaNV) as N'Hồ Sơ Nhận', 
			sum(case when GioiTinh = 'true' then 1 else 0 end) as Nam, 
			sum(case when GioiTinh = 'false' then 1 else 0 end) as N'Nữ', 
			sum(case when NgayPhongVan is not null then 1 else 0 end) as N'Số Lượt Phỏng Vấn',
			sum(case when NgayThuViec is not null then 1 else 0 end) as N'Số Ứng Cử Viên Trúng Tuyển'
	FROM  dbo.tbl_ChucVu INNER JOIN
                         dbo.tbl_NhanVien ON dbo.tbl_ChucVu.MaCV = dbo.tbl_NhanVien.MaCV
	where NgayNopHS between @TuNgay and @DenNgay
	group by TenCV
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_DanhSachHoSoCapNhap]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_DanhSachHoSoCapNhap]
()
RETURNS TABLE 
AS
RETURN 
(
	Select MaNV as N'Mã Nhân Viên',
			HoTen as N'Họ và tên',
			NgaySinh as N'Ngày sinh',
			QueQuan as N'Quê quán',
			GioiTinh as N'Giới tính',
			DanToc as N'Dân tộc',
			SoDienThoai as N'Số điện thoại',
			MaCM as N'Mã Chuyên Môn',
			MaPB as N'Mã Phòng Ban',
			NgayThuViec as N'Ngày thử việc'
	From tbl_NhanVien
	Where KetQuaPhongVan = 1 and TrangThai = 2
)


GO
/****** Object:  UserDefinedFunction [dbo].[Fn_DanhSachThongBao]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_DanhSachThongBao]()
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	select MaThongBao as N'Mã Thông Báo',
			TenCV as N'Vị trí',
			NgayTaoMau as N'Ngày Tạo Mẫu'
	from tbl_MauThongBao join
				tbl_ChucVu on tbl_ChucVu.MaCV = tbl_MauThongBao.MaCV
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_DanhSachTinhHinhThuViec]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_DanhSachTinhHinhThuViec](
	-- Add the parameters for the function here
	@MaNV int
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT        MaTHTV AS [Mã Tình Hình Thử Việc], ThaiDoLamViec AS [Thái Độ Làm Việc], KhaNangLamViec AS [Khả Năng Làm Việc], KinhNghiemLamViec AS [Kinh Nghiệm Làm Việc], HieuQuaLamViec AS [Hiệu Quả Làm Việc], NgayCapNhap AS [Ngày Cập Nhập]
	FROM            tbl_TinhHinhThuViec
	WHERE			MaNV = @MaNV 
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_GetInfoCapNhapNhanVienByMaNV]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_GetInfoCapNhapNhanVienByMaNV](
	-- Add the parameters for the function here
	@MaNV int
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT        tbl_NhanVien.MaNV, tbl_NhanVien.HoTen, tbl_NhanVien.NgaySinh, tbl_NhanVien.GioiTinh, tbl_NhanVien.NgayThuViec, tbl_NhanVien.NgayKetThucThuViec, tbl_ChucVu.TenCV
	FROM            tbl_ChucVu INNER JOIN
                         tbl_NhanVien ON tbl_ChucVu.MaCV = tbl_NhanVien.MaCV
	WHERE @MaNV = MaNV
)



GO
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataChonLocHoSo]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_LoadDataChonLocHoSo]
()
RETURNS TABLE 
AS
RETURN 
(
	SELECT        MaNV AS [Mã HS], HoTen AS [Họ Tên], NgaySinh AS [Ngày Sinh], (case when GioiTinh = 1 then 'Nam' else N'Nữ' end) AS [Giới Tính], SoDienThoai AS SĐT, email AS Email, NgayNopHS AS [Ngày Nộp HS], QueQuan AS [Quê Quán], DanToc AS [Dân Tộc], MaCV AS [Mã CV], 
                         MaTDHV AS [Mã TDHV], BacLuong AS [Bậc Lương], MaCM AS [Mã Chuyên Môn]
FROM            tbl_NhanVien
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataChonLocHoSoDK]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_LoadDataChonLocHoSoDK]
(
	@tukhoa int,
	@loai int
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT        MaNV AS [Mã HS], HoTen AS [Họ Tên], NgaySinh AS [Ngày Sinh], (case when GioiTinh = 1 then 'Nam' else N'Nữ' end) AS [Giới Tính], SoDienThoai AS SĐT, email AS Email, NgayNopHS AS [Ngày Nộp HS], QueQuan AS [Quê Quán], DanToc AS [Dân Tộc], MaCV AS [Mã CV], 
                         MaTDHV AS [Mã TDHV], BacLuong AS [Bậc Lương], MaCM AS [Mã Chuyên Môn]
FROM            tbl_NhanVien
WHERE ( @loai = 1 and MaPB = @tukhoa ) or (@loai = 2 and MaCV = @tukhoa))

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataDSHSPV]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_LoadDataDSHSPV](
	-- Add the parameters for the function here
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT        MaNV AS [Mã Nhân Viên], HoTen AS [Họ và Tên], NgaySinh AS [Ngày Sinh], GioiTinh AS [Giới Tính], MaCV AS [Mã Công Việc], NgayPhongVan AS [Ngày Phỏng Vấn]
	FROM            tbl_NhanVien
	WHERE        (NgayPhongVan IS NULL) OR
                         (GETDATE() < NgayPhongVan)
)

GO
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataDSKQPV]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_LoadDataDSKQPV](
	-- Add the parameters for the function here
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT        MaNV AS [Mã Nhân Viên], HoTen AS [Họ và Tên], NgaySinh AS [Ngày Sinh], GioiTinh AS [Giới Tính], MaCV AS [Mã Công Việc], KetQuaPhongVan AS [Kết Quả Phỏng Vấn], NgayThuViec AS [Ngày Thử Việc]
	FROM            tbl_NhanVien
	WHERE    (GETDATE() >= NgayPhongVan) AND (NgayThuViec is null OR GETDATE() < NgayThuViec)
)
GO
ALTER TABLE [dbo].[tbl_HopDongLaoDong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HopDongLaoDong_tbl_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_HopDongLaoDong] CHECK CONSTRAINT [FK_tbl_HopDongLaoDong_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_MauThongBao]  WITH CHECK ADD  CONSTRAINT [FK_tbl_MauThongBao_tbl_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tbl_ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[tbl_MauThongBao] CHECK CONSTRAINT [FK_tbl_MauThongBao_tbl_ChucVu]
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
ALTER TABLE [dbo].[tbl_TinhHinhThuViec]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TinhHinhThuViec_tbl_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_TinhHinhThuViec] CHECK CONSTRAINT [FK_tbl_TinhHinhThuViec_tbl_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[Fn_ThemHoSo]    Script Date: 12/11/2019 2:58:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Fn_ThemHoSo]
(
	@HoTen nvarchar,
	@NgaySinh date,
	@GioiTinh bit,
	@SoDienThoai nvarchar,
	@email nvarchar,
	@NgayNopHS date,
	@QueQuan nvarchar,
	@DanToc nvarchar,
	@MaCV int,
	@MaTDHV int,
	@BacLuong int,
	@MaCM int
)
AS
BEGIN
	INSERT into tbl_NhanVien 
		(HoTen, NgaySinh, GioiTinh, SoDienThoai, email, NgayNopHS, QueQuan, DanToc, MaCV,	MaTDHV, BacLuong,	MaCM) 
		values 
		(@HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @email, @NgayNopHS, @QueQuan,	@DanToc, @MaCV,	@MaTDHV, @BacLuong,	@MaCM)
END

GO
