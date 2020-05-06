using System;

namespace Szwalnia
{

    public partial class Start : Form
    {
        public SzwalniaEntities szwalnia;
        public Start()
        {
            InitializeComponent();
            szwalnia = new SzwalniaEntities();
        }
        private void btnMagazyn_Click(object sender, EventArgs e)
        {
            MagazynForm magazynForm = new MagazynForm(szwalnia);
            magazynForm.Show();
        }
        private void btnRealizacjaProcesu_Click(object sender, EventArgs e)
        {
            RealizacjaProcesuSzczegoly realizacjaProcesu = new RealizacjaProcesuSzczegoly(szwalnia);
            realizacjaProcesu.Show();
        }
        private void btnZarzadzanie_MouseClick(object sender, MouseEventArgs e)
        {
            ZarzadzanieForm zarzadzanieForm = new ZarzadzanieForm(szwalnia);
            zarzadzanieForm.Show();
        }

        private void btnPrzygotowanieProdukcji_Click(object sender, EventArgs e)
        {
            PrzygotowanieProdukcji przygotowanieProdukcji = new PrzygotowanieProdukcji(szwalnia);
            przygotowanieProdukcji.Show();
        }


    

        private void btnProdukcja_Click(object sender, EventArgs e)
        {
            Produkcja formularzProdukcji = new Produkcja(szwalnia);
            formularzProdukcji.Show();
        }
    } 
}
