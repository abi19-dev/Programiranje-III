using DLWMS.Data;
using DLWMS.Data.IB220161;
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

namespace DLWMS.WinForms.Forme
{
    public partial class FormaUvjerenjaIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB220161> Uvjerenja = new List<StudentiUvjerenjaIB220161>();
        Student std;
        public FormaUvjerenjaIB220161(Student student)
        {
            InitializeComponent();
            dgvUvjerenja.AutoGenerateColumns = false;
            std = student;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            Uvjerenja.Clear();
            Uvjerenja = db.StudentiUvjerenjaIB220161.Include(x => x.Student).Where(x => x.Student.Id == std.Id).ToList();
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = Uvjerenja;
        }



        private void noviZahtjevBtn_Click(object sender, EventArgs e)
        {
            var frm = new FormaNovoUvjerenjeIB220161(std);
            frm.ShowDialog();

            UcitajPodatke();
        }

        private void dgvUvjerenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                var uvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220161;
                var rd = MessageBox.Show("Da li zelite obrisati uvjerenje? ", "Info", MessageBoxButtons.YesNo);
                if(rd == DialogResult.Yes)
                {
                    db.StudentiUvjerenjaIB220161.Remove(uvjerenje);
                    db.SaveChanges();
                    UcitajPodatke();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                var uvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220161;
                var frm = new FormaIzvjestajIB220161(uvjerenje);
                frm.ShowDialog();

                db.Entry(uvjerenje).State = EntityState.Modified;
                db.SaveChanges();

                UcitajPodatke();
            }
        }
    }
}
