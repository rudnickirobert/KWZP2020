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
    public partial class Informacje_o_zatrudnieniu : Form
    {
        public SzwalniaEntities db;
        public Informacje_o_zatrudnieniu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cbDzial.ValueMember = "ID_Dzialu";
            cbDzial.DisplayMember = "Nazwa_Dzialu";
            cbDzial.DataSource = db.Dzialy.Distinct().ToList();
            cbDzial.Invalidate();

            cbEtat.ValueMember = "ID_Etat";
            cbEtat.DisplayMember = "Wymiar_Etatu";
            cbEtat.DataSource = db.Etat.Distinct().ToList();
            cbEtat.Invalidate();

            cbStanowisko.ValueMember = "ID_Stanowiska";
            cbStanowisko.DisplayMember = "Stanowisko";
            cbStanowisko.DataSource = db.Stanowisko.Distinct().ToList();
            cbStanowisko.Invalidate();

            cbUmowa.ValueMember = "ID_Rodzaj_Umowy";
            cbUmowa.DisplayMember = "Rodzaj_Umowy";
            cbUmowa.DataSource = db.Rodzaj_Umowy.Distinct().ToList();
            cbUmowa.Invalidate();

            cbImieNazwisko.ValueMember = "ID_Pracownika";
            cbImieNazwisko.DisplayMember = "Imie";
            cbImieNazwisko.DataSource = db.Pracownicy.Distinct().ToList();
            cbImieNazwisko.Invalidate();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

        }
    }
}
