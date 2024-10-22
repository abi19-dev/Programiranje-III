using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;

namespace DLWMS.WinForms.IB220161
{
    public partial class frmStudentInfoIB220161 : Form
    {
        Student _student;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmStudentInfoIB220161(Student student)
        {
            InitializeComponent();
            _student = student;
            ucitajSliku();
            ucitajProsjek();
        }

        private void ucitajProsjek()
        {
            string prosjek;
            prosjek = "Prosjek: " + db.StudentiPredmeti.Where(x => x.Student.Id == _student.Id).
                Average(o => o.Ocjena).ToString();
            lblProsjek.Text = prosjek;
        }

        private void ucitajSliku()
        {
            pictureBox1.Image = Helpers.ImageHelper.FromByteToImage(_student.Slika);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
