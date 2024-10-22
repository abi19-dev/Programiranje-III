using FIT.Data;
using FIT.Data.IB220024Data;
using FIT.Infrastructure;
using FIT.Infrastructure.IB220024Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmNovaDrzavaIB220024 : Form
    {
        DLWMSDbContext db = DBConnectionIB220024.DB;
        Drzava Drzava;
        bool Update = false;
        public frmNovaDrzavaIB220024(Drzava drzava)
        {
            InitializeComponent();
            Drzava = drzava;
            Update = true;
            LoadDrzavu();
        }

        private void LoadDrzavu()
        {
            txtNaziv.Text = Drzava.Naziv;
            pcbZastava.Image = Drzava.Zastava.ToImage();
            chbAktivna.Checked = Drzava.Status;
        }

        public frmNovaDrzavaIB220024()
        {
            InitializeComponent();
        }
        private void frmNovaDrzavaIB220024_Load(object sender, EventArgs e)
        {

        }
        private void btnSavucaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var Naziv = txtNaziv.Text;
                var Zastava = pcbZastava.Image.ToByteArray();
                var Aktivna = chbAktivna.Checked;
                if (Update == true)
                {
                    Drzava.Zastava = Zastava;
                    Drzava.Naziv = Naziv;
                    Drzava.Status = Aktivna;
                    db.Drzave.Update(Drzava);
                }
                else
                {
                    var drzava = new Drzava();
                    drzava.Zastava = Zastava;
                    drzava.Naziv = Naziv;
                    drzava.Status = Aktivna;
                    db.Drzave.Add(drzava);
                }
                db.SaveChanges();
                this.Close();
            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(pcbZastava, err, Kljucevi.ReqiredValue);
        }

        private void pcbZastava_DoubleClick(object sender, EventArgs e)
        {
            var result = new OpenFileDialog();
            if (result.ShowDialog() == DialogResult.OK)
                pcbZastava.Image = Image.FromFile(result.FileName);
        }
    }
}
