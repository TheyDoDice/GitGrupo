using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class LocationTrial
    {
        public int Id { get; set; }
        public int IdLocation { get; set; }
        public int? LocationId { get; set; }
        public int IdTrial { get; set; }
        public int? TrialId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Trial Trial { get; set; }
    }
}
