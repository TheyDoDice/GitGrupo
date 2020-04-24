using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class City
    {
        public City()
        {
            Location = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Location> Location { get; set; }
    }
}
