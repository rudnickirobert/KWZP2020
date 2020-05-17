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
    public partial class KurierzyLista : Form
    {
        public SzwalniaEntities db;
        public KurierzyLista(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }

        private void KurierzyLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet7.Kurierzy' . Możesz go przenieść lub usunąć.
            this.kurierzyTableAdapter.Fill(this.szwalniaDataSet7.Kurierzy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet4.Dostawcy_Zaopatrzenie' . Możesz go przenieść lub usunąć.
            this.dostawcy_ZaopatrzenieTableAdapter.Fill(this.szwalniaDataSet4.Dostawcy_Zaopatrzenie);

        }

        private void btnDodajKuriera_Click(object sender, EventArgs e)
        {
            DodajKuriera kurier = new DodajKuriera(db);
            kurier.Show();
            this.Hide();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Kontrahenci"].Show();
            this.Hide();
        }

        private void KurierzyLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void dgvKurierzy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvKurierzy.CurrentRow.Cells[0].Value);
            KurierzySzczegoly szczegolyKurier = new KurierzySzczegoly(db, Decimal.ToInt32(numID));
            szczegolyKurier.Show();
            this.Hide();
        }
    }
}
