using DLWMS.Data;
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
    public partial class frmStudentInfoIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        Student std;
        public frmStudentInfoIB220161(Student student)
        {
            InitializeComponent();
            std = student;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            pictureBox1.Image = Helpers.ImageHelper.FromByteToImage(std.Slika);
            label1.Text = std.ImePrezime;
            label2.Text = std.Prosjek;
        }
    }
}
