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
   
    public partial class DodajUmoweKurier : Form
    {
        public SzwalniaEntities db;
        public Umowy_Kurierzy umowaNowa = new Umowy_Kurierzy();
        public DodajUmoweKurier(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
            umowaNowa.ID_Kurier = cmbKurier.SelectedIndex;
            umowaNowa.Data_Zawarcia = dtpDataZawarcia.Value;
            umowaNowa.Czas_Dostawy = Decimal.ToInt32(numCzas.Value);
            umowaNowa.Koszt_Km = Decimal.ToInt32(numKosztKm.Value);
            umowaNowa.Koszt_Staly = Decimal.ToInt32(numKosztStaly.Value);

        }

        private void DodajUmoweKurier_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet7.Kurierzy' . Możesz go przenieść lub usunąć.
            this.kurierzyTableAdapter.Fill(this.szwalniaDataSet7.Kurierzy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet4.Dostawcy_Zaopatrzenie' . Możesz go przenieść lub usunąć.
            this.dostawcy_ZaopatrzenieTableAdapter.Fill(this.szwalniaDataSet4.Dostawcy_Zaopatrzenie);

        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["UmowyKurierzy"].Show();
            this.Hide();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            
                db.Umowy_Kurierzy.Add(umowaNowa);
                db.SaveChanges();
                MessageBox.Show("Dodano nową umowę.");
        }

        private void DodajUmoweKurier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
