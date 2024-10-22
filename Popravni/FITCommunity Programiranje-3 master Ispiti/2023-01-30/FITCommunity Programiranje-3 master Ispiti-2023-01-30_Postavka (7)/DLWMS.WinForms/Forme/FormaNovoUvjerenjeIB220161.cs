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

namespace DLWMS.WinForms.Forme
{
    public partial class FormaNovoUvjerenjeIB220161 : Form
    {
        Student std;
        DLWMSDbContext db = new DLWMSDbContext();
        public FormaNovoUvjerenjeIB220161(Student student)
        {
            InitializeComponent();
            std = student;
            db.Attach(std);
            UcitajVrste();
        }

        private void UcitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Uvjerenje o statusu studenta");
            vrste.Add("Uvjerenje o položenim ispitima studenta");
            vrste.Add("Uvjerenje o prosječnoj ocjeni studenta");
            cbVrsta.DataSource = vrste;

        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if (rd.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(rd.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (podaciValidni())
            {
                var vrsta = cbVrsta.SelectedItem.ToString();
                var svrha = tbSvrha.Text;
                var uplatnica = Helpers.ImageHelper.FromImageToByte(pbUplatnica.Image);
                var novo = new StudentiUvjerenjaIB220161()
                {
                    Student = std,
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Datum = DateTime.Now,
                    Printano = false,
                    Uplatnica = uplatnica
                };

                db.StudentiUvjerenjaIB220161.Add(novo);
                db.SaveChanges();
                MessageBox.Show("Uvjerenje uspjesno dodano!");
            }
        }

        private bool podaciValidni()
        {
            return Helpers.Validator.ValidirajKontrolu(cbVrsta, err, Helpers.Kljucevi.PodaciNisuValidni) &&
                   Helpers.Validator.ValidirajKontrolu(tbSvrha, err, Helpers.Kljucevi.PodaciNisuValidni) &&
                   Helpers.Validator.ValidirajKontrolu(pbUplatnica, err, Helpers.Kljucevi.PodaciNisuValidni);
        }
    }
}
