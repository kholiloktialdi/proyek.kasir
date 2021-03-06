USE [master]
GO
/****** Object:  Database [DB_KASIR]    Script Date: 06/03/2022 05:51:28 ******/
CREATE DATABASE [DB_KASIR] ON  PRIMARY 
( NAME = N'DB_KASIR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\DB_KASIR.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_KASIR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\DB_KASIR_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_KASIR] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_KASIR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_KASIR] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DB_KASIR] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DB_KASIR] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DB_KASIR] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DB_KASIR] SET ARITHABORT OFF
GO
ALTER DATABASE [DB_KASIR] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DB_KASIR] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DB_KASIR] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DB_KASIR] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DB_KASIR] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DB_KASIR] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DB_KASIR] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DB_KASIR] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DB_KASIR] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DB_KASIR] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DB_KASIR] SET  DISABLE_BROKER
GO
ALTER DATABASE [DB_KASIR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DB_KASIR] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DB_KASIR] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DB_KASIR] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DB_KASIR] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DB_KASIR] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DB_KASIR] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DB_KASIR] SET  READ_WRITE
GO
ALTER DATABASE [DB_KASIR] SET RECOVERY FULL
GO
ALTER DATABASE [DB_KASIR] SET  MULTI_USER
GO
ALTER DATABASE [DB_KASIR] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DB_KASIR] SET DB_CHAINING OFF
GO
USE [DB_KASIR]
GO
/****** Object:  Table [dbo].[TBL_BRNG]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_BRNG](
	[KodeBarang] [varchar](50) NOT NULL,
	[NamaBarang] [varchar](150) NULL,
	[HargaSatuan] [numeric](18, 0) NULL,
	[JenisSatuan] [varchar](50) NULL,
	[Stok] [int] NULL,
 CONSTRAINT [PK_TBL_BRNG] PRIMARY KEY CLUSTERED 
(
	[KodeBarang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_KASIR]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_KASIR](
	[KodeKasir] [varchar](6) NOT NULL,
	[NamaKasir] [varchar](150) NULL,
	[PasswordKasir] [varchar](50) NULL,
	[LevelKasir] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_KASIR] PRIMARY KEY CLUSTERED 
(
	[KodeKasir] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_PENJUALAN]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_PENJUALAN](
	[NoKwitansi] [varchar](50) NOT NULL,
	[TglKwitansi] [date] NOT NULL,
	[KodeKasir] [varchar](6) NOT NULL,
 CONSTRAINT [PK_TBL_PENJUALAN] PRIMARY KEY CLUSTERED 
(
	[NoKwitansi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_DETAILPENJUALAN]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_DETAILPENJUALAN](
	[NoKwitansi] [varchar](50) NOT NULL,
	[KodeBarang] [varchar](50) NOT NULL,
	[Jumlah] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_penjualan]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_penjualan]
AS
SELECT     dbo.TBL_PENJUALAN.NoKwitansi, dbo.TBL_PENJUALAN.TglKwitansi, dbo.TBL_PENJUALAN.KodeKasir, dbo.TBL_KASIR.NamaKasir
FROM         dbo.TBL_PENJUALAN INNER JOIN
                      dbo.TBL_KASIR ON dbo.TBL_PENJUALAN.KodeKasir = dbo.TBL_KASIR.KodeKasir
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_PENJUALAN"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 111
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_KASIR"
            Begin Extent = 
               Top = 6
               Left = 332
               Bottom = 126
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
/****** Object:  View [dbo].[vw_detail]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_detail]
AS
SELECT     dbo.TBL_DETAILPENJUALAN.NoKwitansi, dbo.TBL_DETAILPENJUALAN.KodeBarang, dbo.TBL_BRNG.NamaBarang, dbo.TBL_BRNG.HargaSatuan, dbo.TBL_BRNG.JenisSatuan, 
                      dbo.TBL_DETAILPENJUALAN.Jumlah
FROM         dbo.TBL_BRNG INNER JOIN
                      dbo.TBL_DETAILPENJUALAN ON dbo.TBL_BRNG.KodeBarang = dbo.TBL_DETAILPENJUALAN.KodeBarang
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_BRNG"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TBL_DETAILPENJUALAN"
            Begin Extent = 
               Top = 12
               Left = 312
               Bottom = 117
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
GO
/****** Object:  View [dbo].[vw_cetaktransaksi]    Script Date: 06/03/2022 05:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_cetaktransaksi]
AS
SELECT     dbo.TBL_DETAILPENJUALAN.NoKwitansi, dbo.TBL_PENJUALAN.TglKwitansi, dbo.TBL_PENJUALAN.KodeKasir, dbo.TBL_KASIR.NamaKasir, dbo.TBL_DETAILPENJUALAN.KodeBarang, 
                      dbo.TBL_BRNG.NamaBarang, dbo.TBL_BRNG.HargaSatuan, dbo.TBL_DETAILPENJUALAN.Jumlah, dbo.TBL_BRNG.HargaSatuan * dbo.TBL_DETAILPENJUALAN.Jumlah AS JumlahBayar
FROM         dbo.TBL_BRNG INNER JOIN
                      dbo.TBL_DETAILPENJUALAN ON dbo.TBL_BRNG.KodeBarang = dbo.TBL_DETAILPENJUALAN.KodeBarang INNER JOIN
                      dbo.TBL_PENJUALAN ON dbo.TBL_DETAILPENJUALAN.NoKwitansi = dbo.TBL_PENJUALAN.NoKwitansi INNER JOIN
                      dbo.TBL_KASIR ON dbo.TBL_PENJUALAN.KodeKasir = dbo.TBL_KASIR.KodeKasir
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_BRNG"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 126
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TBL_DETAILPENJUALAN"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 111
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_KASIR"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 126
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_PENJUALAN"
            Begin Extent = 
               Top = 114
               Left = 236
               Bottom = 219
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
GO
/****** Object:  ForeignKey [Relasi_Penjualan_Pelanggan]    Script Date: 06/03/2022 05:51:29 ******/
ALTER TABLE [dbo].[TBL_PENJUALAN]  WITH CHECK ADD  CONSTRAINT [Relasi_Penjualan_Pelanggan] FOREIGN KEY([KodeKasir])
REFERENCES [dbo].[TBL_KASIR] ([KodeKasir])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_PENJUALAN] CHECK CONSTRAINT [Relasi_Penjualan_Pelanggan]
GO
/****** Object:  ForeignKey [Relasi_Penjualan]    Script Date: 06/03/2022 05:51:29 ******/
ALTER TABLE [dbo].[TBL_DETAILPENJUALAN]  WITH CHECK ADD  CONSTRAINT [Relasi_Penjualan] FOREIGN KEY([NoKwitansi])
REFERENCES [dbo].[TBL_PENJUALAN] ([NoKwitansi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAILPENJUALAN] CHECK CONSTRAINT [Relasi_Penjualan]
GO
/****** Object:  ForeignKey [Relasi_Penjualan_Barang]    Script Date: 06/03/2022 05:51:29 ******/
ALTER TABLE [dbo].[TBL_DETAILPENJUALAN]  WITH CHECK ADD  CONSTRAINT [Relasi_Penjualan_Barang] FOREIGN KEY([KodeBarang])
REFERENCES [dbo].[TBL_BRNG] ([KodeBarang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_DETAILPENJUALAN] CHECK CONSTRAINT [Relasi_Penjualan_Barang]
GO
