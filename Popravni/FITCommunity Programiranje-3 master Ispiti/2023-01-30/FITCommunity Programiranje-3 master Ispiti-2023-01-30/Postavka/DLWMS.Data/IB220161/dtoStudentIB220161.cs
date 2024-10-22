using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220161
{
    public class dtoStudentIB220161
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public Student Student { get; set; }
        public string BrojIndeksa => Student.BrojIndeksa;
        public string ImePrezime => Student.Ime + " " + Student.Prezime;
        public DateTime DatumRodjenja => Student.DatumRodjenja;
        public bool Aktivan => Student.Aktivan;
        public string Prosjek => izracunajProsjek();

        private string izracunajProsjek()
        {
            return db.StudentiPredmeti.Where(x => x.Student.Id == Student.Id).Average(x => x.Ocjena).ToString("0.00");
        }
    }
}
