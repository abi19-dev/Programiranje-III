using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    public class Student
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [NotMapped] public string ImePrezime => Ime + " " + Prezime;
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public Spol Spol { get; set; }
        [NotMapped]
        public string Prosjek => IzracunajProsjek();

        private string IzracunajProsjek()
        {
            return db.StudentiPredmeti.Where(x => x.Student.Id == Id).Average(x => x.Ocjena).ToString("0.00");
        }

        public override string ToString()
        {
            return $"({BrojIndeksa}) - {Ime} {Prezime}";
        }
    }  
}