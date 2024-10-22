using DLWMS.Data.IB220161;
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
        dtoStudentIB220161 std;
        public frmStudentInfoIB220161(dtoStudentIB220161 student)
        {
            InitializeComponent();
            std = student;
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            studentLbl.Text = std.ImePrezime;
            ProsjekLbl.Text = "Prosjek: " + std.Prosjek;
            pbStudent.Image = ImageHelper.FromByteToImage(std.Student.Slika);
            Text = std.BrojIndeksa;
        }

        private void frmStudentInfoIB220161_Load(object sender, EventArgs e)
        {

        }
    }
}
