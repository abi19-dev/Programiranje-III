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

namespace DLWMS.WinForms.Forme
{
    public partial class FormaStudentInfoIB220161 : Form
    {
        Student std;
        public FormaStudentInfoIB220161(Student student)
        {
            InitializeComponent();
            std = student;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            imePrezimeLbl.Text = std.ImePrezime;
            ProsjekLbl.Text = std.Prosjek;
            pbStudent.Image = ImageHelper.FromByteToImage(std.Slika);
            Text = std.BrojIndeksa;
        }
    }
}
