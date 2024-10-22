using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;

namespace DLWMS.WinForms.IB220161
{
    public partial class FrmNovoUvjerenjeIB220161 : Form
    {
        Student _student;
        DLWMSDbContext db = new DLWMSDbContext();
        public FrmNovoUvjerenjeIB220161(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void FrmNovoUvjerenjeIB220161_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var slika = new OpenFileDialog();
            if (slika.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(slika.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ProvjeriPodatke())
            {
                var vrsta = cbVrsta.SelectedItem as string;
                var slika = Helpers.ImageHelper.FromImageToByte(pictureBox1.Image);
                var text = tb.Text;
                var novi = new StudentiUvjerenja220161()
                {
                    student = _student,
                    VrijemeKreiranja = DateTime.Now,
                    VrstaUvjerenja = vrsta,
                    SvrhaUvjerenja = text,
                    Printano = false,
                    Uplatnica = slika
                };
                db.Attach(_student);
                db.StudentiUvjerenjaIB220161.Add(novi);
                db.SaveChanges();
            }
        }

        private bool ProvjeriPodatke()
        {
            return Helpers.Validator.ValidirajKontrolu
                (cbVrsta, errProvider, Helpers.Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu
                (pictureBox1, errProvider, Helpers.Kljucevi.ObaveznaVrijednost) &&
                Helpers.Validator.ValidirajKontrolu
                (tb, errProvider, Helpers.Kljucevi.ObaveznaVrijednost);
        }
    }
}
