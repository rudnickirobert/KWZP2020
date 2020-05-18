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
            cmbKurier.DataSource = db.Kurierzy.ToList();

        }


        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(UmowyKurierzy).Name].Show();
            this.Hide();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            umowaNowa.ID_Kurier = cmbKurier.SelectedIndex;
            umowaNowa.Data_Zawarcia = dtpDataZawarcia.Value;
            umowaNowa.Czas_Dostawy = Decimal.ToInt32(numCzas.Value);
            umowaNowa.Koszt_Km = Decimal.ToInt32(numKosztKm.Value);
            umowaNowa.Koszt_Staly = Decimal.ToInt32(numKosztStaly.Value);
            //
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
