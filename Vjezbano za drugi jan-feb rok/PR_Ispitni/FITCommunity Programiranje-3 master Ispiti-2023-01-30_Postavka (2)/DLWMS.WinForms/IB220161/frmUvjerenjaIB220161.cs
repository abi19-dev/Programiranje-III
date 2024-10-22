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
        Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB220161> uvjerenja = new List<StudentiUvjerenjaIB220161>();
        public frmUvjerenjaIB220161(Student std)
        {
            student = std;
            InitializeComponent();
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenja.Where(x => x.Student.Id == student.Id).ToList();
            dgvStudenti.DataSource = null;
            dgvStudenti.AutoGenerateColumns = false;

            dgvStudenti.DataSource = uvjerenja;
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var frm = new frmNovoUvjerenjeIB220161(student);
            frm.ShowDialog();
            UcitajUvjerenja();
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var uvj = dgvStudenti.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220161;

                var rd = MessageBox.Show("Da li želite obrisati odabrano uvjerenje?", "Info", MessageBoxButtons.YesNo);
                if (rd == DialogResult.Yes)
                {
                    db.StudentiUvjerenja.Remove(uvj);
                    db.SaveChanges();
                    UcitajUvjerenja();
                }
            }
        }
    }
}
