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
        public SzwalniaEntities db;

        public Wybor_kuriera(SzwalniaEntities przekazana)
        {
            InitializeComponent();
            db = przekazana;

        }

        private void btnKurSzukaj_Click(object sender, EventArgs e)
        {
            if (numIDKurier.Value > 0)
            {
                lblKurError.Text = "";
                Kurierzy_szczegoly Szczegoly_kurier = new Kurierzy_szczegoly(db, Decimal.ToInt32(numIDKurier.Value));
                Szczegoly_kurier.Show();
                this.Close();
            }
            else
            {
                lblKurError.Text = "Bledne ID";
            }
        }

        private void Wybor_kuriera_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.Kurierzy' . Możesz go przenieść lub usunąć.
            this.kurierzyTableAdapter.Fill(this.szwalniaDataSet.Kurierzy);

        }

        private void btnKurOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numIDKurier_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
