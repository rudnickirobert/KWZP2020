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
    public partial class Wybor_kuriera : Form
    {
        public SzwalniaEntities szwalnia_passed;
        public Wybor_kuriera(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            szwalnia_passed = szwalnia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Wybor_kuriera_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.Kurierzy' . Możesz go przenieść lub usunąć.
            this.kurierzyTableAdapter.Fill(this.szwalniaDataSet.Kurierzy);

        }

        private void btnKurSzukaj_Click(object sender, EventArgs e)
        {
            if (numKurier.Value > 0)
            {
                lblKurError.Text = "";
                lblNazwa Kurier = new lblNazwa(szwalnia_passed, Decimal.ToInt32(numKurier.Value));
                Kurier.Show();
                this.Close();
            }
            else
            {
                lblKurError.Text = "Bledne ID";
            }
        }

        private void btnKurierzy1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
