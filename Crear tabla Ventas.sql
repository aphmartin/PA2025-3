USE [POS]
GO

/****** Object:  Table [dbo].[Ventas]    Script Date: 30/06/2025 11:57:57 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ventas](
	[clave] [varchar](30) NULL,
	[nombre] [varchar](50) NULL,
	[cantidad] [varchar](10) NULL,
	[precio] [decimal](8, 2) NULL,
	[importe] [decimal](8, 2) NULL,
	[fecha] [varchar](15) NULL
) ON [PRIMARY]
GO


