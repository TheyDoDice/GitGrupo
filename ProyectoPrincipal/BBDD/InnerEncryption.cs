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
    
    public partial class InnerEncryption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InnerEncryption()
        {
            this.CoordinateKeys = new HashSet<CoordinateKeys>();
            this.InnerEncryptionData = new HashSet<InnerEncryptionData>();
        }
    
        public int idInnerEncryption { get; set; }
        public int idPlanet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoordinateKeys> CoordinateKeys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InnerEncryptionData> InnerEncryptionData { get; set; }
        public virtual Planets Planets { get; set; }
    }
}
