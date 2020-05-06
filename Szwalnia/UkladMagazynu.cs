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
    public partial class UkladMagazynu : Form
    {
        public SzwalniaEntities szwalnia;
        int ostatniaPolka;
        public UkladMagazynu(SzwalniaEntities db)
        {
            InitializeComponent();
            szwalnia = db;
            ostatniaPolka = db.Polki.Count(); //ile jest polek
        }

        private void btnZnajdzPolke_Click(object sender, EventArgs e)
        {
                if ((nudNumerPolki.Value <= ostatniaPolka) & (nudNumerPolki.Value > 0))
                {
                    //vPolki_na_regalach storage = szwalnia.vPolki_na_regalach.Where(regal => regal.Oznaczenie == nudNumerPolki.Value).First();
                }
                else
                MessageBox.Show("Wprowadź poprawny numer półki (wiekszy od 0 i mniejszy od " + ostatniaPolka + ")!");                  
        }

        private void btnDodajRegal_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajPolke_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajRozmiar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
