using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB220161
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [NotMapped] public string ImePrezime => Student.Ime + " " + Student.Prezime;
        public PredmetiIB220161 Predmet { get; set; }
        [NotMapped]
        public string PredmetNaziv => Predmet.Naziv;
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}
