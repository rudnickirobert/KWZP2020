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
        }

        private void NowaPolka_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet1.Regaly' . Możesz go przenieść lub usunąć.
            this.regalyTableAdapter.Fill(this.szwalniaDataSet1.Regaly);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet1.Polki_regaly' . Możesz go przenieść lub usunąć.
            this.polki_regalyTableAdapter.Fill(this.szwalniaDataSet1.Polki_regaly);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet1.vPolki_Rozmiary' . Możesz go przenieść lub usunąć.
            this.vPolki_RozmiaryTableAdapter.Fill(this.szwalniaDataSet1.vPolki_Rozmiary);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.Polki_Rozmiary' . Możesz go przenieść lub usunąć.
            this.polki_RozmiaryTableAdapter.Fill(this.szwalniaDataSet.Polki_Rozmiary);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.vPolki_na_regalach' . Możesz go przenieść lub usunąć.
            this.vPolki_na_regalachTableAdapter.Fill(this.szwalniaDataSet.vPolki_na_regalach);

        }
    }
}
