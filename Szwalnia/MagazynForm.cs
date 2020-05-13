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
    public partial class MagazynForm : Form
    {
        public SzwalniaEntities db;
        public MagazynForm(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }

        private void btnElementyForm_Click(object sender, EventArgs e)
        {
            ElementyForm wybor = new ElementyForm(db);
            wybor.Show();
            this.Hide();
        }

        private void btnUkladMagazynu_Click(object sender, EventArgs e)
        {
            UkladMagazynu uklad = new UkladMagazynu(db);
            uklad.Show();
            this.Hide();
        }

        private void btnStanMagazynowy_Click(object sender, EventArgs e)
        {
            StanMagazynowy magazynowy = new StanMagazynowy(db);
            magazynowy.Show();
            this.Hide();
        }

        private void btnObslugaZamowien_Click(object sender, EventArgs e)
        {
            ObslugaZamowien zamowienia = new ObslugaZamowien(db);
            zamowienia.Show();
            this.Hide();
        }

        private void btnObslugaDostaw_Click(object sender, EventArgs e)
        {
            ObslugaDostaw dostawy = new ObslugaDostaw(db);
            dostawy.Show();
            this.Hide();
        }

        private void btnKontrahenci_Click(object sender, EventArgs e)
        {
            Kontrahenci kontrahenci = new Kontrahenci(db);
            kontrahenci.Show();
            this.Hide();
        }

        private void MagazynForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
