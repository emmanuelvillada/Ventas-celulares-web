//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosCelulares.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GarantiasReparacion
    {
        public int GarantiaReparacionID { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> CelularReparacionID { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public string DescripcionGarantia { get; set; }
    
        public virtual CelularReparacion CelularReparacion { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
