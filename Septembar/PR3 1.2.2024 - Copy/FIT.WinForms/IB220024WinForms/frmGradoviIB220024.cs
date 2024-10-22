using FIT.Data;
using FIT.Data.IB220024Data;
using FIT.Infrastructure;
using FIT.Infrastructure.IB220024Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmGradoviIB220024 : Form
    {
        Drzava Drzava;
        DLWMSDbContext db = DBConnectionIB220024.DB;
        List<Grad> lstGradovi = new List<Grad>();
        public frmGradoviIB220024(Drzava drzava)
        {
            InitializeComponent();
            Drzava = drzava;
        }

        private void frmGradoviIB220024_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.AutoGenerateColumns = false;

            lblDrzavaNaziv.Text = Drzava.Naziv;
            pcbZastava.Image = Drzava.Zastava.ToImage();

            LoadGrid();
        }

        private void LoadGrid()
        {
            lstGradovi.Clear();
            dgvGradovi.DataSource = null;

            lstGradovi = db.Gradovi.Where(g => g.DrzavaId == Drzava.Id).ToList();
            dgvGradovi.DataSource = lstGradovi;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNazivGrada.Text;
                var grad = new Grad() { DrzavaId = Drzava.Id, Status = true, Naziv = naziv };
                db.Gradovi.Add(grad);
                db.SaveChanges();
                LoadGrid();
            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtNazivGrada, err, Kljucevi.ReqiredValue);
        }

        private void dgvGradovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var grad = dgvGradovi.SelectedRows[0].DataBoundItem as Grad;
                grad.Status = !grad.Status;
                db.Gradovi.Update(grad);
                db.SaveChanges();
                LoadGrid();
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (ValidirajAsync())
            {
                int brojGradova;
                try
                {
                    brojGradova = int.Parse(txtBrojGradova.Text);
                }
                catch (Exception)
                {
                    return;
                }
                var status = chbAktivan.Checked;

                await Task.Run(new Action(() => Generisi(brojGradova, Drzava, status)));
                MessageBox.Show($"Uspjesno dodano {brojGradova} gradova!", "Info");
                LoadGrid();

            }
        }

        private void Generisi(int brojGradova, Drzava drzava, bool status)
        {
            for (int i = 0; i < brojGradova; i++)
            {
                var novi = new Grad()
                {
                    Naziv = "Grad " + (i + 1).ToString() +".",
                    DrzavaId = drzava.Id,
                    Status = status
                };
                db.Gradovi.Add(novi);
                BeginInvoke(new Action(() =>
                {
                    var poruka = $"{DateTime.Now} -> dodat grad {novi.Naziv} za drzavu {novi.Drzava.Naziv} {Environment.NewLine}";
                    txtInfo.Text += poruka;
                    SetCursor();

                }));
                Thread.Sleep(300);
            }
            db.SaveChanges();
        }

        private void SetCursor()
        {
            txtInfo.SelectionLength = txtInfo.TextLength;
            txtInfo.ScrollToCaret();
        }

        private bool ValidirajAsync()
        {
            return Validator.ProvjeriUnos(txtBrojGradova, err, Kljucevi.ReqiredValue);
        }
    }
}
