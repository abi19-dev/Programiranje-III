using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLWMS.WinForms.IB220161
{
    public partial class frmStudentSlike : Form
    {
        Student std;
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        int index = 0;
        public frmStudentSlike(Student student)
        {
            InitializeComponent();
            std = student;
        }

        private void pbNova_Click(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if (rd.ShowDialog() == DialogResult.OK)
            {
                pbNova.Image = Image.FromFile(rd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opis = tbOpis.Text;
            if(PodaciValidni())
            {
                var nova = new StudentSlike()
                {
                    StudentId = std.Id,
                    Datum = DateTime.Now,
                    Opis = opis,
                    Slika = Helpers.ImageHelper.FromImageToByte(pbNova.Image)
                };

                db.StudentSlike.Add(nova);
                db.SaveChanges();

                UcitajPodatke();

                tbOpis.Text = string.Empty;
                pbNova.Image = null;
            }
        }

        private bool PodaciValidni()
        {
            return Helpers.Validator.ValidirajKontrolu(pbNova, err, Helpers.Poruke.ObaveznaVrijednost)
                && Helpers.Validator.ValidirajKontrolu(tbOpis, err, Helpers.Poruke.ObaveznaVrijednost);
        }

        private void frmStudentSlike_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (index>= 0 && index<std.studentSlike.Count)
            {
                pbStara.Image = Helpers.ImageHelper.FromByteToImage(std.studentSlike[index].Slika);
                lblRedniBroj.Text = $"Slika {index + 1}/{std.studentSlike.Count}";
                lblOpisTrenutno.Text = std.studentSlike[index].Opis;
                lblDatum.Text = std.studentSlike[index].Datum.ToString();
            }
        }

        private void desno_Click(object sender, EventArgs e)
        {
            if (index != std.studentSlike.Count - 1)
            {
                index++;
            }
            UcitajPodatke();
        }

        private void lijevo_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;

            }
            UcitajPodatke();
        }
    }
}
