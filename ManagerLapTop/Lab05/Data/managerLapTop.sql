USE [managerLapTop]
GO
/****** Object:  Table [dbo].[laptop]    Script Date: 20/12/2023 23:07:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[laptop](
	[LapTopID] [nvarchar](255) NULL,
	[LapTopName] [nvarchar](255) NULL,
	[LaptopType] [nvarchar](255) NULL,
	[ProductDate] [datetime] NULL,
	[Processor] [nvarchar](255) NULL,
	[HDD] [nvarchar](255) NULL,
	[RAM] [nvarchar](255) NULL,
	[Price] [float] NULL,
	[ImageName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
