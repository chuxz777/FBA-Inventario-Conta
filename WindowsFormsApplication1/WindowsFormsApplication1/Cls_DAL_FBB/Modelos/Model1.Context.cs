﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cls_DAL_FBB.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class fbb_inventario_contabiliadEntities3 : DbContext
    {
        public fbb_inventario_contabiliadEntities3()
            : base("name=fbb_inventario_contabiliadEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<color> color { get; set; }
        public virtual DbSet<conta> conta { get; set; }
        public virtual DbSet<detalle> detalle { get; set; }
        public virtual DbSet<donacion> donacion { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<tipo_articulo> tipo_articulo { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<venta> venta { get; set; }
    }
}
