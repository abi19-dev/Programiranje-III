using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    [Table("DrzaveIB220024")]
    public class DrzaveIB220024
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public byte[] Zastava { get; set; }
        public bool Status { get; set; }
    }
}
