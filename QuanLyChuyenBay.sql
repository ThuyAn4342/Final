USE [master]
GO
/****** Object:  Database [FlightManagement]    Script Date: 17/04/2025 3:20:26 CH ******/
CREATE DATABASE [FlightManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FlightManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FlightManagement.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FlightManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FlightManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FlightManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FlightManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FlightManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FlightManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FlightManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FlightManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FlightManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [FlightManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FlightManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FlightManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FlightManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FlightManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FlightManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FlightManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FlightManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FlightManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FlightManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FlightManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FlightManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FlightManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FlightManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FlightManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FlightManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FlightManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FlightManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [FlightManagement] SET  MULTI_USER 
GO
ALTER DATABASE [FlightManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FlightManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FlightManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FlightManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FlightManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FlightManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FlightManagement', N'ON'
GO
ALTER DATABASE [FlightManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [FlightManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FlightManagement]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[id] [tinyint] NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenBay](
	[maCB] [int] IDENTITY(1,1) NOT NULL,
	[ngayGioDi] [datetime] NULL,
	[thoiGianBay] [int] NULL,
	[tienTrinhID] [tinyint] NOT NULL,
	[maTB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ghe](
	[maGhe] [int] IDENTITY(1,1) NOT NULL,
	[tenGhe] [nvarchar](255) NULL,
	[hangGhe] [nvarchar](50) NULL,
	[maMB] [int] NULL,
	[tileGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ghe_ChuyenBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ghe_ChuyenBay](
	[maGhe] [int] NOT NULL,
	[maCB] [int] NOT NULL,
	[trangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[maGhe] ASC,
	[maCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHD] [int] IDENTITY(1,1) NOT NULL,
	[ngayLapHD] [date] NULL,
	[soLuongVe] [int] NULL,
	[tongTien] [float] NULL,
	[phuongThucTT] [nvarchar](255) NULL,
	[maND] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMayBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMayBay](
	[maLoaiMB] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiMB] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayBay](
	[maMB] [int] IDENTITY(1,1) NOT NULL,
	[tenMB] [varchar](255) NULL,
	[slGheH1] [int] NULL,
	[slGhePT] [int] NULL,
	[maLoaiMB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[maND] [int] IDENTITY(1,1) NOT NULL,
	[hoTenND] [nvarchar](255) NULL,
	[tenDangNhap] [varchar](255) NOT NULL,
	[ChucNangId] [tinyint] NOT NULL,
	[soDT] [varchar](20) NULL,
	[matKhau] [varchar](255) NULL,
	[linkAnh] [varchar](255) NULL,
	[mail] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[maND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[maQD] [int] IDENTITY(1,1) NOT NULL,
	[tenQD] [nvarchar](255) NULL,
	[noidungQD] [int] NULL,
	[ngayCapNhat] [date] NULL,
 CONSTRAINT [PK__QuyDinh__7A3EFC2FAFBF356D] PRIMARY KEY CLUSTERED 
(
	[maQD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanBay](
	[maSB] [int] IDENTITY(1,1) NOT NULL,
	[tenSB] [nvarchar](255) NULL,
	[tinhThanh] [nvarchar](255) NULL,
	[quocGia] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[maSB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanBayTrungGian]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanBayTrungGian](
	[maSB] [int] NOT NULL,
	[maTB] [int] NOT NULL,
	[thoiGianDung] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maSB] ASC,
	[maTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TienTrinh]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienTrinh](
	[id] [tinyint] NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuyenBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenBay](
	[maTB] [int] IDENTITY(1,1) NOT NULL,
	[tenTB] [nvarchar](255) NULL,
	[sanBayDi] [int] NULL,
	[sanBayDen] [int] NULL,
	[giaTB] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeChuyenBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeChuyenBay](
	[maVe] [int] IDENTITY(1,1) NOT NULL,
	[tenHK] [nvarchar](255) NULL,
	[maHD] [int] NULL,
	[maGhe] [int] NULL,
	[maCB] [int] NULL,
	[giaVe] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucNang] ([id], [ten]) VALUES (1, N'Admin')
INSERT [dbo].[ChucNang] ([id], [ten]) VALUES (2, N'EMPL')
INSERT [dbo].[ChucNang] ([id], [ten]) VALUES (3, N'USER')
GO
SET IDENTITY_INSERT [dbo].[ChuyenBay] ON 

INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (1, CAST(N'2024-03-15T10:00:00.000' AS DateTime), 120, 1, 1)
INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (2, CAST(N'2024-02-16T14:00:00.000' AS DateTime), 90, 1, 2)
INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (7, CAST(N'2025-05-01T08:00:00.000' AS DateTime), 120, 1, 4)
INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (8, CAST(N'2025-05-02T09:00:00.000' AS DateTime), 110, 1, 6)
INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (9, CAST(N'2025-05-03T07:30:00.000' AS DateTime), 90, 1, 5)
INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (10, CAST(N'2025-04-04T13:00:00.000' AS DateTime), 100, 3, 6)
INSERT [dbo].[ChuyenBay] ([maCB], [ngayGioDi], [thoiGianBay], [tienTrinhID], [maTB]) VALUES (11, CAST(N'2025-04-05T14:00:00.000' AS DateTime), 95, 3, 4)
SET IDENTITY_INSERT [dbo].[ChuyenBay] OFF
GO
SET IDENTITY_INSERT [dbo].[Ghe] ON 

INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (1, N'A1', N'Hạng 1', 1, 1.5)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (2, N'A2', N'Hạng 1', 1, 1.5)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (3, N'B1', N'Hạng 2', 1, 1)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (4, N'B2', N'Hạng 2', 1, 1)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (5, N'B3', N'Hạng 2', 1, 1)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (8, N'A5', N'Hạng 1', 2, 2)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (9, N'B5', N'Phổ thông', 2, 1)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (10, N'C1', N'Phổ thông', 2, 1)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (11, N'C2', N'Phổ thông', 2, 1)
INSERT [dbo].[Ghe] ([maGhe], [tenGhe], [hangGhe], [maMB], [tileGia]) VALUES (12, N'C3', N'Phổ thông', 2, 1)
SET IDENTITY_INSERT [dbo].[Ghe] OFF
GO
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (1, 1, 0)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (1, 7, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (1, 8, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (1, 9, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (2, 1, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (2, 7, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (2, 8, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (2, 9, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (3, 1, 0)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (3, 7, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (3, 8, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (3, 9, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (4, 1, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (4, 7, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (4, 8, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (4, 9, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (5, 1, 0)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (5, 7, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (5, 8, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (5, 9, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (8, 2, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (8, 10, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (8, 11, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (9, 2, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (9, 10, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (9, 11, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (10, 2, 0)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (10, 10, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (10, 11, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (11, 2, 0)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (11, 10, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (11, 11, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (12, 2, 0)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (12, 10, 1)
INSERT [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB], [trangThai]) VALUES (12, 11, 1)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1, CAST(N'2025-12-03' AS Date), 2, 6000000, N'Thẻ tín dụng', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (2, CAST(N'2024-12-03' AS Date), 1, 2000000, N'Tiền mặt', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (3, CAST(N'2025-03-11' AS Date), 1, 3000000, N'Tiền mặt', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (4, CAST(N'2025-03-11' AS Date), 1, 2000000, N'Thẻ tín dụng', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (5, CAST(N'2024-03-11' AS Date), 2, 4500000, N'Thẻ tín dụng', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1014, CAST(N'2025-04-11' AS Date), 5, 9000000, N'Thẻ tín dụng', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1015, CAST(N'2025-04-15' AS Date), 3, 4000000, N'Tiền mặt', 8)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1016, CAST(N'2025-04-12' AS Date), 2, 2000000, N'Chuyển khoản', 8)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1017, CAST(N'2025-03-02' AS Date), 5, 12000000, N'Chuyển khoản', 8)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1018, CAST(N'2025-03-23' AS Date), 2, 3000000, N'Tiền mặt', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1019, CAST(N'2025-03-13' AS Date), 3, 3000000, N' Tiền mặt', 8)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1020, CAST(N'2025-04-24' AS Date), 2, 4500000, N'Thẻ tín dụng', 2)
INSERT [dbo].[HoaDon] ([maHD], [ngayLapHD], [soLuongVe], [tongTien], [phuongThucTT], [maND]) VALUES (1021, CAST(N'2025-04-04' AS Date), 3, 4500000, N'Thẻ tín dụng', 8)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiMayBay] ON 

INSERT [dbo].[LoaiMayBay] ([maLoaiMB], [tenLoaiMB]) VALUES (2, N'Airbus A320')
INSERT [dbo].[LoaiMayBay] ([maLoaiMB], [tenLoaiMB]) VALUES (1, N'Boeing 777')
SET IDENTITY_INSERT [dbo].[LoaiMayBay] OFF
GO
SET IDENTITY_INSERT [dbo].[MayBay] ON 

INSERT [dbo].[MayBay] ([maMB], [tenMB], [slGheH1], [slGhePT], [maLoaiMB]) VALUES (1, N'VN001', 20, 150, 1)
INSERT [dbo].[MayBay] ([maMB], [tenMB], [slGheH1], [slGhePT], [maLoaiMB]) VALUES (2, N'VN002', 15, 135, 2)
SET IDENTITY_INSERT [dbo].[MayBay] OFF
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([maND], [hoTenND], [tenDangNhap], [ChucNangId], [soDT], [matKhau], [linkAnh], [mail]) VALUES (1, N'Nguyễn Văn A', N'admin', 1, N'0909123456', N'password123', N'linkAnh1', NULL)
INSERT [dbo].[NguoiDung] ([maND], [hoTenND], [tenDangNhap], [ChucNangId], [soDT], [matKhau], [linkAnh], [mail]) VALUES (2, N'Trần Thị B', N'user1', 2, N'0912123456', N'password123', N'linkAnh2', NULL)
INSERT [dbo].[NguoiDung] ([maND], [hoTenND], [tenDangNhap], [ChucNangId], [soDT], [matKhau], [linkAnh], [mail]) VALUES (8, N'Phan Thanh Hà', N'user2', 1, N'0936848746', N'123', N'C:\Users\HP\OneDrive\Pictures\Saved Pictures\chibi.jpg', NULL)
INSERT [dbo].[NguoiDung] ([maND], [hoTenND], [tenDangNhap], [ChucNangId], [soDT], [matKhau], [linkAnh], [mail]) VALUES (9, N'Võ Quốc Bảo', N'quocbao', 1, N'0947857745', N'123', NULL, N'2251050009bao@ou.edu.vn')
INSERT [dbo].[NguoiDung] ([maND], [hoTenND], [tenDangNhap], [ChucNangId], [soDT], [matKhau], [linkAnh], [mail]) VALUES (10, N'Thạch Nhựt Hào', N'nhuthao', 1, N'0857757676', N'123', NULL, N'2251050025hao@ou.edu.vn')
INSERT [dbo].[NguoiDung] ([maND], [hoTenND], [tenDangNhap], [ChucNangId], [soDT], [matKhau], [linkAnh], [mail]) VALUES (11, N'Phạm Thị Thúy An', N'thuyan', 1, N'0978464554', N'123', NULL, N'2251052002an@ou.edu.vn')
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO
SET IDENTITY_INSERT [dbo].[QuyDinh] ON 

INSERT [dbo].[QuyDinh] ([maQD], [tenQD], [noidungQD], [ngayCapNhat]) VALUES (1, N'Số sân bay trung gian tối đa', 2, CAST(N'2024-01-01' AS Date))
INSERT [dbo].[QuyDinh] ([maQD], [tenQD], [noidungQD], [ngayCapNhat]) VALUES (2, N'Thời gian dừng tối thiểu', 20, CAST(N'2025-02-17' AS Date))
INSERT [dbo].[QuyDinh] ([maQD], [tenQD], [noidungQD], [ngayCapNhat]) VALUES (3, N'Thời gian dừng tối đa', 30, CAST(N'2025-04-17' AS Date))
SET IDENTITY_INSERT [dbo].[QuyDinh] OFF
GO
SET IDENTITY_INSERT [dbo].[SanBay] ON 

INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (1, N'Tân Sơn Nhất', N'TP. HCM', N'Việt Nam')
INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (2, N'Nội Bài', N'Hà Nội', N'Việt Nam')
INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (3, N'Đà Nẵng', N'Đà Nẵng', N'Việt Nam')
INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (5, N'Vân Đồn', N'Quảng Ninh', N'Việt Nam')
INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (6, N'Điện Biên Phủ', N'Điện Biên', N'Việt Nam')
INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (7, N'Cần Thơ', N'Cần Thơ', N'Việt Nam')
INSERT [dbo].[SanBay] ([maSB], [tenSB], [tinhThanh], [quocGia]) VALUES (8, N'Phú Quốc', N'Kiên Giang', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[SanBay] OFF
GO
INSERT [dbo].[SanBayTrungGian] ([maSB], [maTB], [thoiGianDung]) VALUES (3, 1, 30)
GO
INSERT [dbo].[TienTrinh] ([id], [ten]) VALUES (2, N'DangBay')
INSERT [dbo].[TienTrinh] ([id], [ten]) VALUES (1, N'DangCho')
INSERT [dbo].[TienTrinh] ([id], [ten]) VALUES (3, N'HoanThanh')
GO
SET IDENTITY_INSERT [dbo].[TuyenBay] ON 

INSERT [dbo].[TuyenBay] ([maTB], [tenTB], [sanBayDi], [sanBayDen], [giaTB]) VALUES (1, N'HCM - Hà Nội', 1, 2, 2000000)
INSERT [dbo].[TuyenBay] ([maTB], [tenTB], [sanBayDi], [sanBayDen], [giaTB]) VALUES (2, N'HCM - Đà Nẵng', 1, 3, 1500000)
INSERT [dbo].[TuyenBay] ([maTB], [tenTB], [sanBayDi], [sanBayDen], [giaTB]) VALUES (4, N'Quảng Ninh - Kiên Giang', 5, 8, 1500000)
INSERT [dbo].[TuyenBay] ([maTB], [tenTB], [sanBayDi], [sanBayDen], [giaTB]) VALUES (5, N'Cần Thơ - Điện Biên', 7, 6, 2000000)
INSERT [dbo].[TuyenBay] ([maTB], [tenTB], [sanBayDi], [sanBayDen], [giaTB]) VALUES (6, N'Đà Nẵng - Kiên Giang', 3, 8, 1000000)
SET IDENTITY_INSERT [dbo].[TuyenBay] OFF
GO
SET IDENTITY_INSERT [dbo].[VeChuyenBay] ON 

INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1, N'Lê Văn C', 1, 1, 1, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (2, N'Phạm Thị D', 1, 2, 1, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (3, N'Ngô Văn E', 2, 3, 1, 2000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (4, N'Phạm Như Bình', 3, 5, 1, 2000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (5, N'Lê Anh Thư', 4, 4, 1, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (6, N'Lý Anh Hà', 5, 8, 2, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (9, N'Ngô Van H', 5, 9, 2, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1010, N'Trần Thanh Nhã', 1014, 1, 7, 2250000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1011, N'Trương Thanh Huyền', 1014, 2, 7, 2250000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1012, N'Đặng Tiến Đạt', 1014, 3, 7, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1013, N'Nguyễn Huy hoàng', 1014, 4, 7, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1014, N'Đinh Thành Huy', 1014, 5, 7, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1015, N'Trần Tính', 1015, 1, 8, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1016, N'Hạ Hòa Hân', 1015, 2, 8, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1017, N'Đặng Văn Nhàn', 1015, 3, 8, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1018, N'Đinh Văn hoàng', 1016, 4, 8, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1019, N'Hồ Quốc Duy', 1016, 5, 8, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1022, N'Cao Văn B', 1018, 8, 10, 2000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1023, N'Lý Thị Nhi', 1018, 9, 10, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1024, N'Phạm Thanh Hà', 1019, 10, 10, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1025, N'Nguyễn Huy Thành', 1019, 11, 10, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1026, N'Võ Kim Hằng', 1019, 12, 10, 1000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1027, N'Lý Văn B', 1020, 8, 11, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1028, N'Lê Văn Toàn', 1020, 9, 11, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1029, N'Phạm Thanh Thanh', 1021, 10, 11, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1030, N'Nguyễn Thị Yến', 1021, 11, 11, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1031, N'Võ Thiên Vân', 1021, 12, 11, 1500000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1032, N'Lê Thị H', 1017, 1, 9, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1033, N'Lê Văn V', 1017, 2, 9, 3000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1034, N'Lý Thanh Tiêu', 1017, 3, 9, 2000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1035, N'Nguyễn Phi Yến', 1017, 4, 9, 2000000)
INSERT [dbo].[VeChuyenBay] ([maVe], [tenHK], [maHD], [maGhe], [maCB], [giaVe]) VALUES (1036, N'Trần Ngọc Hà', 1017, 5, 9, 2000000)
SET IDENTITY_INSERT [dbo].[VeChuyenBay] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ChucNang__DC107AB1BFE0FDF0]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[ChucNang] ADD UNIQUE NONCLUSTERED 
(
	[ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Ghe__A90E7FC36715DE94]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[Ghe] ADD UNIQUE NONCLUSTERED 
(
	[tenGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__LoaiMayB__99D4B5E369CB60B5]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[LoaiMayBay] ADD UNIQUE NONCLUSTERED 
(
	[tenLoaiMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__MayBay__FB74D084DED20680]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[MayBay] ADD UNIQUE NONCLUSTERED 
(
	[tenMB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NguoiDun__59267D4A53536F28]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[NguoiDung] ADD UNIQUE NONCLUSTERED 
(
	[tenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__QuyDinh__FB74F0034EF26DB8]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [UQ__QuyDinh__FB74F0034EF26DB8] UNIQUE NONCLUSTERED 
(
	[tenQD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SanBay__FB740043D0D84835]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[SanBay] ADD UNIQUE NONCLUSTERED 
(
	[tenSB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TienTrin__DC107AB10834BD8F]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[TienTrinh] ADD UNIQUE NONCLUSTERED 
(
	[ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TuyenBay__FB731BD71A5F0A96]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[TuyenBay] ADD UNIQUE NONCLUSTERED 
(
	[tenTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__VeChuyen__FB74B9713E74DD00]    Script Date: 17/04/2025 3:20:26 CH ******/
ALTER TABLE [dbo].[VeChuyenBay] ADD UNIQUE NONCLUSTERED 
(
	[tenHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD FOREIGN KEY([maTB])
REFERENCES [dbo].[TuyenBay] ([maTB])
GO
ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_TienTrinh] FOREIGN KEY([tienTrinhID])
REFERENCES [dbo].[TienTrinh] ([id])
GO
ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_TienTrinh]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD FOREIGN KEY([maMB])
REFERENCES [dbo].[MayBay] ([maMB])
GO
ALTER TABLE [dbo].[Ghe_ChuyenBay]  WITH CHECK ADD FOREIGN KEY([maGhe])
REFERENCES [dbo].[Ghe] ([maGhe])
GO
ALTER TABLE [dbo].[Ghe_ChuyenBay]  WITH CHECK ADD FOREIGN KEY([maCB])
REFERENCES [dbo].[ChuyenBay] ([maCB])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([maND])
REFERENCES [dbo].[NguoiDung] ([maND])
GO
ALTER TABLE [dbo].[MayBay]  WITH CHECK ADD FOREIGN KEY([maLoaiMB])
REFERENCES [dbo].[LoaiMayBay] ([maLoaiMB])
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_ChucNang] FOREIGN KEY([ChucNangId])
REFERENCES [dbo].[ChucNang] ([id])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_ChucNang]
GO
ALTER TABLE [dbo].[SanBayTrungGian]  WITH CHECK ADD FOREIGN KEY([maSB])
REFERENCES [dbo].[SanBay] ([maSB])
GO
ALTER TABLE [dbo].[SanBayTrungGian]  WITH CHECK ADD FOREIGN KEY([maTB])
REFERENCES [dbo].[TuyenBay] ([maTB])
GO
ALTER TABLE [dbo].[TuyenBay]  WITH CHECK ADD FOREIGN KEY([sanBayDi])
REFERENCES [dbo].[SanBay] ([maSB])
GO
ALTER TABLE [dbo].[TuyenBay]  WITH CHECK ADD FOREIGN KEY([sanBayDen])
REFERENCES [dbo].[SanBay] ([maSB])
GO
ALTER TABLE [dbo].[VeChuyenBay]  WITH CHECK ADD FOREIGN KEY([maHD])
REFERENCES [dbo].[HoaDon] ([maHD])
GO
ALTER TABLE [dbo].[VeChuyenBay]  WITH CHECK ADD FOREIGN KEY([maGhe], [maCB])
REFERENCES [dbo].[Ghe_ChuyenBay] ([maGhe], [maCB])
GO
ALTER TABLE [dbo].[ChucNang]  WITH CHECK ADD  CONSTRAINT [CK_ChucNang_Enum] CHECK  (([id]=(3) OR [id]=(2) OR [id]=(1)))
GO
ALTER TABLE [dbo].[ChucNang] CHECK CONSTRAINT [CK_ChucNang_Enum]
GO
ALTER TABLE [dbo].[TienTrinh]  WITH CHECK ADD  CONSTRAINT [CK_TienTrinh_Enum] CHECK  (([id]=(3) OR [id]=(2) OR [id]=(1)))
GO
ALTER TABLE [dbo].[TienTrinh] CHECK CONSTRAINT [CK_TienTrinh_Enum]
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSVeCuaHD]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDSVeCuaHD] @maHD INT
AS
BEGIN
	SELECT v.maVe, v.tenHK,v.maCB, g.tenGhe, v.giaVe, hd.maHD,
			CASE 
				WHEN gcb.trangThai = 0 THEN N'Chưa sử dụng' 
				ELSE N'Đã sử dụng' 
			END AS trangThai
    FROM VeChuyenBay v,HoaDon hd , Ghe g, Ghe_ChuyenBay gcb
    WHERE hd.maHD = v.maHD 
		AND v.maGhe = g.maGhe 
		AND v.maCB =gcb.maCB AND v.maGhe = gcb.maGhe 
		AND hd.maHD = @maHD
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LaySoLuongVeTheoNamThang]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LaySoLuongVeTheoNamThang] @thang INT, @nam INT
AS
BEGIN
	IF @thang IS NULL
	BEGIN
		SELECT COUNT(v.maVe) AS soLuongVe
		FROM VeChuyenBay v JOIN ChuyenBay cb ON v.maCB = cb.maCB
						   JOIN Ghe g ON v.maGhe = g.maGhe
		WHERE YEAR(cb.ngayGioDi) = @nam
		RETURN
	END
	SELECT COUNT(v.maVe) AS soLuongVe
	FROM VeChuyenBay v JOIN ChuyenBay cb ON v.maCB = cb.maCB
					   JOIN Ghe g ON v.maGhe = g.maGhe
	WHERE MONTH(cb.ngayGioDi) = @thang AND YEAR(cb.ngayGioDi) = @nam
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinHoaDon]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayThongTinHoaDon] @maHD INT
AS
BEGIN
	SELECT maHD,ngayLapHD,soLuongVe,phuongThucTT, tongTien, hoTenND AS nguoiLapHD
	FROM HoaDon, NguoiDung 
	WHERE HoaDon.maND = NguoiDung.maND AND maHD = @maHD
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayTongChuyenBay]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayTongChuyenBay] @thang INT, @nam INT
AS
BEGIN
	IF @thang IS NULL
	BEGIN
		SELECT COUNT(maCB) AS soLuongChuyenBay 
		FROM ChuyenBay 
		WHERE YEAR(ngayGioDi) = @nam

		RETURN
	END
	SELECT COUNT(maCB) AS soLuongChuyenBay 
	FROM ChuyenBay 
	WHERE MONTH(ngayGioDi) = @thang AND YEAR(ngayGioDi) = @nam
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeTheoThangNam]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThongKeTheoThangNam] @thang INT, @nam INT
AS
BEGIN
	IF @thang IS NULL
	BEGIN
		SELECT tb.maTB, tb.tenTB, SUM(v.giaVe) AS doanhThu, COUNT(DISTINCT cb.maCB) AS soLuotBay
		FROM TuyenBay tb FULL JOIN ChuyenBay cb ON tb.maTB = cb.maTB
						 FULL JOIN Ghe_ChuyenBay gcb ON cb.maCB = gcb.maCB
						 FULL JOIN VeChuyenBay v ON gcb.maGhe = v.maGhe AND cb.maCB = v.maCB
						 FULL JOIN HoaDon hd ON v.maHD = hd.maHD   
		WHERE  YEAR(cb.ngayGioDi) = @nam
		GROUP BY tb.maTB, tb.tenTB 
		ORDER BY doanhThu DESC

		RETURN
	END
	SELECT tb.maTB, tb.tenTB, SUM(v.giaVe) AS doanhThu, COUNT(DISTINCT cb.maCB) AS soLuotBay
	FROM TuyenBay tb FULL JOIN ChuyenBay cb ON tb.maTB = cb.maTB
					 FULL JOIN Ghe_ChuyenBay gcb ON cb.maCB = gcb.maCB
				     FULL JOIN VeChuyenBay v ON gcb.maGhe = v.maGhe AND cb.maCB = v.maCB
					 FULL JOIN HoaDon hd ON v.maHD = hd.maHD   
	WHERE MONTH(cb.ngayGioDi) = @thang AND YEAR(cb.ngayGioDi) = @nam
	GROUP BY tb.maTB, tb.tenTB 
	ORDER BY doanhThu DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuuThongTinVe]    Script Date: 17/04/2025 3:20:26 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraCuuThongTinVe]
    @maVe INT
AS
BEGIN
    SELECT 
        ve.maVe,
        ve.tenHK,
        hd.maHD,
        hd.ngayLapHD,
        cb.maCB,
        cb.ngayGioDi,
        tb.tenTB,
        sbDi.tinhThanh + ' - ' + sbDen.tinhThanh AS tuyenBay,
        g.tenGhe,
        g.hangGhe,
        ve.giaVe,
        CASE 
            WHEN gcb.trangThai = 0 THEN N'Chưa sử dụng' 
            ELSE N'Đã sử dụng' 
        END AS trangThai
    FROM VeChuyenBay ve
    JOIN HoaDon hd ON ve.maHD = hd.maHD
    JOIN Ghe_ChuyenBay gcb ON ve.maGhe = gcb.maGhe
    JOIN Ghe g ON gcb.maGhe = g.maGhe
    JOIN ChuyenBay cb ON cb.maCB = gcb.maCB
    JOIN TuyenBay tb ON cb.maTB = tb.maTB
    JOIN SanBay sbDi ON tb.sanBayDi = sbDi.maSB
    JOIN SanBay sbDen ON tb.sanBayDen = sbDen.maSB
    WHERE ve.maVe = @maVe
END
GO

--CREATE TRIGGER
--Kiểm tra số lượng sân bay trung gian
CREATE TRIGGER trg_CheckMaxIntermediateAirports
ON SanBayTrungGian
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @maxSB INT;
    SELECT @maxSB = noidungQD FROM QuyDinh WHERE tenQD = N'Số sân bay trung gian tối đa';

    IF EXISTS (
        SELECT maTB
        FROM (
            SELECT maTB, COUNT(*) AS SoLuong
            FROM SanBayTrungGian
            GROUP BY maTB
        ) AS Temp
        WHERE Temp.SoLuong > @maxSB
    )
    BEGIN
        RAISERROR(N'Số sân bay trung gian vượt quá giới hạn quy định.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO
--Kiểm tra thời gian dừng tối thiểu và tối đa
CREATE TRIGGER trg_CheckStopTimeRange
ON SanBayTrungGian
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @minStop INT, @maxStop INT;
    SELECT @minStop = noidungQD FROM QuyDinh WHERE tenQD = N'Thời gian dừng tối thiểu';
    SELECT @maxStop = noidungQD FROM QuyDinh WHERE tenQD = N'Thời gian dừng tối đa';

    IF EXISTS (
        SELECT 1 FROM inserted
        WHERE thoiGianDung < @minStop OR thoiGianDung > @maxStop
    )
    BEGIN
        RAISERROR(N'Thời gian dừng không nằm trong khoảng quy định.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO
USE [master]
GO
ALTER DATABASE [FlightManagement] SET  READ_WRITE 
GO
