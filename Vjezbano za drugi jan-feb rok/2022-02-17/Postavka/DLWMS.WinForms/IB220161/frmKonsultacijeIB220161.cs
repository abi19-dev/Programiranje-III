using DLWMS.WinForms.DB;
using DLWMS.WinForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB220161
{
    public partial class frmKonsultacijeIB220161 : Form
    {
        Student _student;
        List<StudentiKonsultacije> studentiKonsultacije = new List<StudentiKonsultacije> ();
        KonekcijaNaBazu db = DLWMSdb.Baza;
        public frmKonsultacijeIB220161(Student student)
        {
            InitializeComponent();
            _student = student;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            studentiKonsultacije = db.StudentiKonsultacije.Where(x=>x.Student.Id == _student.Id).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = studentiKonsultacije;
            var konsultacije = studentiKonsultacije.Count();
            this.Text = $"Broj prikazanih zahtjeva -> {konsultacije}" ;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaKonsultacija(_student);
            frm.ShowDialog();
            UcitajPodatke();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                var studentKonsultacija = dataGridView1.SelectedRows[0].DataBoundItem as StudentiKonsultacije;
                var rd = MessageBox.Show("Da li želite izbrisati?", "Info", MessageBoxButtons.YesNo);
                if (rd == DialogResult.Yes)
                {
                    db.StudentiKonsultacije.Remove(studentKonsultacija);
                    db.SaveChanges();
                    UcitajPodatke();
                }
            } 
        }

        private void Printaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaj(_student, studentiKonsultacije);
            frm.ShowDialog();
        }
    }
}
