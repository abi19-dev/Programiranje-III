using DLWMS.Data;
using DLWMS.Data.IB220161;
using DLWMS.WinForms.IB220161;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmPocetna : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<dtoStudentIB220161> studenti = new List<dtoStudentIB220161>();

        public frmPocetna()
        {
            InitializeComponent();
            ucitajSpolove();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void ucitajSpolove()
        {
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
            cmbSpol.DataSource = db.Spolovi.ToList();
            cmbSpol.SelectedIndex = -1;
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";

        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            new frmIzvjestaji().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                UcitajPodatke();
            }
        }


        private void UcitajPodatke()
        {
            var spol = cmbSpol.SelectedItem as Spol;
            var DatumOd = dtpOd.Value;
            var DatumDo = dtpDo.Value;
            var lista = db.Studenti.Where(x => x.Spol.Id == spol.Id && (x.DatumRodjenja >= DatumOd &&
            x.DatumRodjenja <= DatumDo)).ToList();
            dgvStudenti.DataSource = null;
            if (lista.Count == 0)
            {
                MessageBox.Show($"U bazi nema studenata koji su sljedećeg spola: " +
                    $"{spol.Naziv} i da su rođeni u periodu od {DatumOd.ToShortDateString()} " +
                    $"do {DatumDo.ToShortDateString()}");
            }
            else
            {
                studenti.Clear();
                foreach (var std in lista)
                {
                    studenti.Add(new dtoStudentIB220161() { Student = std });
                }
                dgvStudenti.DataSource = studenti;
            }
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbSpol, err, Helpers.Kljucevi.ObaveznaVrijednost);
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                UcitajPodatke();
            }
        }

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                UcitajPodatke();
            }
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentIB220161;
                var frm = new frmUvjerenjaIB220161(std.Student);
                frm.ShowDialog();
            }
            else
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentIB220161;
                var frm = new frmStudentInfoIB220161(std);
                frm.ShowDialog();
            }
        }
    }
}
