using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB220161
{
    public partial class frmPretragaIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti = new List<Student>();
        public frmPretragaIB220161()
        {
            InitializeComponent();
            ucitajSpolove();
            ucitajPodatke();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void ucitajPodatke()
        {
            if (cmbSpolovi.SelectedItem == null)
            {
                studenti = db.Studenti.ToList();
                dgvStudenti.AutoGenerateColumns = false;
                dgvStudenti.DataSource = studenti;
            }
            else
            {
                var spol = cmbSpolovi.SelectedItem as Spol;
                var datumOd = dtpOd.Value;
                var datumDo = dtpDo.Value;
                studenti = db.Studenti.Where(x => x.Spol.Id == spol.Id && (x.DatumRodjenja >= datumOd
                && x.DatumRodjenja <= datumDo)).ToList();
                dgvStudenti.DataSource = null;
                if (studenti.Count == 0)
                {
                    MessageBox.Show($"U bazi nema studenata koji su sljedećeg spola: " +
                    $"{spol.Naziv} i da su rođeni u periodu od {datumOd.ToShortDateString()} " +
                    $"do {datumDo.ToShortDateString()}");
                }
                else
                {
                    dgvStudenti.AutoGenerateColumns = false;
                    dgvStudenti.DataSource = studenti;
                }
            }
        }

        private void ucitajSpolove()
        {
            cmbSpolovi.DataSource = db.Spolovi.ToList();
            cmbSpolovi.DisplayMember = "Naziv";
            cmbSpolovi.ValueMember = "Id";
            cmbSpolovi.SelectedIndex = -1;
        }



        private void frmPretragaIB220161_Load(object sender, EventArgs e)
        {

        }

        private void cmbSpolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                ucitajPodatke();
            }
        }

        private bool validniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbSpolovi, err, Kljucevi.ObaveznaVrijednost);
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                ucitajPodatke();
            }
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                ucitajPodatke();
            }
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var std = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            if (e.ColumnIndex >= 5)
            {
                var frmUvjerenja = new frmUvjerenjaIB220161(std);
                frmUvjerenja.ShowDialog();
            }
            else {
                var frm = new frmStudentInfoIB220161(std);
                frm.ShowDialog();
            }
        }
    }
}
