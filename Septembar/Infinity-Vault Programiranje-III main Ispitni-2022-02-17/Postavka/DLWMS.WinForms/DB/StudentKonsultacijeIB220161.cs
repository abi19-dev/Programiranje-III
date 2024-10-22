using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.DB
{
    [Table("StudentKonsultacije")]
    public class StudentKonsultacijeIB220161
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public PredmetiIB220161 Predmet { get; set; }
        [NotMapped]public string StudentImePrezime => Student.Ime + " " + Student.Prezime;
        [NotMapped]public string PredmetNaziv => Predmet.Naziv;
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
    }
}
