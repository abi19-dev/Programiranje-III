
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
        public DbSet<PredmetiIB220161> Predmeti { get; set; }
        public DbSet<StudentiPredmetiIB220161> StudentiPredmeti { get; set; }
        public DbSet<StudentSlike> StudentSlike { get; set; }
       
    }
}