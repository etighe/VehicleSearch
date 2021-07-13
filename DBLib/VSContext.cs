using System;
using DBLib.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBLib
{
    public class VsContext : DbContext
    {
        public VsContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public VsContext() {}

        public DbSet<VehicleDescription> Vehicles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleDescription>().ToTable("Vehicles");
            base.OnModelCreating(modelBuilder);
        }
    }
}
