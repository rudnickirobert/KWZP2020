using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class UkladMagazynu : Form
    {
        public SzwalniaEntities db;
        int ostatniaPolka;
        Start start;
        public UkladMagazynu(SzwalniaEntities szwalnia, Start startowy)
        {
            InitializeComponent();
            db = szwalnia;
            start = startowy;
            ostatniaPolka = db.Polki.Count();
        }

        private void btnZnajdzPolke_Click(object sender, EventArgs e)
        {
                if ((nudNumerPolki.Value <= ostatniaPolka) & (nudNumerPolki.Value > 0))
                {
                    vPolki_na_regalach storage = db.vPolki_na_regalach.Where(regal => regal.ID_Polka == nudNumerPolki.Value).First();
                    lblRegal.Text = "REGAŁ: " + storage.Oznaczenie;
                }
                else
                MessageBox.Show("Wprowadź poprawny numer półki (wiekszy od 0 i mniejszy od " + ostatniaPolka + ")!");                  
        }

        private void btnDodajRegal_Click(object sender, EventArgs e)
        {
            NowyRegal regal = new NowyRegal(db, start);
            regal.Show();
            this.Close();
        }

        private void btnDodajPolke_Click(object sender, EventArgs e)
        {
            NowaPolka polka = new NowaPolka(db, start, ostatniaPolka);
            polka.Show();
            this.Close();
        }

        private void btnDodajRozmiar_Click(object sender, EventArgs e)
        {
            NowyRozmiarPolki rozmiar = new NowyRozmiarPolki(db, start);
            rozmiar.Show();
            this.Close();
        }

        private void UkladMagazynu_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Show();
        }
    }
}
