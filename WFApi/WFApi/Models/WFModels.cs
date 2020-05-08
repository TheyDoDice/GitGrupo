namespace WFApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WFModels : DbContext
    {
        public WFModels()
            : base("name=WFModels")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationFinished> LocationFinished { get; set; }
        public virtual DbSet<LocationTrial> LocationTrial { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamsRaces> TeamsRaces { get; set; }
        public virtual DbSet<Trial> Trial { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
