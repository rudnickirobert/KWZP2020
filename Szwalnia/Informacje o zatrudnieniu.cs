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
            
            cbUmowa.DataSource = db.Rodzaj_Umowy.ToList();
            cbUmowa.ValueMember = "ID_Rodzaj_Umowy";
            cbUmowa.DisplayMember = "Rodzaj_Umowy";


            cbImieNazwisko.DataSource = db.Pracownicy.ToList();
            cbImieNazwisko.ValueMember = "ID_Pracownika";
            cbImieNazwisko.DisplayMember = "Imie"; //'Pracownik'
            //dbo.Pracownicy.Imie + (' ') + dbo.Pracownicy.Nazwisko AS 'Pracownik'

            cbDzial.DataSource = db.Dzialy.ToList();
            cbDzial.ValueMember = "ID_Dzialu";
            cbDzial.DisplayMember = "Nazwa_dzialu";
            
            cbEtat.DataSource = db.Etat.ToList();
            cbEtat.ValueMember = "ID_Etat";
            cbEtat.DisplayMember = "Wymiar_Etatu";
            
            cbStanowisko.DataSource = db.Stanowisko.ToList();
            cbStanowisko.ValueMember = "ID_Stanowiska";
            cbStanowisko.DisplayMember = "Stanowisko";
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
