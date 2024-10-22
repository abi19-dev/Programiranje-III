using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.DB
{
    [Table("Predmeti")]
    public class PredmetiIB220161
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
