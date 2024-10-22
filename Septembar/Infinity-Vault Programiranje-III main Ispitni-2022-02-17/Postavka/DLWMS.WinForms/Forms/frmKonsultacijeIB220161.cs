using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forms
{
    public partial class frmKonsultacijeIB220161 : Form
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        List<StudentKonsultacijeIB220161> konsultacije = new List<StudentKonsultacijeIB220161>();
        Student std;

        public frmKonsultacijeIB220161(Student student)
        {
            InitializeComponent();
            dgvKonsultacije.AutoGenerateColumns = false;
            std = student;
            ucitajPredmete();
            UcitajPodatke();
        }

        private void ucitajPredmete()
        {
            cbPredmeti.DisplayMember = "Naziv";
            cbPredmeti.ValueMember = "Id";
            cbPredmeti.DataSource = db.Predmeti.ToList();
        }

        private void UcitajPodatke()
        {
            konsultacije.Clear();
            konsultacije = db.StudentKonsultacije.Include(x=>x.Student).Include(x=>x.Predmet).Where(x => x.Student.Id == std.Id).ToList();
            dgvKonsultacije.DataSource = null;
            dgvKonsultacije.DataSource = konsultacije;

            Text = "Broj zapisa konsultacija -> " + konsultacije.Count().ToString();
        }

        private void dgvKonsultacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var konsultacija = dgvKonsultacije.SelectedRows[0].DataBoundItem as StudentKonsultacijeIB220161;
                if (konsultacija.Datum >= DateTime.Now)
                {
                    var rd = MessageBox.Show("Želite li izbrisati konsultaciju?", "Info", MessageBoxButtons.YesNo);
                    if (rd == DialogResult.Yes)
                    {
                        db.StudentKonsultacije.Remove(konsultacija);
                        db.SaveChanges();
                        UcitajPodatke();
                    }
                }
                else
                {
                    MessageBox.Show("Onemogućeno brisanje!");
                }
            }
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaKonsultacijaIB220161(std);
            frm.ShowDialog();

            UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var brZahtjeva = int.Parse(tbZahtjevi.Text);
            var predmet = cbPredmeti.SelectedItem as PredmetiIB220161;

            await Task.Run(async () =>
            {
                for (int i = 0; i < brZahtjeva; i++)
                {
                    var konsultacija = new StudentKonsultacijeIB220161()
                    {
                        Student = std,
                        Predmet = predmet,
                        Datum = DateTime.Now,
                        Napomena = $"Napomena {std.Id}",
                    };
                    await Task.Delay(500);
                    db.StudentKonsultacije.Add(konsultacija);

                    tbInfo.Invoke(new Action(() =>
                    {
                        tbInfo.AppendText("")
                    }));
                }
            });
        }
    }
}
