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
    public partial class Zamowienie : Form
    {
        public SzwalniaEntities db;
        public Zamowienie(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }

        private void btnStare_Click(object sender, EventArgs e)
        {
            ZamówieniaWPrzedsiębiorstwie zamowieniaWPrzedsiebiorstwie = new ZamówieniaWPrzedsiębiorstwie(db);
            zamowieniaWPrzedsiebiorstwie.Show();
        }

        private void btnNowe_Click(object sender, EventArgs e)
        {
            NoweZamowienie noweZamowienie = new NoweZamowienie(db);
            noweZamowienie.Show();
        }

        private void btnKoniecZamowienia_Click(object sender, EventArgs e)
        {
            ZakonczZamowienie zakonczZamowienie = new ZakonczZamowienie(db);
            zakonczZamowienie.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajElementy_Click(object sender, EventArgs e)
        {
            ElementyZamowienia elementyZamowienia = new ElementyZamowienia(db);
            elementyZamowienia.Show();
        }
    }
}
