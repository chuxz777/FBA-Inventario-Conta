
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
SELECT MAX(id_factura) as 'id_factura' FROM [dbo].[venta] 
END
GO

exec SP_Crear_Venta_Blanca 10000



select * from [detalle_factura]

select * from venta


exec SP_Marcar_Productos_Vendidos 1


select * from venta



-- Ver Facturas
select 
t1.num_factura, 
t2.fecha_venta, 
t2.estado_factura, 
t3.precio_sugerido,
t5.descripcion,
t4.descripcion
 from detalle_factura  as t1
inner join venta as t2 
on t1.num_factura = t2.id_factura 
inner join inventario as t3 
on t3.id_articulo = t1.id_articulo 
inner join tipo_articulo as t4 
on t1.id_articulo = t4.id_tipo_articulo
inner join departamento as t5
on t3.cod_departamento = t5.id_departamento

