using FIT.Data.IB220024Data;
using FIT.Infrastructure;
using FIT.Infrastructure.IB220024Infrastructure;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220024WinForms
{
    public partial class frmDrzaveIB220024 : Form
    {
        DLWMSDbContext db = DBConnectionIB220024.DB;

        public class dtoDrzava
        {
            public Drzava drzava { get; set; }
            public byte[] Zastava => drzava.Zastava;
            public string Drzava => drzava.Naziv;
            public int BrojGradova => GetBrojGradova();
            public bool Aktivna => drzava.Status;

            private int GetBrojGradova()
            {
                DLWMSDbContext Db = DBConnectionIB220024.DB;
                return Db.Gradovi.Where(g => drzava.Id == g.DrzavaId).ToList().Count();
            }
        }
        List<dtoDrzava> lstDrzave = new List<dtoDrzava>();
        public frmDrzaveIB220024()
        {
            InitializeComponent();
            timer.Start();
        }
        private void frmDrzaveIB220024_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvDrzave.DataSource = null;
            lstDrzave.Clear();

            var lstDrzaveDb = db.Drzave.ToList();

            foreach (var d in lstDrzaveDb)
                lstDrzave.Add(new dtoDrzava() { drzava = d });

            dgvDrzave.DataSource = lstDrzave;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Trenutno vrijeme: " + DateTime.Now.ToLongTimeString();
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaDrzavaIB220024();
            frm.ShowDialog();
            LoadGrid();
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var dtoDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzava;
                var frm = new frmGradoviIB220024(dtoDrzava.drzava);
                frm.ShowDialog();
                LoadGrid();
            }
        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                var dtoDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzava;
                var frm = new frmNovaDrzavaIB220024(dtoDrzava.drzava);
                frm.ShowDialog();
                LoadGrid();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dtoDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as dtoDrzava;
            var frm = new frmReportIB220024(dtoDrzava.drzava);
            frm.ShowDialog();
            LoadGrid();
        }
    }
}
