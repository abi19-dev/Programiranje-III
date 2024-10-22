using DLWMS.Data;
using Microsoft.CodeAnalysis;
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
    public partial class frmPretragaIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti = new List<Student>();
        public frmPretragaIB220161()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ucitajSpolove();
        }

        private void ucitajSpolove()
        {
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = db.Spolovi.ToList();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            var spol = comboBox1.SelectedItem as Spol;
            var dtmOd = dateTimePicker1.Value;
            var dtmDo = dateTimePicker2.Value;

            var lista = db.Studenti.Include(x => x.Spol).Where(x => x.Spol.Id == spol.Id && (x.DatumRodjenja >= dtmOd && x.DatumRodjenja
            <= dtmDo)).ToList();
            studenti.Clear();
            dataGridView1.DataSource = null;

            studenti.AddRange(lista);
            dataGridView1.DataSource = studenti;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var student = dataGridView1.SelectedRows[0].DataBoundItem as Student;
                var frm = new frmUvjerenjaIB220161(student);
                frm.ShowDialog();
            }
            else
            {
                var student = dataGridView1.SelectedRows[0].DataBoundItem as Student;
                var frm = new frmStudentInfoIB220161(student);
                frm.ShowDialog();
            }
        }
    }
}
