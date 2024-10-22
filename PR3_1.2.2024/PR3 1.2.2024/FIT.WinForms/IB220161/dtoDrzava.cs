using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIT.Data;
using FIT.Data.IB220161;
using FIT.Infrastructure;

namespace FIT.WinForms.IB220161
{
    public class dtoDrzava
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public DrzaveIB220161 drzava { get; set; }
        public string Naziv => drzava.Naziv;
        public byte[] Zastava => drzava.Zastava;
        public bool Status => drzava.Status;
        public int BrojGradova => PrebrojGradove();

        private int PrebrojGradove()
        {
            return db.GradoviIB220024.Where(x=>x.DrzavaId == drzava.Id).Count();
        }
    }
}
