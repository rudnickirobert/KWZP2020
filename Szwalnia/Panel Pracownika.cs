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
    public partial class Panel_Pracownika : Form
    {
        public SzwalniaEntities db;
        public Panel_Pracownika(SzwalniaEntities szwalnia)

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
           Informacje_o_zatrudnieniu informacjeOZatrudnieniu = new Informacje_o_zatrudnieniu(db);
            informacjeOZatrudnieniu.Show();

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNowyPracownik_Click(object sender, EventArgs e)
        {
            Nowy_Pracownik nowyPracownik = new Nowy_Pracownik(db);
            nowyPracownik.Show();
        }
    }
}
