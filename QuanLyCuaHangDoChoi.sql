CREATE DATABASE [ToyStore]
GO
USE [ToyStore]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/6/2021 6:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_HD] [int] NOT NULL,
	[ID_DC] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoChoi]    Script Date: 12/6/2021 6:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoChoi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](3000) NOT NULL,
	[ID_Loai] [int] NOT NULL,
	[DoTuoi] [nvarchar](100) NULL,
	[XuatXu] [nvarchar](1000) NULL,
	[ThuongHieu] [nvarchar](1000) NULL,
	[SoLuongTon] [int] NOT NULL,
	[GiaBan] [int] NOT NULL,
	[GiaNhap] [int] NOT NULL,
	[HinhAnh] [varchar](max) NULL,
 CONSTRAINT [PK_DoChoi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/6/2021 6:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](1000) NULL,
	[SDT] [nvarchar](1000) NULL,
	[NgayBan] [smalldatetime] NOT NULL,
	[NgayNhap] [smalldatetime] NULL,
	[KhuyenMai] [decimal](2, 2) NULL,
	[ID_NV] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 12/6/2021 6:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](1000) NOT NULL,
	[MoTa] [nvarchar](3000) NULL,
	[ID_Cha] [int] NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/6/2021 6:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](1000) NULL,
	[DiaChi] [nvarchar](1000) NULL,
	[SDT] [varchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DoChoi] ON 

INSERT [dbo].[DoChoi] ([ID], [TenSanPham], [ID_Loai], [DoTuoi], [XuatXu], [ThuongHieu], [SoLuongTon], [GiaBan], [GiaNhap], [HinhAnh]) VALUES (1, N'Mô hình Bumblebee', 3, N'3 Tuổi trở lên', N'Việt Nam', N'TRANSFORMER', 30, 50000, 40000, N'D:\Github\ToyStoresManagement-Winform-CSharp\ToyStoreManagement\ToyStoreManagement\Resources\Sieuxe.jpg')
INSERT [dbo].[DoChoi] ([ID], [TenSanPham], [ID_Loai], [DoTuoi], [XuatXu], [ThuongHieu], [SoLuongTon], [GiaBan], [GiaNhap], [HinhAnh]) VALUES (2, N'Phòng Thí Nghiệm Của Gru', 4, N'12 Tuổi trở lên', N'Mỹ', N'LEGO MINIONS', 15, 120000, 100000, NULL)
INSERT [dbo].[DoChoi] ([ID], [TenSanPham], [ID_Loai], [DoTuoi], [XuatXu], [ThuongHieu], [SoLuongTon], [GiaBan], [GiaNhap], [HinhAnh]) VALUES (7, N'Công chúa Ariel', 5, N'3 - 9 Tuổi', N'Trung Quốc', N'DISNEY PRINCESS', 5, 30000, 15000, NULL)
INSERT [dbo].[DoChoi] ([ID], [TenSanPham], [ID_Loai], [DoTuoi], [XuatXu], [ThuongHieu], [SoLuongTon], [GiaBan], [GiaNhap], [HinhAnh]) VALUES (8, N'Pony bông', 6, N'3 Tuổi trở lên', N'Việt Nam', N'MY LITTLE PONY', 250, 90000, 80000, NULL)
SET IDENTITY_INSERT [dbo].[DoChoi] OFF
GO
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([ID], [TenLoai], [MoTa], [ID_Cha]) VALUES (1, N'Bé Trai', NULL, NULL)
INSERT [dbo].[Loai] ([ID], [TenLoai], [MoTa], [ID_Cha]) VALUES (2, N'Bé Gái', NULL, NULL)
INSERT [dbo].[Loai] ([ID], [TenLoai], [MoTa], [ID_Cha]) VALUES (3, N'Robot', NULL, 1)
INSERT [dbo].[Loai] ([ID], [TenLoai], [MoTa], [ID_Cha]) VALUES (4, N'Lego', NULL, 1)
INSERT [dbo].[Loai] ([ID], [TenLoai], [MoTa], [ID_Cha]) VALUES (5, N'Búp bê', NULL, 2)
INSERT [dbo].[Loai] ([ID], [TenLoai], [MoTa], [ID_Cha]) VALUES (6, N'Thú nhồi bông', NULL, 2)
SET IDENTITY_INSERT [dbo].[Loai] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_DoChoi] FOREIGN KEY([ID_DC])
REFERENCES [dbo].[DoChoi] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_DoChoi]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([ID_HD])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[DoChoi]  WITH CHECK ADD  CONSTRAINT [FK_DoChoi_Loai] FOREIGN KEY([ID_Loai])
REFERENCES [dbo].[Loai] ([ID])
GO
ALTER TABLE [dbo].[DoChoi] CHECK CONSTRAINT [FK_DoChoi_Loai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[Toy_GetAll]    Script Date: 12/6/2021 6:45:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Toy_GetAll]
as
	select * from DoChoi
GO
