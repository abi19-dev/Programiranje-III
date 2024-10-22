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

namespace DLWMS.WinForms.IB220161
{
    public partial class frmPretragaIB220161 : Form
    {
        KonekcijaNaBazu db = DLWMSdb.Baza;
        List<Student> listaStudenata = new List<Student>();
        public frmPretragaIB220161()
        {
            InitializeComponent();
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            dgvStudenti.AutoGenerateColumns = false;
            listaStudenata = db.Studenti.ToList();
            dgvStudenti.DataSource = listaStudenata;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
