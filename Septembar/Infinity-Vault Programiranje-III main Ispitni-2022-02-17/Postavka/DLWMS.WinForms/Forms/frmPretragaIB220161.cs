using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forms
{
    public partial class frmPretragaIB220161 : Form
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public frmPretragaIB220161()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            ucitajGodine();
        }

        private void ucitajGodine()
        {
            List<int> godine = new List<int>();
            godine.Add(1);
            godine.Add(2);
            godine.Add(3);
            godine.Add(4);
            cbGodine.DataSource = godine;
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var filter = tbImePrezime.Text.ToLower();
            List<Student> studenti = new List<Student>();
            var godina = int.Parse(cbGodine.Text);

            if(tbImePrezime.Text != string.Empty)
            {
                var pretraga = db.Studenti.Where(x => x.GodinaStudija == godina
                && (x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter))).ToList();
                studenti.Clear();
                studenti.AddRange(pretraga);
                dgvStudenti.DataSource = studenti;
            }
            else
            {
                var pretraga = db.Studenti.Where(x => x.GodinaStudija == godina).ToList();
                studenti.Clear();
                studenti.AddRange(pretraga);
                dgvStudenti.DataSource = studenti;
            }
        }

        private void cbGodine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cbGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                var frm = new frmKonsultacijeIB220161(student);
                frm.ShowDialog();
            }
        }
    }
}
