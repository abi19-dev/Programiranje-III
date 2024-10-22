using DLWMS.Data;
using DLWMS.Data.IB220161;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections;
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
    public partial class FrmPretragaIB220161 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<dtoStudentIB220161> studenti = new List<dtoStudentIB220161>();
        public FrmPretragaIB220161()
        {
            InitializeComponent();
            UcitajSpolove();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void UcitajSpolove()
        {
            cbSpol.DisplayMember = "Naziv";
            cbSpol.ValueMember = "Id";
            cbSpol.DataSource = db.Spolovi.ToList();
            //cbspol.selectedindex = -1;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                UcitajPodatke();
            }
        }

        private void cbSpol_SelectionChangeCommited(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                UcitajPodatke();
            }
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                UcitajPodatke();
            }
        }
        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (validniPodaci())
            {
                UcitajPodatke();
            }
        }

        private void UcitajPodatke()
        {
            var spol = cbSpol.SelectedItem as Spol;
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;
            var lista = db.Studenti.Where(x => x.Spol.Id == spol.Id &&
            (x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)).ToList();

            dgvStudenti.DataSource = null;
            if (lista.Count == 0)
            {
                MessageBox.Show($"U bazi nema studenata koji su sljedećeg spola: " +
                    $"{spol.Naziv} i da su rođeni u periodu od {datumOd.ToShortDateString()} " +
                    $"do {datumDo.ToShortDateString()}");
            }
            else
            {
                studenti.Clear();
                foreach (var std in lista)
                    studenti.Add(new dtoStudentIB220161() { Student = std });
                dgvStudenti.DataSource = studenti;
            }

        }

        private bool validniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cbSpol, err, Kljucevi.ObaveznaVrijednost);
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentIB220161;
            var frm = new frmStudentInfoIB220161(std);
            frm.ShowDialog();

        }
    }
}
