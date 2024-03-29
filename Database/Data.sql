USE [QLNhanSu]
GO
/****** Object:  Table [dbo].[tbl_ChucVu]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_ChuyenMon]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_HopDongLaoDong]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_Luong]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_MauThongBao]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_PhongBan]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_TaiKhoan]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_TinhHinhThuViec]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_TrinhDoHocVan]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoChuyenMon]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoHoSoNhan]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoPhongBan]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoTienLuong]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_BaoCaoViTri]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_DanhSachHoSoCapNhap]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_DanhSachThongBao]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_DanhSachTinhHinhThuViec]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_GetInfoCapNhapNhanVienByMaNV]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataChonLocHoSo]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataChonLocHoSoDK]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataDSHSPV]    Script Date: 12/11/2019 2:16:40 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[Fn_LoadDataDSKQPV]    Script Date: 12/11/2019 2:16:40 PM ******/
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
SET IDENTITY_INSERT [dbo].[tbl_ChucVu] ON 

INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV], [NoiDungCV], [QuyenLoiCV]) VALUES (1, N'Kế Toán Viên', N'Theo dõi thu, chi số tiền gửi, giao dịch ngân hàng,xuất hóa đơn,Tiếp nhận, Kiểm tra hóa đơn chứng từ, xử lý công nợ,
Chấm công , tính lương và trích các khoản theo lương, làm BHXH, BHLĐ.
Hỗ trợ các công việc liên quan,
Thu thập và xử lý chứng từ , theo dõi và hạch toán các nghiệp vụ kinh tế phát sinh dựa theo yêu cầu của quản lý văn phòng
Cung cấp số liệu cho lãnh đạo và các đơn vị chức năng khi được yêu cầu.', N'- Được hưởng các chế độ phúc lợi, chế độ đãi ngộ, khen thưởng theo Quy chế của Công ty.
- Nghỉ chủ nhật và các ngày lễ theo luật LĐ
- Làm việc trong môi trường trẻ trung, năng động
- Được đóng BHXH,du lịch hàng năm cùng công ty, cuối năm có thưởng Tết, lương tháng 13.
- Thưởng theo chế độ công ty.
- Được làm việc trong môi trường năng động, thân thiện; Có cơ hội thăng tiến, phát triển bản thân .')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV], [NoiDungCV], [QuyenLoiCV]) VALUES (2, N'Trưởng Phòng Kế Toán', N'Quản lý phòng Kế Toán', N'- Được hưởng các chế độ phúc lợi, chế độ đãi ngộ, khen thưởng theo Quy chế của Công ty.
- Nghỉ chủ nhật và các ngày lễ theo luật LĐ
- Làm việc trong môi trường trẻ trung, năng động
- Được đóng BHXH,du lịch hàng năm cùng công ty, cuối năm có thưởng Tết, lương tháng 13.
- Thưởng theo chế độ công ty.
- Được làm việc trong môi trường năng động, thân thiện; Có cơ hội thăng tiến, phát triển bản thân .')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV], [NoiDungCV], [QuyenLoiCV]) VALUES (3, N'Maketing', N'- Thực hiện các công việc Marketing theo kế hoạch Marketing đã được phê duyệt.
- Chủ động lên nội dung, viết bào quảng bá sản phẩm theo yêu cầu ban giám đốc
-Tham gia tổ chức sự kiện, phụ trách thực hiện các hoạt động quảng bá dự án Bất động sản.
- Lên kế hoạch truyền thông trên các kênh Website, Social Media (Facebook, Zalo, Instagram…)
- Xây dựng và quản lý chạy quảng cáo trên các kênh Wedsite, Google ads, Facebook ads...
- Quản lý và hướng dẫn đội ngũ nhân viên đăng tin.', N'- Lương nét 8 triệu đến 10 triệu/ tháng.
- Thưởng theo kết quả làm việc.
- Lương tháng 13, 12 ngày phép năm.
- Du lịch hàng năm
- Các chế khác theo quy định hiện hành ...')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV], [NoiDungCV], [QuyenLoiCV]) VALUES (4, N'Trường Phòng Marketing', N'Quản Lý phòng Marketing', N'- Lương nét 8 triệu đến 10 triệu/ tháng.
- Thưởng theo kết quả làm việc.
- Lương tháng 13, 12 ngày phép năm.
- Du lịch hàng năm
- Các chế khác theo quy định hiện hành ...')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV], [NoiDungCV], [QuyenLoiCV]) VALUES (5, N'PR', N'PR', N'PR')
INSERT [dbo].[tbl_ChucVu] ([MaCV], [TenCV], [NoiDungCV], [QuyenLoiCV]) VALUES (6, N'Môi giới', N'- Bán hàng, tư vấn, giới thiệu sản phẩm, các chương trình khuyến mãi cho khách hàng tại cửa hàng
- Sắp xếp trưng bày hàng hóa tại cửa hàng
- Quản lý hàng hóa (các mặt hàng tại cửa hàng, số lượng tồn…) đảm bảo hàng hóa tại cửa hàng luôn được cập nhật đầy đủ về mẫu mã chủng loại, đề xuất kế hoạch giao hàng giữa các cửa hàng.
- Vệ sinh cửa hàng, giữ không gian của cửa hàng luôn sạch sẽ
- Kiểm kê sản phẩm thường xuyên định kì, chịu trách nhiệm về hàng hóa trong ca làm việc.
- Các công việc khác theo yêu cầu của trưởng cửa hàng.', N'- Lương cứng 4-7tr +hỗ trợ ăn trưa/tối, tháng nghỉ 2 ngày
- Được tham gia BHXH, BHYT, các chế độ khác theo quy định hiện hành
- Xét tăng lương định kì nếu làm tốt
- Làm việc trong môi trường trẻ, năng động, chuyên nghiệp, có nhiều cơ hội thăng tiến lên các vị trí cao hơn,…
- Tham gia các hoạt động du lịch, nghỉ mát theo chính sách của công ty')
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
SET IDENTITY_INSERT [dbo].[tbl_MauThongBao] ON 

INSERT [dbo].[tbl_MauThongBao] ([MaThongBao], [NoiLamViec], [YeuCauKyThuat], [SoLuongThamGia], [SoNguoiCanTuyen], [MaCV], [YeuCauKhac], [YeuCauNgoaiNgu], [TuoiTu], [TuoiDen], [MucLuong], [ThoiGianLamViec], [TinhTrangHonNhan], [HinhThucTuyen], [NgayDuKienXuatCanh], [NgayTaoMau]) VALUES (2, N'Bảo Lộc', N'1 năm', N'15', N'5', 1, N'Không', N'Không', 18, 63, NULL, N'Giờ hành chính', 0, N'nộp CV phỏng vấn', N'Không', CAST(N'2019-11-06' AS Date))
SET IDENTITY_INSERT [dbo].[tbl_MauThongBao] OFF
SET IDENTITY_INSERT [dbo].[tbl_NhanVien] ON 

INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [email], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayKetThucThuViec], [TrangThai], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (3, N'Đoàn Công Chính', CAST(N'1999-01-23' AS Date), N'Lâm Đồng', 1, N'Kinh', N'0933798706', N'', 1, 1, 1, 1, CAST(N'2019-11-06' AS Date), CAST(N'2019-11-20' AS Date), NULL, 3, CAST(N'2019-11-02' AS Date), 1, 1)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [email], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayKetThucThuViec], [TrangThai], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (4, N'Nguyễn Văn A', CAST(N'1999-02-23' AS Date), N'Lâm Đồng', 1, N'Kinh', N'0933798706', NULL, 2, 2, 2, 2, CAST(N'2019-11-05' AS Date), CAST(N'2019-12-10' AS Date), NULL, 3, CAST(N'2019-11-02' AS Date), 1, 1)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [email], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayKetThucThuViec], [TrangThai], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (7, N'Nguyễn Thị B', CAST(N'1998-02-24' AS Date), N'Gia Lai', 0, N'Kinh', N'0933454568', NULL, 2, 2, 2, 3, CAST(N'2019-12-09' AS Date), CAST(N'2019-12-11' AS Date), NULL, 2, CAST(N'2019-11-02' AS Date), 2, 2)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [email], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayKetThucThuViec], [TrangThai], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (11, N'a', CAST(N'2019-12-10' AS Date), N'aa', 0, N'a', N'aa', N'a', NULL, 3, 1, 2, CAST(N'2019-12-11' AS Date), CAST(N'2019-12-11' AS Date), NULL, 2, CAST(N'2019-12-10' AS Date), 0, 3)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [email], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayKetThucThuViec], [TrangThai], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (12, N'asdf', CAST(N'2019-12-11' AS Date), N'adfs', 1, N'afds', N'asdfafds', N'afds', NULL, 1, 1, 2, CAST(N'2019-12-04' AS Date), CAST(N'2019-12-12' AS Date), CAST(N'2020-01-12' AS Date), 3, CAST(N'2019-12-11' AS Date), 1, 1)
INSERT [dbo].[tbl_NhanVien] ([MaNV], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [DanToc], [SoDienThoai], [email], [MaPB], [MaCV], [MaTDHV], [BacLuong], [NgayPhongVan], [NgayThuViec], [NgayKetThucThuViec], [TrangThai], [NgayNopHS], [KetQuaPhongVan], [MaCM]) VALUES (13, N'dasfasdf', CAST(N'2019-12-11' AS Date), N'asdfasdfdfas', 0, N'asdffsda', N'dfasd', N'asdffads', NULL, 1, 1, 1, CAST(N'2019-12-13' AS Date), NULL, NULL, NULL, CAST(N'2019-12-11' AS Date), NULL, 1)
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
SET IDENTITY_INSERT [dbo].[tbl_TinhHinhThuViec] ON 

INSERT [dbo].[tbl_TinhHinhThuViec] ([MaTHTV], [MaNV], [KhaNangLamViec], [ThaiDoLamViec], [KinhNghiemLamViec], [HieuQuaLamViec], [NgayCapNhap]) VALUES (1, 4, N'tốt', N'tốt', N'tốt', N'tốt', NULL)
INSERT [dbo].[tbl_TinhHinhThuViec] ([MaTHTV], [MaNV], [KhaNangLamViec], [ThaiDoLamViec], [KinhNghiemLamViec], [HieuQuaLamViec], [NgayCapNhap]) VALUES (2, 4, N'khá', N'khá', N'khá', N'khá', NULL)
INSERT [dbo].[tbl_TinhHinhThuViec] ([MaTHTV], [MaNV], [KhaNangLamViec], [ThaiDoLamViec], [KinhNghiemLamViec], [HieuQuaLamViec], [NgayCapNhap]) VALUES (3, 12, N'aaa', N'a', N'aaaa', N'd', CAST(N'2019-12-11' AS Date))
INSERT [dbo].[tbl_TinhHinhThuViec] ([MaTHTV], [MaNV], [KhaNangLamViec], [ThaiDoLamViec], [KinhNghiemLamViec], [HieuQuaLamViec], [NgayCapNhap]) VALUES (5, 12, N'ấdf', N'ádffds', N'ádf', N'sđấ', CAST(N'2019-12-11' AS Date))
SET IDENTITY_INSERT [dbo].[tbl_TinhHinhThuViec] OFF
SET IDENTITY_INSERT [dbo].[tbl_TrinhDoHocVan] ON 

INSERT [dbo].[tbl_TrinhDoHocVan] ([MaTDHV], [TTDHV], [CNganh]) VALUES (1, N'Đại Học', N'Kinh Tế')
INSERT [dbo].[tbl_TrinhDoHocVan] ([MaTDHV], [TTDHV], [CNganh]) VALUES (2, N'Đại Học', N'Giáo Dục')
SET IDENTITY_INSERT [dbo].[tbl_TrinhDoHocVan] OFF
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
/****** Object:  StoredProcedure [dbo].[Fn_ThemHoSo]    Script Date: 12/11/2019 2:16:40 PM ******/
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
