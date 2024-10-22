using DLWMS.Data;
using DLWMS.WinForms.Helpers;
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
        Student student;
        public frmStudentInfoIB220161(Student std)
        {
            student = std;
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pbSlika.Image = ImageHelper.FromByteToImage(student.Slika);
            nazivStudenta.Text = student.ImePrezime;
            lblProsjek.Text = student.Prosjek;
        }
    }
}
