﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatDepartamentosMVC_EF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Ejemplo1Entities1 : DbContext
    {
        public Ejemplo1Entities1()
            : base("name=Ejemplo1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatDepartamento> CatDepartamento { get; set; }
    
        public virtual ObjectResult<spCatDepartamento_Combo_Result> spCatDepartamento_Combo(Nullable<int> id1)
        {
            var id1Parameter = id1.HasValue ?
                new ObjectParameter("Id1", id1) :
                new ObjectParameter("Id1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCatDepartamento_Combo_Result>("spCatDepartamento_Combo", id1Parameter);
        }
    
        public virtual ObjectResult<spCatDepartamento_Consulta_Result> spCatDepartamento_Consulta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCatDepartamento_Consulta_Result>("spCatDepartamento_Consulta");
        }
    
        public virtual ObjectResult<Nullable<int>> spCatDepartamento_Insertar(Nullable<int> id_Ofi, string depto_Descripcion, Nullable<bool> depto_Activo, ObjectParameter mensaje)
        {
            var id_OfiParameter = id_Ofi.HasValue ?
                new ObjectParameter("Id_Ofi", id_Ofi) :
                new ObjectParameter("Id_Ofi", typeof(int));
    
            var depto_DescripcionParameter = depto_Descripcion != null ?
                new ObjectParameter("Depto_Descripcion", depto_Descripcion) :
                new ObjectParameter("Depto_Descripcion", typeof(string));
    
            var depto_ActivoParameter = depto_Activo.HasValue ?
                new ObjectParameter("Depto_Activo", depto_Activo) :
                new ObjectParameter("Depto_Activo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spCatDepartamento_Insertar", id_OfiParameter, depto_DescripcionParameter, depto_ActivoParameter, mensaje);
        }
    
        public virtual ObjectResult<Nullable<int>> spCatDepartamento_Modificar(Nullable<int> id_Ofi, Nullable<int> id_Depto, string depto_Descripcion, Nullable<bool> depto_Activo, ObjectParameter mensaje)
        {
            var id_OfiParameter = id_Ofi.HasValue ?
                new ObjectParameter("Id_Ofi", id_Ofi) :
                new ObjectParameter("Id_Ofi", typeof(int));
    
            var id_DeptoParameter = id_Depto.HasValue ?
                new ObjectParameter("Id_Depto", id_Depto) :
                new ObjectParameter("Id_Depto", typeof(int));
    
            var depto_DescripcionParameter = depto_Descripcion != null ?
                new ObjectParameter("Depto_Descripcion", depto_Descripcion) :
                new ObjectParameter("Depto_Descripcion", typeof(string));
    
            var depto_ActivoParameter = depto_Activo.HasValue ?
                new ObjectParameter("Depto_Activo", depto_Activo) :
                new ObjectParameter("Depto_Activo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spCatDepartamento_Modificar", id_OfiParameter, id_DeptoParameter, depto_DescripcionParameter, depto_ActivoParameter, mensaje);
        }
    }
}
