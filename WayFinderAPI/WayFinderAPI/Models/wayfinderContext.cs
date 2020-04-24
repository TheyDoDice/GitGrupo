using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WayFinderAPI.Models
{
    public partial class wayfinderContext : DbContext
    {
        public wayfinderContext()
        {
        }

        public wayfinderContext(DbContextOptions<wayfinderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationFinished> LocationFinished { get; set; }
        public virtual DbSet<LocationTrial> LocationTrial { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamsRaces> TeamsRaces { get; set; }
        public virtual DbSet<Trial> Trial { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=den1.mssql7.gear.host;Database=wayfinder;User Id=wayfinder;Password=Mb9UL~b~c52X;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasOne(d => d.City)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CityId);

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.RaceId);
            });

            modelBuilder.Entity<LocationFinished>(entity =>
            {
                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationFinished)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.LocationFinished)
                    .HasForeignKey(d => d.RaceId);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.LocationFinished)
                    .HasForeignKey(d => d.TeamId);
            });

            modelBuilder.Entity<LocationTrial>(entity =>
            {
                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationTrial)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.Trial)
                    .WithMany(p => p.LocationTrial)
                    .HasForeignKey(d => d.TrialId);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.TeamId);
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B61B0B2F263");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.PrincipalId, e.Name })
                    .HasName("UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TeamsRaces>(entity =>
            {
                entity.HasOne(d => d.Race)
                    .WithMany(p => p.TeamsRaces)
                    .HasForeignKey(d => d.RaceId);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamsRaces)
                    .HasForeignKey(d => d.TeamId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
