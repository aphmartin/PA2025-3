USE [POS]
GO

/****** Object:  StoredProcedure [dbo].[proc_InsertarVenta]    Script Date: 30/06/2025 11:58:49 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[proc_InsertarVenta]
@clave as varchar(10),
@nombre  as varchar(50),
@cantidad  as varchar(10),
@precio  as decimal(8,2),
@importe  as decimal(8,2),
@fecha  as varchar(15)

as

begin

insert into Ventas
(clave ,
  nombre, 
  cantidad, 
  precio ,
  importe ,
  fecha )

  values (@clave,@nombre,@cantidad,@precio,@importe,@fecha)
end

GO


