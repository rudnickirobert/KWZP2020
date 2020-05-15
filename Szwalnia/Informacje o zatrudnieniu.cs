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
    public partial class InformacjeOZatrudnieniu : Form
    {
        public SzwalniaEntities db;
        public InformacjeOZatrudnieniu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cbUmowa.ValueMember = "ID_Rodzaj_Umowy";
            cbUmowa.DisplayMember = "Rodzaj_Umowy";
            cbUmowa.DataSource = db.Rodzaj_Umowy.Distinct().ToList();
            cbUmowa.Invalidate();

            cbImieNazwisko.ValueMember = "ID_Pracownika";
            cbImieNazwisko.DisplayMember = "Imie, Nazwisko";
            cbImieNazwisko.DataSource = db.Pracownicy.Distinct().ToList();
            cbImieNazwisko.Invalidate();

            cbDzial.ValueMember = "ID_Dzialu";
            cbDzial.DisplayMember = "Nazwa_dzialu";
            cbDzial.DataSource = db.Dzialy.Distinct().ToList();
            cbDzial.Invalidate();

            cbEtat.ValueMember = "ID_Etatu";
            cbEtat.DisplayMember = "Wymiar_Etatu";
            cbEtat.DataSource = db.Etat.Distinct().ToList();
            cbEtat.Invalidate();

            cbStanowisko.ValueMember = "ID_Stanowiska";
            cbStanowisko.DisplayMember = "Stanowisko";
            cbStanowisko.DataSource = db.Stanowisko.Distinct().ToList();
            cbStanowisko.Invalidate();

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
