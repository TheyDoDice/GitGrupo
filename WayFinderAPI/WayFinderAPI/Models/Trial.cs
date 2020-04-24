using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class Trial
    {
        public Trial()
        {
            LocationTrial = new HashSet<LocationTrial>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocationTrial> LocationTrial { get; set; }
    }
}
