using DLWMS.Data;
using DLWMS.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
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
    public partial class StudentiUvjerenjaIB220161 : Form
    {
        Student _student;
        List<StudentiUvjerenja220161> Uvjerenja = new List<StudentiUvjerenja220161>();
        DLWMSDbContext db = new DLWMSDbContext();
        public StudentiUvjerenjaIB220161(Student student)
        {
            InitializeComponent();
            _student = student;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvUvjerenja.AutoGenerateColumns = false;
            Uvjerenja = db.StudentiUvjerenjaIB220161.Include(x=>x.student).Where(x => x.student.Id == _student.Id).ToList();
            dgvUvjerenja.DataSource = Uvjerenja;
            this.Text = Uvjerenja.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovoUvjerenjeIB220161(_student);
            frm.ShowDialog();
            UcitajPodatke();
        }

        private void dgvUvjerenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var izbrisan = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenja220161;
                var message = MessageBox.Show("Da li želite obrisati podatak?", "info", MessageBoxButtons.YesNo);
                if(message == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB220161.Remove(izbrisan);
                    db.SaveChanges();
                    UcitajPodatke();
                }
            }
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                var uvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenja220161;
                var frm = new frmIzvjestaji(uvjerenje);
                frm.ShowDialog();
            }
        }
    }
}
