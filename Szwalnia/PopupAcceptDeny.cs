using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class PopupAcceptDeny : Form
    {
        public SzwalniaEntities db;
        public int intIDZamowienie;
        public int intElementID;
        public int intIDDostawcy;
        public int intPolka;
        public int intDostawa;
        public int intIlosc;

        public bool czyOferta;
        Dostawcy_Zaopatrzenie dostawcaWybrany = new Dostawcy_Zaopatrzenie();
        public PopupAcceptDeny(int intIDDostawcy, int intIDZamowienie)
        {
            InitializeComponent();
            db = Start.szwalnia;
            czyOferta = true;
            this.intIDZamowienie = intIDZamowienie;
            dostawcaWybrany = db.Dostawcy_Zaopatrzenie.Where(wybrany => wybrany.ID_Dostawcy == intIDDostawcy).First();
            lblInfo.Text = "Czy na pewno chcesz wybrać ofertę " + dostawcaWybrany.Nazwa + " ?";
        }
        public PopupAcceptDeny(int intPolka, int intDostawa, int intElementID, int intIlosc, int intIDZamowienie)
        {
            InitializeComponent();
            db = Start.szwalnia;
            czyOferta = false;
            this.intIDZamowienie = intIDZamowienie;
            this.intPolka = intPolka;
            this.intDostawa = intDostawa;
            this.intElementID = intElementID;
            this.intIlosc = intIlosc;
            lblInfo.Text = "Czy na pewno chcesz wybrac materiał z półki " + Convert.ToString(intPolka);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //akcja zapisz dostawce/polke
            if (czyOferta)
            {
                //wstawianie do tabel

                //zamykanie formularzy
                WyborOferty.czyZamknietyPrzezInny = true;
                Application.OpenForms["WyborOferty"].Close();
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(!db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any());
                formularzDodawanieDostaw.Show();
                this.Close();
            }
            else
            {
                //wstawianie do tabel
                Zamowienia_Dostawy_Wlasne nowePrzypisanieDostawyZasobow = new Zamowienia_Dostawy_Wlasne();
                nowePrzypisanieDostawyZasobow.ID_miejsca = 2;
                nowePrzypisanieDostawyZasobow.ID_Zamowienia = intIDZamowienie;
                db.Zamowienia_Dostawy_Wlasne.Add(nowePrzypisanieDostawyZasobow);
                db.SaveChanges();
                vOstatniaDostawaWlasnaID wybranaDostawaWlasna = new vOstatniaDostawaWlasnaID();
                wybranaDostawaWlasna = db.vOstatniaDostawaWlasnaID.Where(dostawaWybrana => dostawaWybrana.ID_Zamowienia == intIDZamowienie).First();
                int IDDostawyWlasne = Convert.ToInt32(wybranaDostawaWlasna.OstatnieID);
                Dostawy_Wlasne_Zawartosc nowePrzypisanieZawartosciDostawyZasobow = new Dostawy_Wlasne_Zawartosc();
                nowePrzypisanieZawartosciDostawyZasobow.ID_Zamowienia_dostawy_wlasne = IDDostawyWlasne;
                nowePrzypisanieZawartosciDostawyZasobow.ID_Element = intElementID;
                nowePrzypisanieZawartosciDostawyZasobow.ID_Dostawy = intDostawa;
                nowePrzypisanieZawartosciDostawyZasobow.Ilosc = intIlosc;
                db.Dostawy_Wlasne_Zawartosc.Add(nowePrzypisanieZawartosciDostawyZasobow);
                db.SaveChanges();
                Zawartosc polkaZKtorejWzieto = db.Zawartosc.Where(polkaWybrana => polkaWybrana.ID_Polka == intPolka).First();
                db.Zawartosc.Remove(polkaZKtorejWzieto);
                db.SaveChanges();
                Start.DataBaseRefresh();
                //zamykanie formularzy
                WyborOferty.czyZamknietyPrzezInny = true;
                Application.OpenForms["WyborOferty"].Close();
                if (Application.OpenForms.OfType<DodawanieDostaw>().Count() > 0)
                {
                    DodawanieDostaw.czyZamknietyPrzezInny = true;
                    Application.OpenForms["DodawanieDostaw"].Close();
                }
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(!db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any());
                formularzDodawanieDostaw.Show();
                this.Close();
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            //akcja powrot
            Application.OpenForms["WyborOferty"].Show();
            this.Close();
            
        }
        
    }
}
