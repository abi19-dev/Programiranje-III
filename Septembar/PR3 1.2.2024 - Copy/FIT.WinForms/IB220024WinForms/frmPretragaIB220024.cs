using FIT.Data;
using FIT.Data.IB220024Data;
using FIT.Infrastructure;
using FIT.Infrastructure.IB220024Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class frmPretragaIB220024 : Form
    {
        DLWMSDbContext db = DBConnectionIB220024.DB;
        public class dtoStudent
        {
            public Student Student { get; set; }
            public string Ime => Student.Ime;
            public string Prezime => Student.Prezime;
            public string Grad => Student.Grad.Naziv;
            public string Drzava => GetDrzavu();
            public string Prosjek => GetProsjek();

            private string GetProsjek()
            {
                DLWMSDbContext Db = DBConnectionIB220024.DB;
                var lst = Db.PolozeniPredmeti.Where(p => p.StudentId == Student.Id).ToList();
                if(lst.Count==0)
                    return "5";
                return lst.Average(o => o.Ocjena).ToString("0.00");
            }

            private string GetDrzavu()
            {
                DLWMSDbContext Db = DBConnectionIB220024.DB;
                return Db.Drzave.Where(d => d.Id == Student.Grad.DrzavaId).First().ToString();
            }
        }

        List<dtoStudent> lstStudenti = new List<dtoStudent>();
        public frmPretragaIB220024()
        {
            InitializeComponent();
        }

        private void frmPretragaIB220024_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.AutoGenerateColumns = false;

            LoadComboboxDrzave();
            LoadComboboxGradovi();
        }

        private void LoadComboboxGradovi()
        {
            var drzava = cmbDrzave.SelectedItem as Drzava;
            var lst = db.Gradovi.Where(g => g.DrzavaId == drzava.Id).ToList();
            cmbGradovi.UcitajPodatke(lst);
          // cmbGradovi.SelectedIndex = -1; // otkomentarisati ovaj dio ako hoces da grad bude prazan kad se promenji drzava

        }

        private void LoadComboboxDrzave()
        {
            cmbDrzave.UcitajPodatke(db.Drzave.ToList());
        }

        private void cmbDrzave_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadComboboxGradovi();
            LoadGrid();
        }
        private void cmbGradovi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            if (Validiraj())
            {

                dgvStudenti.DataSource = null;
                lstStudenti.Clear();

                var drzava = cmbDrzave.SelectedItem as Drzava;
                var grad = cmbGradovi.SelectedItem as Grad;

                var lstStudent = db.Studenti.Where(s => s.GradID == grad.Id).ToList();
                foreach (var std in lstStudent)
                    lstStudenti.Add(new dtoStudent() { Student = std });

                dgvStudenti.DataSource = lstStudenti;
                if (lstStudenti.Count == 0)
                    MessageBox.Show($"U bazi nije evidentiran niti jedan student rođen u gradu {grad.Naziv}, {drzava.Naziv}", "Info");
            }
        }
        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cmbGradovi, err, Kljucevi.ReqiredValue) &&
                 Validator.ProvjeriUnos(cmbDrzave, err, Kljucevi.ReqiredValue);
        }
    }
}
