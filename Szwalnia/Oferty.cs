using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class Oferty : Form
    {
        public SzwalniaEntities db;
        public Oferty()
        {
            db = Start.szwalnia;
            InitializeComponent();
            dgvOferty.DataSource = db.vOferty_Zebrane.ToList();
        }

        private void btnDodajOferte_Click(object sender, EventArgs e)
        {
            DodajOferte oferta = new DodajOferte();
            oferta.Show();
            this.Hide();
        }


        private void dgvOferty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvOferty.CurrentRow.Cells[0].Value);
            OfertySzczegoly szczegolyOferta = new OfertySzczegoly(Decimal.ToInt32(numID));
            szczegolyOferta.Show();
            this.Hide();
        }

        private void Oferty_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(Kontrahenci).Name].Show();
            this.Hide();
        }
    }
}
