namespace WFApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            LocationFinished = new HashSet<LocationFinished>();
            LocationTrial = new HashSet<LocationTrial>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int IdCity { get; set; }

        public int? CityId { get; set; }

        public string Clue { get; set; }

        public int? RaceId { get; set; }

        public virtual City City { get; set; }

        public virtual Race Race { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationFinished> LocationFinished { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationTrial> LocationTrial { get; set; }
    }
}
