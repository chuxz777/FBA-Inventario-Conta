use master
go

create database fbb_inventario_contabiliad
go

use fbb_inventario_contabiliad
go

-----------------------------------------------------------------------------------------------------
CREATE TABLE estado
(
	id_estado 			                int identity(1,1) constraint pk_estado primary key NOT NULL,
	descripcion 		                nvarchar(100) NOT NULL UNIQUE
)
go

-----------------------------------------------------------------------------------------------------
create table tipo_articulo
(
	id_tipo_articulo					int identity(1,1) constraint pk_articulo primary key NOT NULL,
	descripcion							nvarchar(100) NOT NULL UNIQUE

)
-----------------------------------------------------------------------------------------------------

create table objetivo
(
	id_objetivo							int identity  (1,1) constraint pk_objetivo primary key NOT NULL,
	descripcion							nvarchar(100) NOT NULL UNIQUE
)

-----------------------------------------------------------------------------------------------------
create table departamento
(
	id_departamento						int identity (1,1) constraint pk_departamento primary key NOT NULL,
	descripcion							nvarchar(100) NOT NULL UNIQUE

)
-----------------------------------------------------------------------------------------------------
create table color
(
	id_color						int identity (1,1) constraint pk_color primary key NOT NULL,
	[nombre_color]					nvarchar(100) NOT NULL UNIQUE

)
-----------------------------------------------------------------------------------------------------
create table inventario
(
	id_articulo						    int identity (1,1) constraint pk_inventario primary key NOT NULL,
	cod_tipo_articulo                   int constraint fk_inv_tip_artic  foreign key references tipo_articulo(id_tipo_articulo) NOT NULL,
	cod_departamento					int constraint fk_inv_depto foreign key references departamento(id_departamento) NOT NULL ,	 
	precio_sugerido                 	decimal NOT NULL,                  
	fecha_entrada_inv                   datetime NOT NULL,	     
	cod_color							int constraint fk_inv_color foreign key references color(id_color) NOT NULL,
	cod_objetivo						int constraint fk_inv_objetivo foreign key references objetivo(id_objetivo) NOT NULL, 
	cod_estado							int constraint fk_inv_estado foreign key references estado(id_estado) NOT NULL
)
-----------------------------------------------------------------------------------------------------
create table venta
(
    id_factura              	        int identity(1,1) constraint pk_Tbl_Roles primary key NOT NULL,
	cod_aticulo							int,
	precio_venta						decimal,
	fecha_venta							datetime NOT NULL,
	total								decimal
)

-----------------------------------------------------------------------------------------------------
--create table facturas_gastos
--(
--	moto
--	detalle



--)
-----------------------------------------------------------------------------------------------------
--create table donaciones_ingresos
--(



--)
-----------------------------------------------------------------------------------------------------

create table roles
(
    id_rol                      	    int identity(1,1) constraint pk_Tbl_Roles primary key NOT NULL,
	funcion								nvarchar(50),
)
-----------------------------------------------------------------------------------------------------
create table usuarios
(
	id_usuario							int identity(1,1) constraint pk_usuario primary key NOT NULL,
	nombre_usuario						nvarchar(70) UNIQUE, 
	email								nvarchar(150) UNIQUE,
	contraseña							nvarchar(10),
	cod_rol								int
)
GO
-----------------------------------------------------------------------------------------------------