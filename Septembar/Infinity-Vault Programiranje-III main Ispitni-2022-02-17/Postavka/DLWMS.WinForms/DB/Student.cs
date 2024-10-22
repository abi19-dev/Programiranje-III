
using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DLWMS.WinForms
{
    [Table("Studenti")]
    public  class Student
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [NotMapped] public string ImePrezime => Ime + " " + Prezime;
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        [NotMapped]
        public double Prosjek => izracunajProsjek();

        private double izracunajProsjek()
        {
            return db.StudentiPredmeti.Where(x => x.Student.Id == Id).Average(x=>x.Ocjena);
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}