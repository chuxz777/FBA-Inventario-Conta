use fbb_inventario_contabiliad
go

----------------------------------------SP's---------------------------------------------
-----------------------------------------------------------------------------------------
-- Estados
-----------------------------------------------------------------------------------------
CREATE PROCEDURE SP_Estados_Seleccionar
AS
BEGIN
   SELECT id_estado AS 'Codigo del Estado',
		   descripcion AS 'Descripcion del Estado'
  FROM estado
  ORDER BY descripcion
END
GO


CREATE PROCEDURE SP_Insertar_Estados
@descripcion nvarchar(100)
AS
BEGIN
	INSERT  INTO [dbo].[estado]
				([descripcion])
			VALUES
			(@descripcion)
			SELECT MAX([id_estado]) FROM [estado];
END
GO

-----------------------------------------------------------------------------------------
-- Tipo Articulo
-----------------------------------------------------------------------------------------

CREATE PROCEDURE SP_Seleccionar_Tipo_Articulo
AS
BEGIN
	SELECT [id_tipo_articulo] AS 'Codigo del tipo de articulo',
		   [descripcion] AS 'Descripcion del tipo de articulo'

  FROM [dbo].[tipo_articulo]
END
GO

CREATE PROCEDURE SP_Insertar_Tipo_Articulo
@descripcion nvarchar(100)
AS
BEGIN
	INSERT  INTO [dbo].[tipo_articulo]
				([descripcion])
			VALUES
			(@descripcion)
			SELECT MAX([id_tipo_articulo]) FROM [tipo_articulo];
END
GO

CREATE PROCEDURE SP_Modificar_Tipo_Articulo
@id_tipo_articulo int,
@descripcion nvarchar(100)
AS
BEGIN
	UPDATE [dbo].[tipo_articulo]

	   SET [descripcion] = @descripcion

	 WHERE [id_tipo_articulo] = @id_tipo_articulo
END
GO

CREATE PROCEDURE SP_Eliminar_Tipo_Articulo
@id_tipo_articulo int
AS
BEGIN
	UPDATE [dbo].[tipo_articulo]
	   SET [descripcion] = 'I'
	 WHERE [id_tipo_articulo] = @id_tipo_articulo
END
GO

-----------------------------------------------------------------------------------------
-- Objetivo
-----------------------------------------------------------------------------------------

CREATE PROCEDURE SP_Seleccionar_Objetivo
AS
BEGIN
	SELECT [id_objetivo] AS 'Codigo del tipo de Objetivo',
		   [descripcion] AS 'Descripcion del objetivo para el artículo'

  FROM [dbo].[objetivo]
END
GO


CREATE PROCEDURE SP_Insertar_Objetivo
@descripcion nvarchar(100)
AS
BEGIN
	INSERT  INTO [dbo].[objetivo]
				([descripcion])
			VALUES
			(@descripcion)
			SELECT MAX([id_objetivo]) FROM [objetivo];
END
GO






-----------------------------------------------------------------------------------------
-- Departamento
-----------------------------------------------------------------------------------------
CREATE PROCEDURE SP_Seleccionar_Departamento
AS
BEGIN
	SELECT id_departamento AS 'Codigo del tipo de Departamento',
		   [descripcion] AS 'Descripcion del Departamento'

  FROM [dbo].[departamento]
END
GO

CREATE PROCEDURE SP_Insertar_Departamento
@descripcion nvarchar(100)
AS
BEGIN
	INSERT  INTO [dbo].[departamento]
				([descripcion])
			VALUES
			(@descripcion)
			SELECT MAX([id_departamento]) FROM [departamento];
END
GO


CREATE PROCEDURE SP_Modificar_Departamento
@id_departamento int,
@descripcion nvarchar(100)
AS
BEGIN
	UPDATE [dbo].[departamento]
	   SET [descripcion] = @descripcion
	 WHERE id_departamento = @id_departamento
END
GO





-----------------------------------------------------------------------------------------
-- Color
-----------------------------------------------------------------------------------------


CREATE PROCEDURE SP_Seleccionar_Color
AS
BEGIN
	SELECT [id_color] AS 'Codigo del Color',
		   [nombre_color] AS 'Descripcion del Color'
  FROM color
END
GO


CREATE PROCEDURE SP_Insertar_Color
@descripcion nvarchar(100)
AS
BEGIN
	INSERT  INTO [dbo].[color]
				([nombre_color])
 VALUES
			(@descripcion)
			SELECT MAX([id_color]) FROM [color];
END
GO

CREATE PROCEDURE SP_Modificar_Color
@id_color int,
@descripcion nvarchar(100)
AS
BEGIN
	UPDATE [dbo].[color]
	   SET [nombre_color] = @descripcion
	 WHERE [id_color] = @id_color
END
GO


-----------------------------------------------------------------------------------------
-- Inventario
-----------------------------------------------------------------------------------------

---- Pendiente
--CREATE PROCEDURE SP_Filtrar_Inventario
--@valor nvarchar(100)
--AS
--BEGIN
--	SELECT 
--		cod_tipo_articulo AS 'Codigo del tipo de articulo',
--		cod_departamento AS 'Codigo del Departamento',
--		precio_sugerido AS 'Precio',
--		fecha_entrada_inv AS 'Fecha de Entrada',
--		cod_color AS 'Codigo del Color',
--		cod_objetivo AS 'Codigo del Objetivo',
--		cod_estado AS 'Codigo del Estado'
--  FROM [dbo].[tipo_articulo]
--  where cod_tipo_articulo = @valor
--END
--GO


CREATE PROCEDURE SP_Seleccionar_Inventario
AS	
BEGIN
SELECT 
		i.id_articulo AS 'Codigo del Articulo',
		ta.descripcion 'Tipo de articulo',
		d.descripcion AS ' Departamento',
		i.precio_sugerido AS 'Precio',
		i.fecha_entrada_inv AS 'Fecha de Entrada',
		o.descripcion AS 'Objetivo',
		e.descripcion 'Estado'
  FROM INVENTARIO as i
  INNER JOIN 
	DEPARTAMENTO as d 
	on i.cod_departamento = d.id_departamento
  INNER JOIN
	OBJETIVO as o
	on i.cod_objetivo = o.id_objetivo
  INNER JOIN
	Estado as e
	on i.cod_estado = e.id_estado
  INNER JOIN 
	tipo_articulo as ta
	on i.cod_tipo_articulo = ta.id_tipo_articulo
END
GO



--exec SP_Seleccionar_Inventario
--GO

CREATE PROCEDURE SP_Modificar_Inventario
@id_articulo int,
@cod_tipo_articulo int,
@cod_departamento int,
@precio_sugerido decimal,
@fecha_entrada_inv datetime,
@cod_color int,
@cod_objetivo int,
@cod_estado int
AS
BEGIN
	UPDATE [dbo].[inventario]
	   SET [cod_tipo_articulo] = @cod_tipo_articulo
		  ,[cod_departamento] = @cod_departamento
		  ,[precio_sugerido] = @precio_sugerido 
		  ,[fecha_entrada_inv] = @fecha_entrada_inv
		  ,[cod_color] = @cod_color
		  ,[cod_objetivo] = @cod_objetivo
		  ,[cod_estado] = @cod_estado 
	 WHERE [id_articulo] = @id_articulo
END
GO


CREATE PROCEDURE SP_Marcar_Vendido
@id_articulo int,
@cod_estado int
AS
BEGIN
	UPDATE [dbo].[inventario]
	   SET [cod_estado] = @cod_estado 
	 WHERE [id_articulo] = @id_articulo
END
GO




CREATE PROCEDURE SP_Insertar_Inventario
@cod_tipo_articulo int,
@cod_departamento int,
@precio_sugerido decimal,
@fecha_entrada_inv datetime,
@cod_color int,
@cod_objetivo int,
@cod_estado int
AS
BEGIN
	INSERT INTO [dbo].[inventario]
			   ([cod_tipo_articulo]
			   ,[cod_departamento]
			   ,[precio_sugerido]
			   ,[fecha_entrada_inv]
			   ,[cod_color]
			   ,[cod_objetivo]
			   ,[cod_estado])
		 VALUES
			   (@cod_tipo_articulo ,
				@cod_departamento ,
				@precio_sugerido ,
				@fecha_entrada_inv ,
				@cod_color ,
				@cod_objetivo ,
				@cod_estado)
END
GO


CREATE PROCEDURE SP_Marcar_Productos_Vendidos
@id_articulo int
AS
BEGIN
	UPDATE [dbo].[inventario]
	   SET 
	   [cod_estado] = 4
	 WHERE [id_articulo] = @id_articulo
END 
GO


CREATE PROCEDURE SP_Seleccionar_ProdID_Venta
@cant int,
@año int,
@mes int,
@cod_articulo int
AS
BEGIN
SET ROWCOUNT @cant
SELECT  * FROM inventario as t1
INNER JOIN tipo_articulo as t2 
on t1.cod_tipo_articulo = t2.id_tipo_articulo
WHERE t1.cod_tipo_articulo = @cod_articulo and 
	t1.cod_objetivo = 1 and -- codigo para vender
	YEAR(t1.fecha_entrada_inv) = @año and 
	MONTH(t1.fecha_entrada_inv) = @mes
	and cod_estado <> 4

END
GO


-----------------------------------------------------------------------------------------
-- Venta y Factura
-----------------------------------------------------------------------------------------

USE [fbb_inventario_contabiliad]
GO
CREATE PROCEDURE SP_Detalle_Factura
@factura int,
@id_articulo int
AS
BEGIN
	INSERT INTO [dbo].[detalle_factura]
			   ([num_factura]
			   ,[id_articulo])
		 VALUES
			   (@factura, @id_articulo)
END
GO


USE [fbb_inventario_contabiliad]
GO

ALTER PROCEDURE SP_Crear_Venta_Blanca
@total int
AS
BEGIN
INSERT INTO [dbo].[venta]
           ([fecha_venta]
           ,[total]
           ,[estado_factura])
     VALUES
           (GETDATE(),
           @total, -- total
           3 )-- Estado
SELECT MAX(id_factura) FROM [dbo].[venta]
END
GO