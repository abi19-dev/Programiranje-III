﻿
using DLWMS.WinForms.IB220161;
using System.Data.Entity;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Studenti");                      
        }       
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentPredmeti> StudentiPredmeti { get; set; }
       
    }
}