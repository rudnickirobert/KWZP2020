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
        public UmowyKurierzy(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }

        private void UmowyKurierzy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSetUmowyKurierzy.Umowy_Kurierzy' . Możesz go przenieść lub usunąć.
            this.umowy_KurierzyTableAdapter.Fill(this.szwalniaDataSetUmowyKurierzy.Umowy_Kurierzy);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajUmoweKurier umowa = new DodajUmoweKurier(db);
            umowa.Show();
            this.Hide();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Kontrahenci"].Show();
            this.Hide();
        }

        private void dgvUmowy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvUmowy.CurrentRow.Cells[0].Value);
            UmowySzczegoly szczegolyUmowa = new UmowySzczegoly(db, Decimal.ToInt32(numID));
            szczegolyUmowa.Show();
            this.Hide();
        }

        private void UmowyKurierzy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
