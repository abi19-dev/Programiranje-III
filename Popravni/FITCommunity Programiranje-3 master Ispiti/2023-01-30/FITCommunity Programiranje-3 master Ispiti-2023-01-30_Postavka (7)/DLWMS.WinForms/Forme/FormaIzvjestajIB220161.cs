using DLWMS.Data.IB220161;
using Microsoft.Reporting.WinForms;
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
    public partial class FormaIzvjestajIB220161 : Form
    {
        StudentiUvjerenjaIB220161 uvj;
        public FormaIzvjestajIB220161(StudentiUvjerenjaIB220161 uvjerenje)
        {
            InitializeComponent();
            uvj = uvjerenje;

        }

        private void FormaIzvjestajIB220161_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("ImePrezime", uvj.Student.ImePrezime));
            rpc.Add(new ReportParameter("BrojIndeksa", uvj.Student.BrojIndeksa));
            rpc.Add(new ReportParameter("Vrsta", uvj.Vrsta));
            rpc.Add(new ReportParameter("Svrha", uvj.Svrha));
            rpc.Add(new ReportParameter("Datum", DateTime.Now.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
