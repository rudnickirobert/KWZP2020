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
    public partial class NowaPolka : Form
    {
        int nowaPolka;
        public NowaPolka(SzwalniaEntities db, int ostatniaPolka)
        {
            InitializeComponent();
            nowaPolka = ostatniaPolka+1;
            lblNumerNowejPolki.Text = nowaPolka.ToString();
            this.regalyTableAdapter.Fill(this.szwalniaDataSet.Regaly); //zrobione przez projektanta
        }

        private void cmbOznaczenie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NowaPolka_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.vPolki_na_regalach' . Możesz go przenieść lub usunąć.
            this.vPolki_na_regalachTableAdapter.Fill(this.szwalniaDataSet.vPolki_na_regalach);

        }
    }
}
