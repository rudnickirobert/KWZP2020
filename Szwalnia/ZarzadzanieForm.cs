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
            PanelKlienta panelKlienta = new PanelKlienta(db);
            panelKlienta.Show();
        }
        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            PanelPracownika panelPracownika = new PanelPracownika(db);
            panelPracownika.Show();
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
        private void btnZamowienie_Click(object sender, EventArgs e)
        {
           Zamowienie zamowienia = new Zamowienie(db);
            zamowienia.Show();
        }

        private void btnFinanse_Click(object sender, EventArgs e)
        {
            PanelFinansow panelFinansow = new PanelFinansow(db);
            panelFinansow.Show();
        }
    }
}

