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
    public partial class WyborPolkiDoOdlozenia : Form
    {
        public int intDostawaID;
        public int intElementID;
        public int intIlosc;
        public double dblIloscDlaPolki;
        public int intIloscPaczek;
        public int intZamowienieElementID;
        public string rodzajFormularza;
        public bool czyWyswietlicStart=true;
        public SzwalniaEntities db;
        public WyborPolkiDoOdlozenia(string rodzajFormularza,int intDostawaID, int intElementID, int intIlosc, int intIloscPaczek)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.intDostawaID = intDostawaID;
            this.intElementID = intElementID;
            this.intIlosc = intIlosc;
            this.intIloscPaczek = intIloscPaczek;
            this.rodzajFormularza = rodzajFormularza;
            if (db.vWolnePolki.Where(polka => polka.ID_Polka>0).Any())
            {
                dgvWolnePolki.DataSource = db.vWolnePolki.ToList();
                dgvWolnePolki.Columns[0].HeaderText = "Numer półki";
            }
            else
            {
                DataTable brakPolek = new DataTable();
                brakPolek.Columns.Add("Informacja");
                brakPolek.Rows.Add("Nie ma wolnych polek");
                dgvWolnePolki.DataSource = brakPolek;
            }
            if (db.vPracownicyMagazynu.Where(pracownik => pracownik.ID_Pracownika > 0).Any())
            {
                cmbPracownicy.DataSource = db.vPracownicyMagazynu.ToList();
                cmbPracownicy.DisplayMember = "Dane_osobowe";
                cmbPracownicy.ValueMember = "ID_Pracownika";
            }
            else
            {
                DataTable brakPracownikow = new DataTable();
                brakPracownikow.Columns.Add("Informacja");
                brakPracownikow.Rows.Add("Nie ma takich pracownikow");
                cmbPracownicy.DataSource = brakPracownikow;
                cmbPracownicy.DisplayMember = "Informacja";
                cmbPracownicy.ValueMember = "Informacja";
            }    
        }
        public WyborPolkiDoOdlozenia(string rodzajFormularza, int intDostawaID, int intElementID, double dblIloscDlaPolki,int intIlosc, int intZamowienieElementID)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.intZamowienieElementID = intZamowienieElementID;
            this.intDostawaID = intDostawaID;
            this.intElementID = intElementID;
            this.intIlosc = intIlosc;
            this.dblIloscDlaPolki = dblIloscDlaPolki;
            this.rodzajFormularza = rodzajFormularza;
            if (db.vWolnePolki.Where(polka => polka.ID_Polka > 0).Any())
            {
                dgvWolnePolki.DataSource = db.vWolnePolki.ToList();
            }
            else
            {
                DataTable brakPolek = new DataTable();
                brakPolek.Columns.Add("Informacja");
                brakPolek.Rows.Add("Nie ma wolnych polek");
                dgvWolnePolki.DataSource = brakPolek;
            }
            if (db.vPracownicyMagazynu.Where(pracownik => pracownik.ID_Pracownika > 0).Any())
            {
                cmbPracownicy.DataSource = db.vPracownicyMagazynu.ToList();
                cmbPracownicy.DisplayMember = "Dane_osobowe";
                cmbPracownicy.ValueMember = "ID_Pracownika";
            }
            else
            {
                DataTable brakPracownikow = new DataTable();
                brakPracownikow.Columns.Add("Informacja");
                brakPracownikow.Rows.Add("Nie ma takich pracownikow");
                cmbPracownicy.DataSource = brakPracownikow;
                cmbPracownicy.DisplayMember = "Informacja";
                cmbPracownicy.ValueMember = "Informacja";
            }
        }
        private void WyborPolkiDoOdlozenia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czyWyswietlicStart)
            {
                if(Application.OpenForms.OfType<ObslugaDostaw>().Count()>0)
                {
                    Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
                }
                else
                {
                    ObslugaDostaw otworzPonownieMagazynForm = new ObslugaDostaw();
                    otworzPonownieMagazynForm.Show();
                }
            }
        }

        private void dgvWolnePolki_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnApply_Click(sender,e);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rodzajFormularza == "dostawa")
            {
                int idPracownikaZCombobox = Convert.ToInt32(cmbPracownicy.SelectedValue);
                vPracownicyMagazynu pracownikWybrany = db.vPracownicyMagazynu.Where(danePracownika => danePracownika.ID_Pracownika == idPracownikaZCombobox).First();
                int intIDPracownikaWybranego = pracownikWybrany.ID_Pracownika;
                int intIDPolki = Convert.ToInt32(dgvWolnePolki.CurrentRow.Cells[0].Value);
                int intMiejsceDostawy = 7;
                Dostarczenia_Wewn nowaDostawaRejestr = new Dostarczenia_Wewn();
                string dataDzis = Convert.ToString(DateTime.Now).Substring(0, 10);
                nowaDostawaRejestr.ID_Pracownicy = intIDPracownikaWybranego;
                nowaDostawaRejestr.ID_Dostawy = intDostawaID;
                nowaDostawaRejestr.ID_element = intElementID;
                nowaDostawaRejestr.Ilosc_Dostarczona = intIlosc;
                nowaDostawaRejestr.ID_Miejsca = intMiejsceDostawy;
                nowaDostawaRejestr.Data_Dostarczenia = dataDzis;
                db.Dostarczenia_Wewn.Add(nowaDostawaRejestr);
                db.SaveChanges();
                Zawartosc nowaZawartoscPolki = new Zawartosc();
                nowaZawartoscPolki.ID_Polka = intIDPolki;
                nowaZawartoscPolki.Ilosc_Paczek = intIloscPaczek;
                nowaZawartoscPolki.ID_Element = intElementID;
                nowaZawartoscPolki.ID_Dostawy = intDostawaID;
                db.Zawartosc.Add(nowaZawartoscPolki);
                db.SaveChanges();
                Zamowienia_Dostawy dostawaDoUpdate = db.Zamowienia_Dostawy.Where(dostawaNadpisywana => dostawaNadpisywana.ID_Dostawy == intDostawaID).First();
                dostawaDoUpdate.Data_Dostawy_Rzeczywista = DateTime.Now;
                //db.SaveChanges();
                Start.DataBaseRefresh();
                PrzyjmowanieDostaw.czyZamknietyPrzezInny = true;
                Application.OpenForms["PrzyjmowanieDostaw"].Close();
                czyWyswietlicStart = false;
                if (db.vDostawyDoOdbioru.Where(doOdebrania => doOdebrania.Ilosc > 0).Any() == false)
                {
                    PrzyjmowanieDostaw kolejnaDostawa = new PrzyjmowanieDostaw(true);
                    kolejnaDostawa.Show();
                }
                else
                {
                    PrzyjmowanieDostaw kolejnaDostawa = new PrzyjmowanieDostaw(false);
                    kolejnaDostawa.Show();
                }
                this.Close();
            }
            else if (rodzajFormularza == "przyjecieResztek")
            {
                int idPracownikaZCombobox = Convert.ToInt32(cmbPracownicy.SelectedValue);
                vPracownicyMagazynu pracownikWybrany = db.vPracownicyMagazynu.Where(danePracownika => danePracownika.ID_Pracownika == idPracownikaZCombobox).First();
                int intIDPracownikaWybranego = pracownikWybrany.ID_Pracownika;
                int intIDPolki = Convert.ToInt32(dgvWolnePolki.CurrentRow.Cells[0].Value);
                int intMiejsceDostawy = 2;
                Dostarczenia_Wewn nowaDostawaRejestr = new Dostarczenia_Wewn();
                string dataDzis = Convert.ToString(DateTime.Now).Substring(0, 10);
                nowaDostawaRejestr.ID_Pracownicy = intIDPracownikaWybranego;
                nowaDostawaRejestr.ID_Dostawy = intDostawaID;
                nowaDostawaRejestr.ID_element = intElementID;
                nowaDostawaRejestr.Ilosc_Dostarczona = intIlosc;
                nowaDostawaRejestr.ID_Miejsca = intMiejsceDostawy;
                nowaDostawaRejestr.Data_Dostarczenia = dataDzis;
                nowaDostawaRejestr.ID_Zamowienie_element = intZamowienieElementID;
                db.Dostarczenia_Wewn.Add(nowaDostawaRejestr);
                db.SaveChanges();
                Start.DataBaseRefresh();
                Zawartosc nowaZawartoscPolki = new Zawartosc();
                nowaZawartoscPolki.ID_Polka = intIDPolki;
                nowaZawartoscPolki.Ilosc_Paczek = Convert.ToSingle(dblIloscDlaPolki);
                nowaZawartoscPolki.ID_Element = intElementID;
                nowaZawartoscPolki.ID_Dostawy = intDostawaID;
                db.Zawartosc.Add(nowaZawartoscPolki);
                db.SaveChanges();
                Start.DataBaseRefresh();
                czyWyswietlicStart = false;
                OdbierzMaterialZProdukcji.czyZamknietyPrzezInny = true;
                Application.OpenForms[typeof(OdbierzMaterialZProdukcji).Name].Close();
                OdbierzMaterialZProdukcji odbierzKolejnyMaterial = new OdbierzMaterialZProdukcji();
                OdbierzMaterialZProdukcji.czyZamknietyPrzezInny = false;
                odbierzKolejnyMaterial.Show();
                this.Close();
                
            }    
        }

    }
}
