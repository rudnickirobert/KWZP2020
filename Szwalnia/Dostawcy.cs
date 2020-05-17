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
    public partial class Dostawcy : Form
    {
        public SzwalniaEntities db;
        public Dostawcy(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }

        private void Dostawcy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet6.Dostawcy_Zaopatrzenie' . Możesz go przenieść lub usunąć.
            this.dostawcy_ZaopatrzenieTableAdapter.Fill(this.szwalniaDataSet6.Dostawcy_Zaopatrzenie);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajDostawce dostawca = new DodajDostawce(db);
            dostawca.Show();
            this.Hide();
        }

        private void Dostawcy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Kontrahenci"].Show();
            this.Hide();
        }

        private void dgvDostawcy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvDostawcy.CurrentRow.Cells[0].Value);
            DostawcySzczegoly szczegolyDostawca = new DostawcySzczegoly(db, Decimal.ToInt32(numID));
            szczegolyDostawca.Show();
            this.Hide();
        }
    }
}
