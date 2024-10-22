using DLWMS.WinForms.DB;
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

namespace DLWMS.WinForms.Reports
{
    public partial class frmIzvjestaj : Form
    {
        Student student;
        List<StudentiKonsultacije> studentiKonsultacije;
        public frmIzvjestaj(Student std,List<StudentiKonsultacije> konsultacije)
        {
            InitializeComponent();
            student = std;
            studentiKonsultacije= konsultacije;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {         
            ReportParameterCollection rpc=new ReportParameterCollection();
            rpc.Add(new ReportParameter("pName", student.Ime));
            rpc.Add(new ReportParameter("pBrojZahtjeva", studentiKonsultacije.Count.ToString()));
            var tblKonsultacije = new dsReport.TabelaDataTable();
            for (int i = 0; i < studentiKonsultacije.Count; i++)
            {
                var red = tblKonsultacije.NewTabelaRow();
                red.Rb = (i + 1).ToString();
                red.Predmet = studentiKonsultacije[i].Predmet.ToString();
                red.Vrijeme = studentiKonsultacije[i].VrijemeOdrzavanja.ToString();
                red.Napomena = studentiKonsultacije[i].Napomena.ToString();
                tblKonsultacije.AddTabelaRow(red);
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsReport";
            rds.Value = tblKonsultacije;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
