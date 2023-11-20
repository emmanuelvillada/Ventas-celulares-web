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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class CelularReparacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CelularReparacion()
        {
            this.GarantiasReparacions = new HashSet<GarantiasReparacion>();
            this.Reparaciones = new HashSet<Reparacione>();
        }
    
        public int CelularReparacionID { get; set; }
        public Nullable<int> ModeloID { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
    
        public virtual Modelo Modelo { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GarantiasReparacion> GarantiasReparacions { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reparacione> Reparaciones { get; set; }
    }
}
