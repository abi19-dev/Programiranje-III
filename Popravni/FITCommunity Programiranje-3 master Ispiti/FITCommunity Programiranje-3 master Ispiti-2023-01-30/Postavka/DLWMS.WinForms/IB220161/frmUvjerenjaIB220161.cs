using DLWMS.Data;
using DLWMS.WinForms.Izvjestaji;
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

namespace DLWMS.WinForms.IB220161
{
    public partial class frmUvjerenjaIB220161 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB220161> uvjerenja = new List<StudentiUvjerenjaIB220161>();
        Student std;
        public frmUvjerenjaIB220161(Student student)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            std = student;
            ucitajPodatke();
            ucitajVrste();
        }

        private void ucitajVrste()
        {
            List<string> Vrste = new List<string>();
            Vrste.Add("Vrsta 1");
            Vrste.Add("Vrsta 2");
            Vrste.Add("Vrsta 3");
            comboBox1.DataSource = Vrste;
        }

        private void ucitajPodatke()
        {
            uvjerenja.Clear();
            dataGridView1.DataSource = null;

            var lista = db.StudentiUvjerenja.Include(x=>x.Student).Where(x => x.Student.Id == std.Id).ToList();
            uvjerenja.AddRange(lista);
            dataGridView1.DataSource = uvjerenja;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uvjerenje = dataGridView1.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220161;
            var frm = new frmNova(std);
            frm.ShowDialog();

            ucitajPodatke();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var vrsta = comboBox1.Text;
            var svrha = textBox1.Text;
            var brZahtjeva = int.Parse(textBox2.Text);
            var uplatnica = uvjerenja[0].Uplatnica;
            
            await Task.Run(async () =>
            {
                for (int i = 0; i < brZahtjeva; i++)
                {
                    var novi = new StudentiUvjerenjaIB220161()
                    {
                        StudentId = std.Id,
                        Datum = DateTime.Now,
                        Printano = true,
                        Svrha = svrha,
                        Vrsta = vrsta,
                        Uplatnica = uplatnica
                    };
                    await Task.Delay(300);

                    db.StudentiUvjerenja.Add(novi);

                    textBox3.Invoke(new Action(() =>
                    {
                        textBox3.AppendText($"{DateTime.Now} -> {vrsta} ({std.BrojIndeksa}) - {std.ImePrezime} u svrhu {svrha} {Environment.NewLine}");
                    }
                    ));
                }
            });

            db.SaveChanges();
            ucitajPodatke();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var uvjerenje = dataGridView1.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB220161;
                var frm = new frmIzvjestaji(uvjerenje);
                frm.ShowDialog();
            }
        }
    }
}
