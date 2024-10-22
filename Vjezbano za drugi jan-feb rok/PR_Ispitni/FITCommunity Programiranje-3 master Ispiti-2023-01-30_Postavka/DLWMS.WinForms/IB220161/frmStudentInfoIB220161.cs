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
    public partial class frmStudentInfoIB220161 : Form
    {
        private dtoStudentIB220161 student;
        public frmStudentInfoIB220161(dtoStudentIB220161 std)
        {
            InitializeComponent();
            student = std;
        }
    }
}
