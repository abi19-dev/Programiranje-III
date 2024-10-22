using DLWMS.Data;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        StudentiUvjerenjaIB220161 uvj;
        public frmIzvjestaji(StudentiUvjerenjaIB220161 uvjerenje)
        {
            InitializeComponent();
            uvj = uvjerenje;
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Vrsta", uvj.Vrsta));
            parametri.Add(new ReportParameter("Svrha", uvj.Svrha));
            parametri.Add(new ReportParameter("ImePrezime", uvj.Student.ImePrezime));


            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.RefreshReport();
        }
    }
}
