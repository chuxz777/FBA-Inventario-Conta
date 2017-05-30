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
		cod_tipo_articulo AS 'Codigo del tipo de articulo',
		cod_departamento AS 'Codigo del Departamento',
		precio_sugerido AS 'Precio',
		fecha_entrada_inv AS 'Fecha de Entrada',
		cod_color AS 'Codigo del Color',
		cod_objetivo AS 'Codigo del Objetivo',
		cod_estado AS 'Codigo del Estado'
  FROM [dbo].[inventario]
END
GO



exec SP_Seleccionar_Inventario


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

-----------------------------------------------------------------------------------------
-- Venta
-----------------------------------------------------------------------------------------


CREATE PROCEDURE SP_Insertar_Venta
@cod_aticulo int,
@precio_venta decimal,
@fecha_venta datetime,
@total decimal
AS
BEGIN
	INSERT INTO [dbo].[venta]
			   ([cod_aticulo]
			   ,[precio_venta]
			   ,[fecha_venta]
			   ,[total])
		 VALUES
			( @cod_aticulo,
			  @precio_venta,
			  @fecha_venta,
			  @total)
END
GO

CREATE PROCEDURE SP_Actualizar_Venta
@id_factura int,
@cod_aticulo int,
@precio_venta decimal,
@fecha_venta datetime,
@total decimal
AS
BEGIN
	UPDATE [dbo].[venta]
	   SET [cod_aticulo] = @cod_aticulo
		  ,[precio_venta] = @precio_venta
		  ,[fecha_venta] = @fecha_venta
		  ,[total] = @total
	 WHERE id_factura = @id_factura
END
GO

-----------------------------------------------------------------------------------------
-- Factura
-----------------------------------------------------------------------------------------

--CREATE PROCEDURE SP_Insertar_Factura
--AS
--BEGIN
--	SELECT [id_factura]
--		  ,[cod_aticulo]
--		  ,[precio_venta]
--		  ,[fecha_venta]
--		  ,[total]
--	  FROM [dbo].[venta]
--END
--GO