using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DLWMS.WinForms
{
    public  class Student
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;

        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public string ImePrezime => Ime + " " + Prezime;
        public string Prosjek => prosjekOcjena();

        private string prosjekOcjena()
        {
             return db.StudentiPredmeti.Where(x => x.Student.Id == Id).Average(x => x.Ocjena).ToString("0.00");
              
        }
    }
}