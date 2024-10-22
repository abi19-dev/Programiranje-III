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

namespace DLWMS.WinForms.IB220161
{
    public partial class frmPretragaIB220161 : Form
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        List<StudentiPredmetiIB220161> ocjene = new List<StudentiPredmetiIB220161>();
        public frmPretragaIB220161()
        {
            InitializeComponent();
        }

        private void ucitajPodatke()
        {
            dgvStudenti.AutoGenerateColumns = false;
            dgvStudenti.DataSource = null;
            var filter = tbSearch.Text.ToLower();
            var lista = db.StudentiPredmeti.Include(x => x.Student).Include(x => x.Predmet)
                .Where(x => x.Student.Ime.ToLower().Contains(filter) || x.Student.Prezime.ToLower().Contains(filter)).ToList();
            Text ="Broj zapisa -> " + lista.Count();
            ocjene.Clear();
            ocjene.AddRange(lista);
            dgvStudenti.DataSource = ocjene;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ucitajPodatke();

        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                var poruka = MessageBox.Show("Želite li izbrisati?", "Info", MessageBoxButtons.YesNo);
                if(poruka == DialogResult.Yes)
                {
                    var ocjena = dgvStudenti.SelectedRows[0].DataBoundItem as StudentiPredmetiIB220161;
                    db.StudentiPredmeti.Remove(ocjena);
                    db.SaveChanges();
                    ucitajPodatke();
                }
            }
            else if(e.ColumnIndex == 5)
            {
                var ocjena = dgvStudenti.SelectedRows[e.RowIndex].DataBoundItem as StudentiPredmetiIB220161;
                var frm = new frmStudentSlike(ocjena.Student);
                frm.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var ocjena = dgvStudenti.SelectedRows[0].DataBoundItem as StudentiPredmetiIB220161;
            var frm = new frm
        }
    }
}
