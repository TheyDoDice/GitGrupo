using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class Race
    {
        public Race()
        {
            Location = new HashSet<Location>();
            LocationFinished = new HashSet<LocationFinished>();
            TeamsRaces = new HashSet<TeamsRaces>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<LocationFinished> LocationFinished { get; set; }
        public virtual ICollection<TeamsRaces> TeamsRaces { get; set; }
    }
}
