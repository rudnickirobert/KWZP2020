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
    public partial class StanMagazynowy : Form
    {
        public SzwalniaEntities db;
        public StanMagazynowy()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void btnCalkowity_Click(object sender, EventArgs e)
        {
            StanMagazynowyCalkowity calkowity = new StanMagazynowyCalkowity();
            calkowity.Show();
            this.Hide();
        }

        private void btnWgElementow_Click(object sender, EventArgs e)
        {
            StanMagazynowyElementy elementy = new StanMagazynowyElementy();
            elementy.Show();
            this.Hide();
        }

        private void btnPustePolki_Click(object sender, EventArgs e)
        {
            PustePolki puste = new PustePolki();
            puste.Show();
            this.Hide();
        }

        private void btnEwidencjaMaterialow_Click(object sender, EventArgs e)
        {
            EwidencjaMaterialow ewidencjaMaterialow = new EwidencjaMaterialow();
            ewidencjaMaterialow.Show();
            this.Hide();
        }

        private void btnEwidencjaProduktow_Click(object sender, EventArgs e)
        {
            EwidencjaDostawWewnetrznych ewidencjaProduktow = new EwidencjaDostawWewnetrznych();
            ewidencjaProduktow.Show();
            this.Hide();
        }

        private void StanMagazynowy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
