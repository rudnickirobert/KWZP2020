using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class WyborElementu : Form
    {
        public SzwalniaEntities db;
        public WyborElementu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            db.SaveChanges();
            dgvListaElementow.DataSource = db.Elementy.ToList();
            for (int i = 4; i < 14; i++)
            { dgvListaElementow.Columns[i].Visible = false;}
        }

        private void dgvListaElementow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaElementow.CurrentRow.Cells[0].Value);
            ElementSzczegoly szczegolyElement = new ElementSzczegoly(Decimal.ToInt32(numID));
            szczegolyElement.Show();
            this.Hide();
        }

        private void WyborElementu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }
    }
}
