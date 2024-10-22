using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220024Data
{
    [Table("DrzaveIb220024")]
    public class Drzava
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Naziv")]
        public string Naziv { get; set; }

        [Column("Status")]
        public bool Status { get; set; }

        [Column("Zastava")]
        public byte[] Zastava { get; set; }


        public override string ToString()
        {
            return Naziv;
        }   
    }
}
