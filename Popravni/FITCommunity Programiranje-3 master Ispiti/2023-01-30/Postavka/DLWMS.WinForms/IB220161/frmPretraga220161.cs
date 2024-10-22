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

namespace DLWMS.WinForms.IB220161
{
    public partial class frmPretraga220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Spol> spolovi = new List<Spol>();
        List<Student> studenti = new List<Student>();
        public frmPretraga220161()
        {
            InitializeComponent();
            ucitajSpolove();
            ucitajPrvu();
        }

        private void ucitajPrvu()
        {
            dgvStudenti.AutoGenerateColumns = false;
            studenti = db.Studenti.ToList();
            dgvStudenti.DataSource = studenti;
        }

        private void ucitajStudente()
        {
            dgvStudenti.AutoGenerateColumns = false;
            var datumOd = dtp1.Value;
            var datumDo = dtp2.Value;
            var spol = cbSpol.SelectedItem as Spol;
            studenti.Clear();
            studenti = db.Studenti.Where(x => x.Spol == spol && (x.DatumRodjenja >= datumOd && x.DatumRodjenja <=
            datumDo)).ToList();
            if (studenti.Count == 0)
            {
                MessageBox.Show($"Nema studenata {spol.Naziv} spola, rođenih od {datumOd} do" +
                    $"{datumDo}");
            }
            dgvStudenti.DataSource = studenti;
        }

        private void ucitajSpolove()
        {
            spolovi = db.Spolovi.ToList();
            cbSpol.DataSource = spolovi;
            cbSpol.DisplayMember = "Naziv";
            cbSpol.ValueMember = "Id";
        }

        private void dgvStudenti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var imePrezime = studenti[e.RowIndex].Ime + " " + studenti[e.RowIndex].Prezime;
                e.Value = imePrezime;
            }
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                var Prosjek = db.StudentiPredmeti.Where(x => x.Student.Id == studenti[e.RowIndex].Id)
                    .Average(o => o.Ocjena).ToString();
                e.Value = Prosjek;
            }
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5 && e.ColumnIndex >= 0) {
                var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                var frm = new frmStudentInfoIB220161(student);
                frm.ShowDialog();
            }

            if (e.ColumnIndex == 5 && e.ColumnIndex >= 0)
            {
                var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                var frm = new StudentiUvjerenjaIB220161(student);
                frm.ShowDialog();
            }
        }
    }
}
