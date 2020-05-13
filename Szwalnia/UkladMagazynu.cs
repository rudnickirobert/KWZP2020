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
        public UkladMagazynu()
        {
            InitializeComponent();
            db = Start.szwalnia;
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
            NowyRegal regal = new NowyRegal();
            regal.Show();
            this.Hide();
        }

        private void btnDodajPolke_Click(object sender, EventArgs e)
        {
            NowaPolka polka = new NowaPolka(ostatniaPolka);
            polka.Show();
            this.Hide();
        }

        private void btnDodajRozmiar_Click(object sender, EventArgs e)
        {
            NowyRozmiarPolki rozmiar = new NowyRozmiarPolki();
            rozmiar.Show();
            this.Hide();
        }

        private void UkladMagazynu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
