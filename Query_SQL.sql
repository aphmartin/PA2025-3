USE [master]
GO
/****** Object:  Database [POS]  ******/
CREATE DATABASE [POS]

CREATE TABLE [dbo].[Usuarios](
	[idk] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[apellidoP] [nvarchar](100) NULL,
	[apellidoM] [nvarchar](100) NULL,
	[correo] [nvarchar](100) NULL,
	[usuario] [nvarchar](20) NULL,
	[password] [nvarchar](20) NULL,
	[idPerfil] [int] NULL)

GO
/****** Object:  StoredProcedure [dbo].[proc_InsertarUsuario]    Script Date: 23/06/2025 04:02:29 p. m. ******/
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
           ,[AP1]
           ,[AP2]
           ,[EMAIL]
           ,[PASSWORD]
		   )
     VALUES
           (@NOMBRE
           ,@AP1
           ,@AP2
           ,@EMAIL
           ,@PASSWORD)


END
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertarUsuarios]    Script Date: 23/06/2025 04:02:29 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[proc_ValidaLogin]    Script Date: 23/06/2025 04:02:29 p. m. ******/
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
