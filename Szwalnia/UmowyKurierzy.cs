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
    
    public partial class UmowyKurierzy : Form
    {
        public SzwalniaEntities db;
        public UmowyKurierzy()
        {
            db = Start.szwalnia;
            InitializeComponent();
            dgvUmowy.DataSource = db.vUmowyKurierzy.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajUmoweKurier umowa = new DodajUmoweKurier();
            umowa.Show();
            this.Hide();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(Kontrahenci).Name].Show();
            this.Hide();
        }

        private void dgvUmowy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvUmowy.CurrentRow.Cells[0].Value);
            UmowySzczegoly szczegolyUmowa = new UmowySzczegoly(Decimal.ToInt32(numID));
            szczegolyUmowa.Show();
            this.Hide();
        }

        private void UmowyKurierzy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
