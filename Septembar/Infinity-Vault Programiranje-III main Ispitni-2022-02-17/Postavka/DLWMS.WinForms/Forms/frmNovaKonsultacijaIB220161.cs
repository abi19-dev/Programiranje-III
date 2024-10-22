using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forms
{
    public partial class frmNovaKonsultacijaIB220161 : Form
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        Student std;
        public frmNovaKonsultacijaIB220161(Student student)
        {
            InitializeComponent();
            std = student;
            ucitajPredmete();
        }

        private void ucitajPredmete()
        {
            cbPredmet.DisplayMember = "Naziv";
            cbPredmet.ValueMember = "Id";
            cbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if(ValidniPodaci())
            {
                UcitajPodatke();
            }
        }

        private void UcitajPodatke()
        {
            var datum = dtpDatum.Value;
            var napomena = tbNapomena.Text;
            var novo = new StudentKonsultacijeIB220161()
            {
                Student = std,
                Datum = datum,
                Napomena = napomena,
                Predmet = cbPredmet.SelectedItem as PredmetiIB220161
            };
            db.StudentKonsultacije.Add(novo);
            db.SaveChanges();
            MessageBox.Show("Uspješno spašena konsultacija!");
            Close();
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cbPredmet, err, Helpers.Poruke.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(tbNapomena, err, Helpers.Poruke.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(dtpDatum, err, Helpers.Poruke.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            Show();
        }
    }
}
