
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
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }

        [NotMapped]
        public List<StudentSlike> studentSlike => UcitajSlike();

        public List<StudentSlike> UcitajSlike()
        {
            return db.StudentSlike.Where(x=>x.StudentId == Id).ToList();
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}