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
    public partial class frmNovoUvjerenjeIB220161 : Form
    {
        Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenjeIB220161(Student std)
        {
            student = std;
            InitializeComponent();
            UcitajVrste();
        }

        private void UcitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Prva vrsta");
            vrste.Add("Druga vrsta");
            vrste.Add("Treca vrsta");
            cmbVrsta.DataSource = vrste;
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            var Uplatnica = new OpenFileDialog();
            if (Uplatnica.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(Uplatnica.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var vrsta = cmbVrsta.SelectedIndex.ToString();
                var svrha = tbSvrha.Text;
                var slika = Helpers.ImageHelper.FromImageToByte(pbUplatnica.Image);
                var novi = new StudentiUvjerenjaIB220161
                {
                    Student = student,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Uplatnica = slika,
                    Printano = false,
                    Datum = DateTime.Now
                };
                db.Studenti.Attach(student);
                db.StudentiUvjerenja.Add(novi);
                db.SaveChanges();
            }
        }

        private bool ValidanUnos()
        {
            return Helpers.Validator.ValidirajKontrolu(pbUplatnica, err, Helpers.Kljucevi.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(cmbVrsta, err, Helpers.Kljucevi.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(tbSvrha, err, Helpers.Kljucevi.ObaveznaVrijednost);
        }
    }
}
