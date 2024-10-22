using DLWMS.Data;
using DLWMS.Data.IB210000;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB210000
{
    public partial class frmUvjerenjaIB210000 : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaIB210000.db;
        List<StudentUvjerenjeIB210000> uvjerenja = new List<StudentUvjerenjeIB210000>();
        public frmUvjerenjaIB210000(Student std)
        {
            InitializeComponent();
            dgvUvjerenja.AutoGenerateColumns = false;
            student = std;
            UcitajUvjerenja();
            UcitajVrste();
        }

        private void UcitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Uvjerenje o statusu studenta");
            vrste.Add("Uvjerenje o položenim ispitima");
            vrste.Add("Uvjerenje o prosjeku studenta");
            cmbVrsta.DataSource = vrste;
        }

        private void UcitajUvjerenja()
        {
            uvjerenja.Clear();
            uvjerenja=db.StudentiUvjerenja.Include(x=>x.Student)
                .Where(x=>x.Student.Id==student.Id).ToList();

            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource=uvjerenja;
            Text = $"Broj uvjerenja -> {uvjerenja.Count}";

            btnDodaj.Enabled = uvjerenja.Count()==0 ? false : true;
        }

        private void btnNovoUvjerenje_Click(object sender, EventArgs e)
        {
            var frm = new frmNovoUvjerenjeIB210000(student);
            frm.ShowDialog();
            UcitajUvjerenja();
            
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            int brZahtjeva = int.Parse(txtBrojUvjerenja.Text);
            string vrsta = cmbVrsta.SelectedItem.ToString();
            string svrha = txtSvrha.Text.ToString();
            var uplatnica = uvjerenja[0].Uplatnica;

            await Task.Run(async () =>
            {
                for (int i = 0; i < brZahtjeva; i++)
                {
                    var su = new StudentUvjerenjeIB210000()
                    {
                        Student = student,
                        Vrsta = vrsta,
                        Svrha = svrha,
                        Uplatnica = uplatnica,
                        Printano = true,
                        Datum = DateTime.Now,

                    };
                    await Task.Delay(1000);
                    db.StudentiUvjerenja.Add(su);

                    txtInfo.Invoke(new Action(() =>
                    {
                        txtInfo.AppendText($"talha bolje konta{Environment.NewLine}");
                    }));

                }
            });

            db.SaveChanges();
            UcitajUvjerenja();
           
        }
        private void DodajUvjerenja(int brojUvjerenja, string vrsta, string svrha, byte[] uplatnica)
        { 

        }

        private void SetCursor()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }

        private void dgvUvjerenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                var uvj = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenjeIB210000;

                var rd = MessageBox.Show("Da li želite obrisati odabrano uvjerenje?", "Info", MessageBoxButtons.YesNo);
                if(rd==DialogResult.Yes)
                {
                    db.StudentiUvjerenja.Remove(uvj);
                    db.SaveChanges();
                    UcitajUvjerenja();
                }
            }
            else if(e.ColumnIndex==6)
            {
                var uvj = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenjeIB210000;
                var frm = new frmIzvjestajIB210000(uvj);
                frm.ShowDialog();

                uvj.Printano = true;

                db.Entry(uvj).State = EntityState.Modified;
                db.SaveChanges();

                UcitajUvjerenja();
            }
        }
    }
}
