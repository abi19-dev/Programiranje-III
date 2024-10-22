using DLWMS.Data;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        StudentiUvjerenja220161 _uvjerenje;
        Student _student;
        public frmIzvjestaji(StudentiUvjerenja220161 uvjerenje)
        {
            InitializeComponent();
            _uvjerenje = uvjerenje;
         
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("VrstaUvjerenja", _uvjerenje.VrstaUvjerenja));
            parametri.Add(new ReportParameter("Ime", _uvjerenje.student.Ime));
            parametri.Add(new ReportParameter("Prezime", _uvjerenje.student.Prezime));
            parametri.Add(new ReportParameter("BrojIndeksa", _uvjerenje.student.BrojIndeksa));
            parametri.Add(new ReportParameter("Svrha", _uvjerenje.SvrhaUvjerenja));


            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.RefreshReport();
        }
    }
}
