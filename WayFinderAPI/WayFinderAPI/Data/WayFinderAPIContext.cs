using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WayFinderAPI.Models;

namespace WayFinderAPI.Data
{
    public class WayFinderAPIContext : DbContext
    {
        public WayFinderAPIContext (DbContextOptions<WayFinderAPIContext> options)
            : base(options)
        {
        }

        public DbSet<WayFinderAPI.Models.City> City { get; set; }

        public DbSet<WayFinderAPI.Models.Location> Location { get; set; }

        public DbSet<WayFinderAPI.Models.LocationFinished> LocationFinished { get; set; }

        public DbSet<WayFinderAPI.Models.LocationTrial> LocationTrial { get; set; }

        public DbSet<WayFinderAPI.Models.Member> Member { get; set; }

        public DbSet<WayFinderAPI.Models.Race> Race { get; set; }

        public DbSet<WayFinderAPI.Models.Team> Team { get; set; }

        public DbSet<WayFinderAPI.Models.TeamsRaces> TeamsRaces { get; set; }

        public DbSet<WayFinderAPI.Models.Trial> Trial { get; set; }
    }
}
