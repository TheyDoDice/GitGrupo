using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class Team
    {
        public Team()
        {
            LocationFinished = new HashSet<LocationFinished>();
            Member = new HashSet<Member>();
            TeamsRaces = new HashSet<TeamsRaces>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public virtual ICollection<LocationFinished> LocationFinished { get; set; }
        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<TeamsRaces> TeamsRaces { get; set; }
    }
}
