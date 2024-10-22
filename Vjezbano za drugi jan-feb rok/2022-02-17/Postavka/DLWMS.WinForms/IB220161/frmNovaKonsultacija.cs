using DLWMS.WinForms.DB;
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
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;

namespace DLWMS.WinForms.IB220161
{
    public partial class frmNovaKonsultacija : Form
    {
        Student _student;
        List<Predmet> predmeti = new List<Predmet>();
        KonekcijaNaBazu db = DLWMSdb.Baza;
        public frmNovaKonsultacija(Student student)
        {
            InitializeComponent();
            _student = student;
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            predmeti = db.Predmeti.ToList();
            cmbPredmeti.DataSource = predmeti;
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        public bool ProvjeriUnose()
        {
            return Validator1.ValidirajKontrolu(textBoxInfo, err, Poruke.ObaveznaVrijednost);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ProvjeriUnose())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;
                var vrijeme = dtp.Value;
                var napomena = textBoxInfo.Text;
                StudentiKonsultacije novi = new StudentiKonsultacije()
                {
                    Student = _student,
                    Predmet = predmet,
                    VrijemeOdrzavanja = vrijeme,
                    Napomena = napomena
                };
                db.StudentiKonsultacije.Add(novi);
                db.SaveChanges();
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
