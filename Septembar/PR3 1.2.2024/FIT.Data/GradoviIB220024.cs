using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data
{
    [Table("GradoviIB220024")]
    public class GradoviIB220024
    {
        public int Id { get; set; }
        public string NazivGrada { get; set; }
        public DrzaveIB220024 Drzava { get; set; }
        public virtual int DrzavaId { get; set; }
    }
}
