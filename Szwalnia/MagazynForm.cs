using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class MagazynForm : Form
    {
        public SzwalniaEntities db;
        public Start start;
        public MagazynForm(SzwalniaEntities szwalnia, Start startowy)
        {
            db = szwalnia;
            start = startowy;
            InitializeComponent();
        }

        private void btnElementyForm_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(db, start);
            wybor.Show();
            this.Hide();
        }

        private void btnUkladMagazynu_Click(object sender, EventArgs e)
        {
            UkladMagazynu uklad = new UkladMagazynu(db, start);
            uklad.Show();
            this.Hide();
        }

        private void btnStanMagazynowy_Click(object sender, EventArgs e)
        {
            StanMagazynowy magazynowy = new StanMagazynowy(db, start);
            magazynowy.Show();
            this.Hide();
        }

        private void btnObslugaZamowien_Click(object sender, EventArgs e)
        {
            ObslugaZamowien zamowienia = new ObslugaZamowien(db, start);
            zamowienia.Show();
            this.Hide();
        }

        private void btnObslugaDostaw_Click(object sender, EventArgs e)
        {
            ObslugaDostaw dostawa = new ObslugaDostaw(db, start);
            dostawa.Show();
            this.Hide();
        }

        private void btnKontrahenci_Click(object sender, EventArgs e)
        {
            Kontrahenci kontrahenci = new Kontrahenci(db, start);
            kontrahenci.Show();
            this.Hide();
        }

        private void MagazynForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Visible = true;
        }
    }
}
