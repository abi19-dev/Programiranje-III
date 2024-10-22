using DLWMS.Data;
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
    public partial class frmUvjerenjaIzvjestajIB220161 : Form
    {
        Student std;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmUvjerenjaIzvjestajIB220161(Student student)
        {
            InitializeComponent();
            std = student;
            db.Attach(std);
            ucitajVrste();
        }

        private void ucitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Uvjerenje o statusu studenta");
            vrste.Add("Uvjerenje o položenim ispitima");
            vrste.Add("Uvjerenje o prosjeku studenta");
            cbVrste.DataSource = vrste;
        }

        private bool Provjera()
        {
            return Helpers.Validator.ValidirajKontrolu(cbVrste, err, Helpers.Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(tbSvrha, err, Helpers.Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu(pbUplatnica, err, Helpers.Kljucevi.ObaveznaVrijednost);
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if (rd.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(rd.FileName);
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            if(Provjera())
            {
                var vrsta = cbVrste.SelectedItem.ToString();
                var svrha = tbSvrha.Text;
                var uplatnica = ImageHelper.FromImageToByte(pbUplatnica.Image);

                var novo = new StudentiUvjerenjaIB220161()
                {
                    Student = std,
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = uplatnica,
                    Datum = DateTime.Now,
                    Printano = false
                };

                db.StudentiUvjerenjaIB220161.Add(novo);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodano uvjerenje!");
            }
        }
    }
}
