using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class Location
    {
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
        public virtual ICollection<LocationFinished> LocationFinished { get; set; }
        public virtual ICollection<LocationTrial> LocationTrial { get; set; }
    }
}
