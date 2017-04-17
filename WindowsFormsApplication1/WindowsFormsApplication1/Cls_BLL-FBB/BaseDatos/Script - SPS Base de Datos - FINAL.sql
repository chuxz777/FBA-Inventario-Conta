----------------------------------------SP's---------------------------------------------

-----------------------------------------------------------------------------------------
-- Estados
-----------------------------------------------------------------------------------------
CREATE PROCEDURE SP_Estados_Seleccionar
AS
BEGIN
	SELECT * from estado order by descripcion
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

CREATE PROCEDURE SP_Seleccionar_Tipo_Articulo
AS
BEGIN
	SELECT [id_tipo_articulo] AS 'Codigo del tipo de articulo',
		   [descripcion] AS 'Descripcion del tipo de articulo'

  FROM [dbo].[tipo_articulo]
END
GO


-----------------------------------------------------------------------------------------
-- Objetivo
-----------------------------------------------------------------------------------------

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

CREATE PROCEDURE SP_Insertar_Color
@descripcion nvarchar(100)
AS
BEGIN
	INSERT  INTO [dbo].[color]
				([descripcion])
			VALUES
			(@descripcion)
			SELECT MAX([id_color]) FROM [color];
END
GO



-----------------------------------------------------------------------------------------
-- Inventario
-----------------------------------------------------------------------------------------

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
@total decimal,
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

CREATE PROCEDURE SP_Insertar_Venta
AS
BEGIN
	UPDATE [dbo].[venta]
	   SET [cod_aticulo] = <cod_aticulo, int,>
		  ,[precio_venta] = <precio_venta, decimal(18,0),>
		  ,[fecha_venta] = <fecha_venta, datetime,>
		  ,[total] = <total, decimal(18,0),>
	 WHERE <Search Conditions,,>
GO

-----------------------------------------------------------------------------------------
-- Factura
-----------------------------------------------------------------------------------------

CREATE PROCEDURE SP_Insertar_Factura
AS
BEGIN
	SELECT [id_factura]
		  ,[cod_aticulo]
		  ,[precio_venta]
		  ,[fecha_venta]
		  ,[total]
	  FROM [dbo].[venta]
GO