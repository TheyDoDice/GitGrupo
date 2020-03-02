//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Routes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Routes()
        {
            this.DefinedRoutes = new HashSet<DefinedRoutes>();
            this.PlanetRoutes = new HashSet<PlanetRoutes>();
        }
    
        public int idRoute { get; set; }
        public string CodeRoute { get; set; }
        public string DescRoute { get; set; }
        public Nullable<int> idPlanetOr { get; set; }
        public Nullable<int> idPlanetDest { get; set; }
        public Nullable<int> idRouteType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefinedRoutes> DefinedRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanetRoutes> PlanetRoutes { get; set; }
        public virtual RouteTypes RouteTypes { get; set; }
    }
}