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
    public partial class Wybor_oferty : Form
    {
        public SzwalniaEntities szwalnia_passed;
        public Wybor_oferty(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            szwalnia_passed = szwalnia;
            lblError.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblElement_Click(object sender, EventArgs e)
        {

        }

        private void btnWyszukaj_Click(object sender, EventArgs e)
        {
            if (numUpElement.Value > 0)
            {
                Oferty_szczegoly Szczegoly_oferty = new Oferty_szczegoly(szwalnia_passed, Decimal.ToInt32(numUpElement.Value));
                Szczegoly_oferty.Show();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void Wybor_oferty_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet1.Elementy' . Możesz go przenieść lub usunąć.
            this.elementyTableAdapter.Fill(this.szwalniaDataSet1.Elementy);

        }
    }
}
