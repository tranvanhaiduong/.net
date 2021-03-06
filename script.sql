USE [datbancafe]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 08/01/2022 09:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Un] [nvarchar](50) NULL,
	[Pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datban]    Script Date: 08/01/2022 09:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datban](
	[Maban] [int] IDENTITY(1,1) NOT NULL,
	[SoBan] [nvarchar](50) NULL,
	[TenKhachHang] [ntext] NULL,
	[Ngay] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[XacNhan] [bit] NULL,
 CONSTRAINT [PK_datban] PRIMARY KEY CLUSTERED 
(
	[Maban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
