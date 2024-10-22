using DLWMS.Data;
using DLWMS.Data.IB220161;
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
    public partial class frmUvjerenjaIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        Student std;
        List<StudentiUvjerenjaIB220161> uvjerenja = new List<StudentiUvjerenjaIB220161>();
        public frmUvjerenjaIB220161(Student student)
        {
            InitializeComponent();
            std = student;
            dgvUvjerenja.AutoGenerateColumns = false;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            uvjerenja.Clear();
            uvjerenja = db.StudentiUvjerenjaIB220161.Where(x => x.Student.Id == std.Id).ToList();
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = uvjerenja;
        }

        private void dgvUvjerenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var uvj = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220161;
                var rd = MessageBox.Show("Da li želite obrisati uvjerenje?", "Info", MessageBoxButtons.YesNo);
                if (rd == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB220161.Remove(uvj);
                    db.SaveChanges();
                    ucitajPodatke();
                }

            }
            else if (e.ColumnIndex == 6)
            {
                var frm = new frmUvjerenjaIzvjestajIB220161(std);
                frm.ShowDialog();
            }
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void noviZahtjevBtn_Click(object sender, EventArgs e)
        {
            var frm = new frmUvjerenjaIzvjestajIB220161(std);
            frm.ShowDialog();
            ucitajPodatke();
        }
    }
}
