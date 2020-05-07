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
    public partial class ZarzadzanieForm : Form
    {
        public SzwalniaEntities db;
        public ZarzadzanieForm(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }
        private void btnKlienciForm_Click(object sender, EventArgs e)
        {
            WyborKlienta wyborKlienta = new WyborKlienta(db);
            wyborKlienta.Show();
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            WyborPracownika wyborPracownika = new WyborPracownika(db);
            wyborPracownika.Show();
        }

        private void btnFakturyZewnetrzne_Click(object sender, EventArgs e)
        {
            FakturyZewnetrzne fakturyZewnetrzne = new FakturyZewnetrzne(db);
            fakturyZewnetrzne.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFakturyWewnetrzne_Click(object sender, EventArgs e)
        {
            FaktoryWystawiane fakturyWystawiane = new FaktoryWystawiane(db);
            fakturyWystawiane.Show();
        }
    }
}

