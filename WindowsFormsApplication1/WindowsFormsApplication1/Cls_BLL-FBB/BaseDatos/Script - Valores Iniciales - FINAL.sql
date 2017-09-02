USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[color]
           ([nombre_color])
     VALUES
           ('Azul')
GO

INSERT INTO [dbo].[color]
           ([nombre_color])
     VALUES
           ('Rojo')
GO

INSERT INTO [dbo].[color]
           ([nombre_color])
     VALUES
           ('Verde')
GO

USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[departamento]
           ([descripcion])
     VALUES
           ('Hombre')
GO

INSERT INTO [dbo].[departamento]
           ([descripcion])
     VALUES
           ('Mujer')
GO


INSERT INTO [dbo].[departamento]
           ([descripcion])
     VALUES
           ('Bebe')
GO

INSERT INTO [dbo].[departamento]
           ([descripcion])
     VALUES
           ('Zapatos')
GO

INSERT INTO [dbo].[departamento]
           ([descripcion])
     VALUES
           ('Juguetes')
GO

USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[estado]
           ([descripcion])
     VALUES
           ('Nuevo') -- 1
GO

INSERT INTO [dbo].[estado]
           ([descripcion])
     VALUES
           ('Creado') -- 2
GO

INSERT INTO [dbo].[estado]
           ([descripcion])
     VALUES
           ('Pagado') --3
GO

INSERT INTO [dbo].[estado]
           ([descripcion])
     VALUES
           ('Vendido') -- 4
GO


USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[objetivo]
           ([descripcion])
     VALUES
           ('Vender')
GO


INSERT INTO [dbo].[objetivo]
           ([descripcion])
     VALUES
           ('Donar')
GO


INSERT INTO [dbo].[objetivo]
           ([descripcion])
     VALUES
           ('Desechar')
GO

USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[tipo_articulo]
           ([descripcion])
     VALUES
           ('Camisa Polo')
GO

INSERT INTO [dbo].[tipo_articulo]
           ([descripcion])
     VALUES
           ('Blusa')
GO

INSERT INTO [dbo].[tipo_articulo]
           ([descripcion])
     VALUES
           ('Pantalon')
GO

INSERT INTO [dbo].[tipo_articulo]
           ([descripcion])
     VALUES
           ('Sudadera')
GO



USE [fbb_inventario_contabiliad]
GO

INSERT INTO [dbo].[categoria_gastos]([descripcion]) VALUES ('Alimentación')
GO
INSERT INTO [dbo].[categoria_gastos]([descripcion]) VALUES ('Edificio')
GO
INSERT INTO [dbo].[categoria_gastos]([descripcion]) VALUES ('Recibos')
GO
INSERT INTO [dbo].[categoria_gastos]([descripcion]) VALUES ('Materiales de Escuela')
GO
INSERT INTO [dbo].[categoria_gastos]([descripcion]) VALUES ('Actividades')
GO
INSERT INTO [dbo].[categoria_gastos]([descripcion]) VALUES ('Pago de Prestamos')
GO




