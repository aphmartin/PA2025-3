

/****** Object:  Database [POS]    Script Date: 26/06/2025 03:22:54 p. m. ******/
CREATE DATABASE [POS]

USE [POS]

/****** Object:  Table [dbo].[Productos]    Script Date: 26/06/2025 03:22:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[idk] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[clave] [varchar](30) NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](100) NULL,
	[precioCompra] [decimal](8, 2) NULL,
	[precioVenta] [decimal](8, 2) NULL,
	[existencia] [int] NULL,
	[ubicacion] [varchar](50) NULL,
	[unidadMedida] [varchar](20) NULL,
	[minimo] [int] NULL,
	[maximo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/06/2025 03:22:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idk] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[apellidoP] [nvarchar](100) NULL,
	[apellidoM] [nvarchar](100) NULL,
	[correo] [nvarchar](100) NULL,
	[usuario] [nvarchar](20) NULL,
	[password] [nvarchar](20) NULL,
	[idPerfil] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [idProducto]
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertarProducto]    Script Date: 26/06/2025 03:22:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_InsertarProducto]
	-- Add the parameters for the stored procedure here
@clave as varchar(10),
@nombre as varchar(50),
@descripcion as varchar(10),
@unidadmedida as varchar(10),
@existencia as varchar(10),
@preciocompra as varchar(10),
@precioventa as varchar(10),
@ubicacion as varchar(10),
@minimo as int,
@maximo as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 
INSERT INTO [Productos]
           (
           
           [clave]
           ,[nombre]
           ,[descripcion]
           ,[precioCompra]
           ,[precioVenta]
           ,[existencia]
           ,[ubicacion]
           ,[unidadMedida]
           ,[minimo]
           ,[maximo])
     VALUES
           (
         
           @clave,
           @nombre,
           @descripcion,
           @preciocompra,
           @precioventa,
           @existencia,
           @ubicacion,
           @unidadmedida
           ,@minimo,
           @maximo)


END
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertarUsuario]    Script Date: 26/06/2025 03:22:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_InsertarUsuario]
	-- Add the parameters for the stored procedure here
		   @NOMBRE as varchar(50)
           ,@AP1 as varchar(50)
           ,@AP2  as varchar(50)
           ,@EMAIL as varchar(50)
		   ,@USER as varchar(50)
           ,@PASSWORD as varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

INSERT INTO [dbo].[Usuarios]
           (
		   [NOMBRE]
           ,[apellidoP]
           ,[apellidoM]
           ,[correo]
           ,[usuario]
		   ,[password]
		   )
     VALUES
           (@NOMBRE
           ,@AP1
           ,@AP2
           ,@EMAIL
		   ,@USER
           ,@PASSWORD)


END
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertarUsuarios]    Script Date: 26/06/2025 03:22:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--INSERTAR 
create proc [dbo].[proc_InsertarUsuarios]
@nombre nvarchar (100),
@apellidoP nvarchar (100),
@apellidoM nvarchar (100),
@correo nvarchar (100),
@usuario nvarchar (20),
@password nvarchar(20),
@idPerfil int
as
insert into Usuarios values (@nombre,@apellidoP,@apellidoM,@correo,@usuario, @password, @idPerfil)
GO
/****** Object:  StoredProcedure [dbo].[proc_ValidaLogin]    Script Date: 26/06/2025 03:22:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--validar login
CREATE proc [dbo].[proc_ValidaLogin]
@usuario nvarchar(20),
@pwd nvarchar (20)
as
select usuario, nombre+ ' '+apellidoP + ' '+apellidoM as nombre from Usuarios where usuario=@usuario and password=@pwd
GO
USE [master]
GO
ALTER DATABASE [POS] SET  READ_WRITE 
GO
