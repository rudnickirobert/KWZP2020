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
    public partial class PanelPracownika : Form
    {
        public SzwalniaEntities db;
        public PanelPracownika(SzwalniaEntities szwalnia)

        {
            InitializeComponent();
            db = szwalnia;
        }

        private void btnPracownicy_Click(object sender, EventArgs e)
        {
            WyborPracownika wyborPracownika = new WyborPracownika(db);
            wyborPracownika.Show();
        }

        private void btnZatrudnienie_Click(object sender, EventArgs e)
        {
           InformacjeOZatrudnieniu informacjeOZatrudnieniu = new InformacjeOZatrudnieniu(db);
            informacjeOZatrudnieniu.Show();

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNowyPracownik_Click(object sender, EventArgs e)
        {
            NowyPracownik nowyPracownik = new NowyPracownik(db);
            nowyPracownik.Show();
        }
    }
}
