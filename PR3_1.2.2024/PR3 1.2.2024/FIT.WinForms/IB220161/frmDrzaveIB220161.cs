using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220161
{
    public partial class frmDrzaveIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<dtoDrzava> drzave = new List<dtoDrzava>();
        public frmDrzaveIB220161()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dataGridView1.DataSource = null;
            drzave.Clear();

            var lista = db.DrzaveIB220024.ToList();
            foreach (var d in lista)
                drzave.Add(new dtoDrzava() { drzava = d });

            dataGridView1.DataSource = drzave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaDrzavaIB220161();
            frm.ShowDialog();
        }
    }
}
