using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class StudentiUvjerenja220161
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string SvrhaUvjerenja {  get; set; }
        public string VrstaUvjerenja {  get; set; }
        public bool Printano { get; set; }
        public byte[] Uplatnica { get; set; }
    }
}
