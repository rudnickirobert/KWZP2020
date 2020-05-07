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
            MagazynForm magForm = new MagazynForm(szwalnia);
            magForm.Show();
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

        private void btnZarzadzanie_Click(object sender, EventArgs e)
        {
            ZarzadzanieForm zarzadzanieForm = new ZarzadzanieForm(szwalnia);
            zarzadzanieForm.Show();
        }
    } 
}
