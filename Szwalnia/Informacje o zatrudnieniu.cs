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

            cbUmowa.DataSource = db.vRodzajUmowy.ToList();
            cbUmowa.ValueMember = "ID_Rodzaj_Umowy";
            cbUmowa.DisplayMember = "Rodzaj_Umowy";
            cbUmowa.Invalidate();
            
            cbImieNazwisko.DataSource = db.vImieNazwiskoPracownika.ToList();
            cbImieNazwisko.ValueMember = "ID_Pracownika";
            cbImieNazwisko.DisplayMember = "Imie_i_nazwisko_pracownika";
            cbImieNazwisko.Invalidate();

            cbStanowisko.DataSource = db.vStanowisko.ToList();
            cbStanowisko.ValueMember = "ID_Stanowiska"; 
            cbStanowisko.DisplayMember = "Stanowisko";
            cbStanowisko.Invalidate();

            cbDzial.ValueMember = "ID_Dzialu";
            cbDzial.DisplayMember = "Nazwa_dzialu";
            cbDzial.DataSource = db.Dzialy.Distinct().ToList();
            cbDzial.Invalidate();

            cbEtat.DataSource = db.Etat.ToList();
            cbEtat.ValueMember = "ID_Etat";
            cbEtat.DisplayMember = "Wymiar_Etatu";
            cbEtat.Invalidate();

            cbUrlop.DataSource = db.Wymiar_Urlopu.ToList();
            cbUrlop.ValueMember = "ID_Wymiar_Urlopu";
            cbUrlop.DisplayMember = "Ilosc_dni";
            cbUrlop.Invalidate();

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Pracownicy_Zatrudnienie zatrudnienie = new Pracownicy_Zatrudnienie();
            zatrudnienie.Data_Zatrudnienia = Convert.ToDateTime(dtpPoczatek);
            zatrudnienie.Koniec_umowy = Convert.ToDateTime(dtpKoniec);
            zatrudnienie.ID_Pracownika = Convert.ToInt32(cbImieNazwisko.SelectedValue);
            zatrudnienie.ID_Dzialu = Convert.ToInt32(cbDzial.SelectedValue);
            zatrudnienie.ID_Etatu = Convert.ToInt32(cbEtat.SelectedValue);
            zatrudnienie.ID_Rodzaju_Umowy = Convert.ToInt32(cbUmowa.SelectedValue);
            zatrudnienie.ID_Stanowiska = Convert.ToInt32(cbStanowisko.SelectedValue);
            db.Pracownicy_Zatrudnienie.Add(zatrudnienie);
            db.SaveChanges();
            MessageBox.Show("Dodano nowe zatrudnienie");
            this.Close();
        }

        private void btnJezyk_Click(object sender, EventArgs e)
        {
            Pracownicy_Zatrudnienie zatrudnienie = new Pracownicy_Zatrudnienie();
            zatrudnienie.Data_Zatrudnienia = Convert.ToDateTime(dtpPoczatek.Value);
            zatrudnienie.Koniec_umowy = Convert.ToDateTime(dtpKoniec.Value);
            zatrudnienie.ID_Pracownika = Convert.ToInt32(cbImieNazwisko.SelectedValue);
            zatrudnienie.ID_Dzialu = Convert.ToInt32(cbDzial.SelectedValue);
            zatrudnienie.ID_Etatu = Convert.ToInt32(cbEtat.SelectedValue);
            zatrudnienie.ID_Rodzaju_Umowy = Convert.ToInt32(cbUmowa.SelectedValue);
            zatrudnienie.ID_Stanowiska = Convert.ToInt32(cbStanowisko.SelectedValue);
            db.Pracownicy_Zatrudnienie.Add(zatrudnienie);
            db.SaveChanges();
            MessageBox.Show("Dodano nowe zatrudnienie");
            this.Close();

            DodajNowyJezyk dodajNowyJezyk = new DodajNowyJezyk(db);
           dodajNowyJezyk.Show();
        }
    }
}
