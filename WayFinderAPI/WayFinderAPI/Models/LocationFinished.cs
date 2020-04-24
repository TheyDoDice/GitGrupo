using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class LocationFinished
    {
        public int Id { get; set; }
        public int IdTeam { get; set; }
        public int? TeamId { get; set; }
        public int IdRace { get; set; }
        public int? RaceId { get; set; }
        public int IdLocation { get; set; }
        public int? LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Race Race { get; set; }
        public virtual Team Team { get; set; }
    }
}
