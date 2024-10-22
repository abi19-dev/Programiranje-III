using DLWMS.Data;
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
    public partial class frmNova : Form
    {
        Student std;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNova(Student student)
        {
            InitializeComponent();
            std=student;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if (rd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(rd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vrsta = comboBox1.Text;
            var svrha = textBox1.Text;
            var uplatnica = Helpers.ImageHelper.FromImageToByte(pictureBox1.Image);

            var nova = new StudentiUvjerenjaIB220161()
            {
                StudentId = std.Id,
                Datum = DateTime.Now,
                Printano = false,
                Svrha = svrha,
                Vrsta = vrsta,
                Uplatnica = uplatnica,
            };

            db.StudentiUvjerenja.Add(nova);
            db.SaveChanges();
        }
    }
}
