using FIT.Data;
using FIT.Data.IB220024Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Drawing;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Studenti");
            modelBuilder.Entity<Drzava>().ToTable("DrzaveIB220024");
            modelBuilder.Entity<Grad>().ToTable("GradoviIB220024");
            modelBuilder.Entity<PolozeniPredmeti>().ToTable("PolozeniPredmeti");
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<PolozeniPredmeti> PolozeniPredmeti { get; set; }
    }
}