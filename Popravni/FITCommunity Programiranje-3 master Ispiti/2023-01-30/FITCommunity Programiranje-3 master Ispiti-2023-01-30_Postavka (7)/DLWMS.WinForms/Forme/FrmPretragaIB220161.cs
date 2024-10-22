using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class FrmPretragaIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti = new List<Student>();
        public FrmPretragaIB220161()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
            cmbSpol.DataSource = db.Spolovi.ToList();
            cmbSpol.SelectedIndex = -1;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UcitajPodatke()
        {
            var spol = cmbSpol.SelectedItem as Spol;
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;
            var lista = db.Studenti.Where(x => x.Spol.Id == spol.Id && (x.DatumRodjenja >= datumOd &&
            x.DatumRodjenja <= datumDo)).ToList();
            dgvStudenti.DataSource = null;
            if (lista.Count == 0)
            {
                MessageBox.Show($"Nema studenata koji su " + $"{spol.Naziv} i da su rodnjeni u" +
                    $"perioud od {datumOd.ToShortDateString()} do {datumDo.ToShortDateString()}");
            }
            else
            {
                studenti.Clear();
                studenti.AddRange(lista);
                dgvStudenti.DataSource = studenti;
            }
        }

        private bool PodaciValidni()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbSpol, err, Helpers.Kljucevi.PodaciNisuValidni);
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (PodaciValidni())
            {
                UcitajPodatke();
            }
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (PodaciValidni())
            {
                UcitajPodatke();
            }
        }

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (PodaciValidni())
            {
                UcitajPodatke();
            }
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                var frm = new FormaUvjerenjaIB220161(std);
                frm.ShowDialog();
            }
            else
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                var frm = new FormaStudentInfoIB220161(std);
                frm.ShowDialog();
            }
        }
    }
}
