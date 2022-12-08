﻿using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class TeamsRaces
    {
        public int Id { get; set; }
        public int IdTeam { get; set; }
        public int? TeamId { get; set; }
        public int IdRace { get; set; }
        public int? RaceId { get; set; }

        public virtual Race Race { get; set; }
        public virtual Team Team { get; set; }
    }
}