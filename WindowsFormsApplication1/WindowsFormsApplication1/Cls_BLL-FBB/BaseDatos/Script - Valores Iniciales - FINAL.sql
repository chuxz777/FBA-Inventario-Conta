USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[color]
           ([nombre_color])
     VALUES
           ('Azul')
GO

USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[departamento]
           ([descripcion])
     VALUES
           ('Hombre')
GO


USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[estado]
           ([descripcion])
     VALUES
           ('Nuevo')
GO


USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[objetivo]
           ([descripcion])
     VALUES
           ('Vender')
GO


USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[tipo_articulo]
           ([descripcion])
     VALUES
           ('Camisa Polo')
GO

USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[inventario]
           ([cod_tipo_articulo]
           ,[cod_departamento]
           ,[precio_sugerido]
           ,[fecha_entrada_inv]
           ,[cod_color]
           ,[cod_objetivo]
           ,[cod_estado])
     VALUES
           (1,
           1,
           1000,
           GETDATE(),
           1,
           1,
           1)
GO





