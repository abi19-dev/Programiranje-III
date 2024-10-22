using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    [Table("StudentSlike")]
    public class StudentSlike
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
    }
}
