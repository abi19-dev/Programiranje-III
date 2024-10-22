using FIT.Data.IB220024Data;
using FIT.Infrastructure;
using FIT.Infrastructure.IB220024Infrastructure;
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

namespace FIT.WinForms.IB220024WinForms
{
    public partial class frmReportIB220024 : Form
    {
        DLWMSDbContext db = DBConnectionIB220024.DB;
        private Drzava drzava;
        public frmReportIB220024(Drzava drzava)
        {
            InitializeComponent();
            this.drzava = drzava;
        }

        private void frmReportIB220024_Load(object sender, EventArgs e)
        {
            var lstGradovi=db.Gradovi.Where(g=>g.DrzavaId== drzava.Id).ToList();
            var brojGradova = lstGradovi.Count.ToString();

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pBrojGradova", brojGradova));

            reportViewer1.LocalReport.SetParameters(rpc);

            var tabela = new dsIB220024.GradoviDataTable();
            for (int i = 0; i < lstGradovi.Count; i++)
            {
                var red = tabela.NewGradoviRow();
                red.Rb=(i+1).ToString();
                red.Grad = lstGradovi[i].Naziv;
                red.Drzava = lstGradovi[i].Drzava.Naziv;
                if (lstGradovi[i].Status == true)
                    red.Aktivan = "DA";
                else
                    red.Aktivan = "NE";
                tabela.AddGradoviRow(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dsGradovi";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
