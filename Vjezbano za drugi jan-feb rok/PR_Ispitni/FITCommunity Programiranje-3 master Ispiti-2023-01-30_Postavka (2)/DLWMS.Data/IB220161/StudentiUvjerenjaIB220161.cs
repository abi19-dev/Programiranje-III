using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220161
{
    public class StudentiUvjerenjaIB220161
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
        public DateTime Datum {  get; set; }

    }
}
