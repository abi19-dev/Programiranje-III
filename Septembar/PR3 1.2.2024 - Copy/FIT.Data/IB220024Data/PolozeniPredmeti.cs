using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220024Data
{
    [Table("PolozeniPredmeti")]
    public class PolozeniPredmeti
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("StudentId")]
        public int StudentId { get; set; }

        [Column("PredmetId")]
        public int PredmetId { get; set; }

        [Column("Ocjena")]
        public int Ocjena { get; set; }

        [Column("DatumPolaganja")]
        public DateTime DatumPolaganja { get; set; }

        [Column("Napomena")]
        public string Napomena { get; set; }

    }
}
