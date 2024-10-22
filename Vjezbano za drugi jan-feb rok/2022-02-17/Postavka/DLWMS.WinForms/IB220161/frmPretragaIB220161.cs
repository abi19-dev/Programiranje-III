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

namespace DLWMS.WinForms.IB220161
{
    public partial class frmPretragaIB220161 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        List<Student> studenti = new List<Student>();
        public frmPretragaIB220161()
        {
            InitializeComponent();
            UcitajPocetnePodatke();
            cmbStudij.SelectedIndex = 0;
        }

        private void UcitajPocetnePodatke()
        {
            dgvStudenti.AutoGenerateColumns = false;
            studenti = db.Studenti.ToList();
            dgvStudenti.DataSource = studenti;
        }

        private void Pretraga()
        {
            var Ime = txtIme.Text.ToLower();
            var godinaStudija = string.IsNullOrEmpty(cmbStudij.Text) ? 0 : int.Parse(cmbStudij.Text);
            if (Ime != "")
            {
                studenti.Clear();
                studenti = db.Studenti.Where(x => (x.Ime.ToLower().Contains(Ime) || x.Prezime.ToLower().Contains(Ime)) && x.GodinaStudija == godinaStudija).ToList();
                dgvStudenti.AutoGenerateColumns = false;
                dgvStudenti.DataSource = studenti;
            }
            else
            {
                UcitajPocetnePodatke();
            }
        }

        private void dgvStudenti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var ImePrezime = studenti[e.RowIndex].Ime + " " + studenti[e.RowIndex].Prezime;
                e.Value = ImePrezime;
            }
            if (e.ColumnIndex==2 && e.RowIndex >= 0)
            {
                var selectedStudent = studenti[e.RowIndex];
                var polozeniPredmeti = db.StudentiPredmeti.Where(x => x.Student.Id == selectedStudent.Id).ToList();
                if (polozeniPredmeti.Count == 0)
                {
                    e.Value = 5;
                }
                else
                {
                    var prosjek = db.StudentiPredmeti.Where(x => x.Student.Id == selectedStudent.Id)
                    .Average(o => o.Ocjena).ToString();
                    e.Value = prosjek;
                }
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbStudij_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                var selectedStudent = studenti[e.RowIndex];
                var frm = new frmKonsultacijeIB220161(selectedStudent);
                frm.ShowDialog();
            }
        }
    }
}
