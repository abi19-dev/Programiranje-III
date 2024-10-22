using FIT.Data;
using FIT.Infrastructure;
using FIT.Infrastructure.IB220024Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220161Forms
{
    public partial class frmDrzaveIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();

        public class dtoDrzava
        {
            public DrzaveIB220024 drzava { get; set; }
            public byte[] Zastava => drzava.Zastava;
            public string Drzava => drzava.Naziv;
            public int BrojGradova => GetBrojGradova();
            public bool Aktivna => drzava.Status;

            private int GetBrojGradova()
            {
                DLWMSDbContext db = DBConnectionIB220161.DB;
                return db.GradoviIB220024.Where(g => drzava.Id == g.DrzavaId).ToList().Count();
            }
        }

        List<dtoDrzava> drzave = new List<dtoDrzava>();
        public frmDrzaveIB220161()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            dgvDrzave.DataSource = null;
            drzave.Clear();

            var lstDrzaveDb = db.DrzaveIB220024.ToList();

            foreach (var d in lstDrzaveDb)
                drzave.Add(new dtoDrzava() { drzava = d });

            dgvDrzave.DataSource = drzave;
        }
    }
}
