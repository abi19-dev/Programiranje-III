using FIT.Data;
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
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<DrzaveIB220024> DrzaveIB220024 { get; set; }
        public DbSet<GradoviIB220024> GradoviIB220024 { get; set; }
        
    }
}