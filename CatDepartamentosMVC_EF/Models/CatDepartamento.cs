//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CatDepartamento
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Range(1, 10, ErrorMessage = "Por Favor Ingresa un valor Correcto")]
        [Display(Name = "Id Oficina")]
        public int Id_Ofi { get; set; }

        public int Id_Depto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio"), MaxLength(30)]
        [DataType(DataType.Text)]
        [Display(Name = "Descripcion del Departamento")]
        public string Depto_Descripcion { get; set; }

        [Display(Name = "Departamento Activo")]
        public bool Depto_Activo { get; set; }
    }
}
