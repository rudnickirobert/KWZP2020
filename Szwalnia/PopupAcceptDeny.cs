using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        public int intIDZamowienieElement;
        public int intElementID;
        public int intIDDostawcy;
        public int intIDDostawy;
        public int intPolka;
        public int intDostawa;
        public int intIlosc;
        public int intPracownikID;
        public int intOferta;
        public int intUmowaID;
        public int intIloscMaterialowZBrakiem = 0;
        public vZamowieniaDostawyWlasneZawartoscPolki przechowalnia = null;
        public bool czyOfertaWielePolek = false;
        public bool czyPrzypisaniePracownika = false;
        public bool boolCzyCancel = false;
        public bool czyOferta;
        public bool czyWydanie=false;
        public bool czyPrzypisanieDoDostawy = false;
        Dostawcy_Zaopatrzenie dostawcaWybrany = new Dostawcy_Zaopatrzenie();
        public PopupAcceptDeny(bool czyOferta, int intIDDostawcy, int intIDZamowienie, int intIlosc, int intOferta, int intElementID)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.czyOferta = czyOferta;
            this.intIDZamowienie = intIDZamowienie;
            this.intIlosc = intIlosc;
            this.intOferta = intOferta;
            this.intElementID = intElementID;
            this.intIDDostawcy = intIDDostawcy;
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
            lblInfo.Text = "Czy na pewno chcesz wybrac materiał z półki nr " + Convert.ToString(intPolka)+"?";
        }
        public PopupAcceptDeny(bool czyWydanie,int intIDZamowienia, int intIDElement, int intIDDostawy, int intIDPolka, int intIlosc, int intPracownikID)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.czyWydanie = czyWydanie;
            this.intIDZamowienie = intIDZamowienia;
            this.intElementID = intIDElement;
            this.intIDDostawy = intIDDostawy;
            this.intPolka = intIDPolka;
            this.intIlosc = intIlosc;
            this.intPracownikID = intPracownikID;
            lblInfo.Text = "Czy na pewno chcesz wydać materiał?";
        }

        public PopupAcceptDeny(int intIDZamowienie, int intPracownikID, int intUmowaID, bool czyPrzypisaniePracownika)
        {
            InitializeComponent();
            db = Start.szwalnia;
            czyPrzypisanieDoDostawy = true;
            this.intIDZamowienie = intIDZamowienie;
            this.intPracownikID = intPracownikID;
            this.intUmowaID = intUmowaID;
            this.czyPrzypisaniePracownika = czyPrzypisaniePracownika;
            Pracownicy pracownikWybrany = db.Pracownicy.Where(wybrany => wybrany.ID_Pracownika == intPracownikID).First();
            string strImie = pracownikWybrany.Imie;
            string strNazwisko = pracownikWybrany.Nazwisko;
            string strDaneOsobowe = strImie + " " + strNazwisko;
            vUmowyKurierzyNazwyKurierow wybranyKurier = db.vUmowyKurierzyNazwyKurierow.Where(wybrany => wybrany.ID_Umowy == intUmowaID).First();
            string strNazwaKuriera = wybranyKurier.Nazwa;
            lblInfo.Text = "Czy na pewno chcesz przypisać "+ strDaneOsobowe +" oraz firmę "+strNazwaKuriera +" do zamówienia nr " + Convert.ToString(intIDZamowienie)+"?";
        }
        public PopupAcceptDeny(int intElementID, int intIDZamowienie)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.intElementID = intElementID;
            this.intIDZamowienie = intIDZamowienie;
            czyOfertaWielePolek = true;
            lblInfo.Text = "Czy na pewno chcesz wybrać cały dostępny materiał na magazynie?";

        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!czyOfertaWielePolek)
            {
                if (!czyPrzypisanieDoDostawy)
                {
                    if (!czyWydanie)
                    {
                        //akcja zapisz dostawce/polke
                        if (czyOferta)
                        {
                            //wstawianie do tabel
                            if (db.vDostawcyDostawDoZamowien.Where(poszukiwanyDostawca => poszukiwanyDostawca.ID_Dostawcy == intIDDostawcy).Where(poszukiwanyDostawca => poszukiwanyDostawca.ID_Zamowienia == intIDZamowienie).Any())
                            {
                                vDostawcyDostawDoZamowien poszukiwanyZestawDanych = db.vDostawcyDostawDoZamowien.Where(poszukiwanyDostawca => poszukiwanyDostawca.ID_Dostawcy == intIDDostawcy).Where(poszukiwanyDostawca => poszukiwanyDostawca.ID_Zamowienia == intIDZamowienie).First();
                                int intIDDostawy = poszukiwanyZestawDanych.ID_Dostawy;
                                Dostawy_Zawartosc nowaZawartoscDoDostawy = new Dostawy_Zawartosc();
                                nowaZawartoscDoDostawy.ID_Dostawy = intIDDostawy;
                                nowaZawartoscDoDostawy.ID_Element = intElementID;
                                nowaZawartoscDoDostawy.ID_oferta = intOferta;
                                nowaZawartoscDoDostawy.Ilosc_Dostarczona = intIlosc;
                                db.Dostawy_Zawartosc.Add(nowaZawartoscDoDostawy);
                                db.SaveChanges();
                                Start.DataBaseRefresh();
                            }
                            else
                            {
                                //nowa dostawa
                                Zamowienia_Dostawy nowaDostawa = new Zamowienia_Dostawy();
                                nowaDostawa.ID_statusu = 1;
                                nowaDostawa.ID_Zamowienia = intIDZamowienie;
                                db.Zamowienia_Dostawy.Add(nowaDostawa);
                                db.SaveChanges();
                                Start.DataBaseRefresh();
                                //nowa zawartosc
                                int intIDDostawy = db.Zamowienia_Dostawy.Count();
                                Dostawy_Zawartosc nowaZawartosc = new Dostawy_Zawartosc();
                                nowaZawartosc.ID_Dostawy = intIDDostawy;
                                nowaZawartosc.ID_Element = intElementID;
                                nowaZawartosc.ID_oferta = intOferta;
                                nowaZawartosc.Ilosc_Dostarczona = intIlosc;
                                db.Dostawy_Zawartosc.Add(nowaZawartosc);
                                db.SaveChanges();
                                Start.DataBaseRefresh();
                            }
                            //zamykanie formularzy
                            //zamykanie formularzy
                            WyborOferty.czyZamknietyPrzezInny = true;
                            Application.OpenForms["WyborOferty"].Close();
                            if (Application.OpenForms.OfType<DodawanieDostaw>().Count() > 0)
                            {
                                DodawanieDostaw.czyZamknietyPrzezInny = true;
                                Application.OpenForms["DodawanieDostaw"].Close();
                            }
                            WyborOferty.czyZamknietyPrzezInny = false;
                            DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(!db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any());
                            formularzDodawanieDostaw.Show();
                            boolCzyCancel = true;
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
                            int IDDostawyWlasne = db.Zamowienia_Dostawy_Wlasne.Count();
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
                            boolCzyCancel = true;
                            this.Close();
                        }
                    }
                    else
                    {
                        List<vDostawyNiewydaneBezDatBezPowtorzen> listaDoWstawienia = db.vDostawyNiewydaneBezDatBezPowtorzen.Where(wybraneRekordy => wybraneRekordy.ID_Dostawy == intIDDostawy).Where(wybraneRekordy => wybraneRekordy.ID_Dostawy == intIDDostawy).ToList();
                        Dostarczenia_Wewn noweWydanie = new Dostarczenia_Wewn();
                        vDostawyIloscDoWydania iloscMaterialuWDostawie = db.vDostawyIloscDoWydania.Where(zamowienie => zamowienie.ID_Dostawy == intIDDostawy).First();
                        int intIloscCalkowita = Convert.ToInt32(iloscMaterialuWDostawie.Ilosc);
                        int[,] intArrayCzyIloscToZero = new int[listaDoWstawienia.Count+1,2];
                        int intNumerPetli = 0;
                        foreach (vDostawyNiewydaneBezDatBezPowtorzen wierszWybrany in listaDoWstawienia)
                        {
                            bool czyTrue = false;
                            noweWydanie.ID_Pracownicy = intPracownikID;
                            noweWydanie.ID_Dostawy = wierszWybrany.ID_Dostawy;
                            noweWydanie.ID_Zamowienie_element = wierszWybrany.ID_Zamowienie_Element;
                            noweWydanie.ID_element = wierszWybrany.ID_Element;
                            noweWydanie.Ilosc_Dostarczona = (-1) * wierszWybrany.Ilosc;
                            intIloscCalkowita = intIloscCalkowita + Convert.ToInt32(noweWydanie.Ilosc_Dostarczona);
                            if (intIloscCalkowita<0)
                            {
                                czyTrue = true;
                                intIloscMaterialowZBrakiem++;
                                intArrayCzyIloscToZero[intNumerPetli, 0] = wierszWybrany.ID_Zamowienie_Element;
                                intArrayCzyIloscToZero[intNumerPetli, 1] = intIloscCalkowita;                                
                            }    
                            if (czyTrue)
                            {
                                intIloscCalkowita = 0;
                            }
                            noweWydanie.ID_Miejsca = 2;
                            noweWydanie.Data_Dostarczenia = (Convert.ToString(DateTime.Now)).Substring(0, 10);
                            db.Dostarczenia_Wewn.Add(noweWydanie);
                            db.SaveChanges();
                            Start.DataBaseRefresh();
                            intNumerPetli = intNumerPetli++;
                        }
                        Zawartosc polkaDoWyczyszczenia = db.Zawartosc.Where(polka => polka.ID_Polka == intPolka).First();
                        db.Zawartosc.Remove(polkaDoWyczyszczenia);
                        db.SaveChanges();
                        Start.DataBaseRefresh();
                        //teraz wydaje pozostałe brakujące elementy tego samego typu, które miały zostać pobrane z magazynu ze starych dostaw
                        List<vZamowieniaDostawyWlasneZawartoscPolki> zestawPolek = db.vZamowieniaDostawyWlasneZawartoscPolki.Where(wybrane => wybrane.ID_Zamowienia == intIDZamowienie).ToList();
                        Dostarczenia_Wewn noweDostarczenieWewn = new Dostarczenia_Wewn();
                        
                        for (int i = 0; i< listaDoWstawienia.Count; i++)
                        {
                            int intIloscBrakujaca = 0;
                            int intElementZBrakiem = 0;
                            if (intArrayCzyIloscToZero[i,0]!=0)
                            {
                                intIloscBrakujaca = intArrayCzyIloscToZero[i, 1] * (-1);
                                intElementZBrakiem = intArrayCzyIloscToZero[i, 0];
                                foreach (vZamowieniaDostawyWlasneZawartoscPolki wybranyWiersz in zestawPolek)
                                {
                                    if (intIloscBrakujaca==0)
                                    {
                                        break;
                                    }
                                    if (przechowalnia != null)
                                    {
                                        if (przechowalnia.Ilosc > 0)
                                        {
                                            noweDostarczenieWewn.Ilosc_Dostarczona = przechowalnia.Ilosc * (-1);
                                            noweDostarczenieWewn.ID_Pracownicy = intPracownikID;
                                            noweDostarczenieWewn.ID_Dostawy = przechowalnia.ID_Dostawy;
                                            noweDostarczenieWewn.ID_Zamowienie_element = intElementZBrakiem;
                                            noweDostarczenieWewn.ID_element = przechowalnia.ID_Element;
                                            noweDostarczenieWewn.ID_Miejsca = 2;
                                            noweDostarczenieWewn.Data_Dostarczenia = (Convert.ToString(DateTime.Now)).Substring(0, 10);
                                            Zawartosc usunZPolki = db.Zawartosc.Where(doWyczyszczenia => doWyczyszczenia.ID_Polka == przechowalnia.ID_Polka).First();
                                            db.Dostarczenia_Wewn.Add(noweWydanie);
                                            db.Zawartosc.Remove(usunZPolki);
                                            db.SaveChanges();
                                            Start.DataBaseRefresh();
                                            intIloscBrakujaca = intIloscBrakujaca - Convert.ToInt32(przechowalnia.Ilosc);
                                        }
                                    }
                                    if (intIloscBrakujaca>wybranyWiersz.Ilosc || intIloscMaterialowZBrakiem == 0)
                                    {
                                        noweDostarczenieWewn.Ilosc_Dostarczona = wybranyWiersz.Ilosc*(-1);
                                        noweDostarczenieWewn.ID_Pracownicy = intPracownikID;
                                        noweDostarczenieWewn.ID_Dostawy = wybranyWiersz.ID_Dostawy;
                                        noweDostarczenieWewn.ID_Zamowienie_element = intElementZBrakiem;
                                        noweDostarczenieWewn.ID_element = wybranyWiersz.ID_Element;
                                        noweDostarczenieWewn.ID_Miejsca = 2;
                                        noweDostarczenieWewn.Data_Dostarczenia = (Convert.ToString(DateTime.Now)).Substring(0, 10);
                                        Zawartosc usunZPolki = db.Zawartosc.Where(doWyczyszczenia => doWyczyszczenia.ID_Polka == wybranyWiersz.ID_Polka).First();
                                        db.Dostarczenia_Wewn.Add(noweWydanie);
                                        db.Zawartosc.Remove(usunZPolki);
                                        db.SaveChanges();
                                        Start.DataBaseRefresh();
                                        intIloscBrakujaca = intIloscBrakujaca - Convert.ToInt32(wybranyWiersz.Ilosc);
                                    }
                                    else
                                    {
                                        int iloscDoPrzypisania = Convert.ToInt32(wybranyWiersz.Ilosc) - intIloscBrakujaca;
                                        noweDostarczenieWewn.Ilosc_Dostarczona = iloscDoPrzypisania * (-1);
                                        noweDostarczenieWewn.ID_Pracownicy = intPracownikID;
                                        noweDostarczenieWewn.ID_Dostawy = wybranyWiersz.ID_Dostawy;
                                        noweDostarczenieWewn.ID_Zamowienie_element = intElementZBrakiem;
                                        noweDostarczenieWewn.ID_element = wybranyWiersz.ID_Element;
                                        noweDostarczenieWewn.ID_Miejsca = 2;
                                        noweDostarczenieWewn.Data_Dostarczenia = (Convert.ToString(DateTime.Now)).Substring(0, 10);
                                        Zawartosc usunZPolki = db.Zawartosc.Where(doWyczyszczenia => doWyczyszczenia.ID_Polka == wybranyWiersz.ID_Polka).First();
                                        double dblIloscDoUsuniecia = Convert.ToDouble(usunZPolki.Ilosc_Paczek) - Convert.ToDouble(iloscDoPrzypisania) / Convert.ToDouble(wybranyWiersz.Ilosc);
                                        przechowalnia = wybranyWiersz;
                                        przechowalnia.Ilosc = wybranyWiersz.Ilosc - iloscDoPrzypisania;
                                        db.SaveChanges();
                                        Start.DataBaseRefresh();
                                        intIloscMaterialowZBrakiem--;
                                        break;
                                    }
                                    
                                }

                            }
                        }
                        //koniec wydawania pozostałych brakujących elementów
                        WydajMaterialProdukcji.czyZamknietyPrzezInny = true;
                        Application.OpenForms[typeof(WydajMaterialProdukcji).Name].Close();
                        WydajMaterialProdukcji.czyZamknietyPrzezInny = false;
                        WydajMaterialProdukcji wydajKolejny = new WydajMaterialProdukcji();
                        wydajKolejny.Show();
                        boolCzyCancel = true;
                        this.Close();
                    }
                }
                else
                {
                    Zamowienia_Przydzial nowyPrzydzialZamowienia = new Zamowienia_Przydzial();
                    nowyPrzydzialZamowienia.ID_Pracownicy = intPracownikID;
                    nowyPrzydzialZamowienia.ID_Zamowienia = intIDZamowienie;
                    nowyPrzydzialZamowienia.ID_Umowy = intUmowaID;
                    db.Zamowienia_Przydzial.Add(nowyPrzydzialZamowienia);
                    if (Application.OpenForms.OfType<PrzypiszPracownikaKuriera>().Count() > 0)
                    {
                        PrzypiszPracownikaKuriera.czyZamknietyPrzezInny = true;
                        Application.OpenForms[typeof(PrzypiszPracownikaKuriera).Name].Close();
                        PrzypiszPracownikaKuriera.czyZamknietyPrzezInny = false;
                    }
                    db.SaveChanges();
                    Start.DataBaseRefresh();
                    PrzypiszPracownikaKuriera nowePrzypisanie = new PrzypiszPracownikaKuriera();
                    nowePrzypisanie.Show();
                    boolCzyCancel = true;
                    this.Close();
                }
            }
            else
            {
                List<vZawartoscMagazynuDoPrzydzialuZabezpieczona> listaPozycjiMagazynowych = db.vZawartoscMagazynuDoPrzydzialuZabezpieczona.Where(element => element.ID_Element == intElementID).ToList();
                Zamowienia_Dostawy_Wlasne nowaWlasnaDostawa = new Zamowienia_Dostawy_Wlasne();
                nowaWlasnaDostawa.ID_Zamowienia = intIDZamowienie;
                nowaWlasnaDostawa.ID_miejsca = 1;
                db.Zamowienia_Dostawy_Wlasne.Add(nowaWlasnaDostawa);
                db.SaveChanges();
                int IDDostawyWlasne = db.Zamowienia_Dostawy_Wlasne.Count();
                Dostawy_Wlasne_Zawartosc noweZasobyDlaZamowieniaWlasnego = new Dostawy_Wlasne_Zawartosc();
                foreach (vZawartoscMagazynuDoPrzydzialuZabezpieczona wierszWybrany in listaPozycjiMagazynowych)
                {
                    noweZasobyDlaZamowieniaWlasnego.ID_Zamowienia_dostawy_wlasne = IDDostawyWlasne;
                    noweZasobyDlaZamowieniaWlasnego.ID_Element = wierszWybrany.ID_Element;
                    noweZasobyDlaZamowieniaWlasnego.ID_Dostawy = wierszWybrany.ID_Dostawy;
                    noweZasobyDlaZamowieniaWlasnego.Ilosc = Convert.ToInt32(wierszWybrany.Ilosc);
                    db.Dostawy_Wlasne_Zawartosc.Add(noweZasobyDlaZamowieniaWlasnego);
                    db.SaveChanges();
                    intPolka = Convert.ToInt32(wierszWybrany.ID_Polka);
                    Zawartosc polkaZKtorejWzieto = db.Zawartosc.Where(polkaWybrana => polkaWybrana.ID_Polka == intPolka).First();
                    db.Zawartosc.Remove(polkaZKtorejWzieto);
                    db.SaveChanges();
                    Start.DataBaseRefresh();
                }
                WyborOferty.czyZamknietyPrzezInny = true;
                Application.OpenForms["WyborOferty"].Close();
                if (Application.OpenForms.OfType<DodawanieDostaw>().Count() > 0)
                {
                    DodawanieDostaw.czyZamknietyPrzezInny = true;
                    Application.OpenForms["DodawanieDostaw"].Close();
                }
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(!db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any());
                formularzDodawanieDostaw.Show();
                boolCzyCancel = true;
                this.Close();
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            //akcja powrot
            if (!czyPrzypisaniePracownika)
            {
                if (!czyPrzypisanieDoDostawy)
                {
                    if (!czyWydanie)
                    {
                        boolCzyCancel = true;
                        this.Close();
                    }
                    else
                    {
                        boolCzyCancel = true;
                        this.Close();
                    }
                }
                else
                {
                    boolCzyCancel = true;
                    this.Close();
                }
            }
            else
            {
                PrzypiszPracownikaKuriera nowePrzypisanie = new PrzypiszPracownikaKuriera();
                nowePrzypisanie.Show();
                boolCzyCancel = true;
                this.Close();
            }
        }

        private void PopupAcceptDeny_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!boolCzyCancel)
            {
                Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
                if (Application.OpenForms.OfType<WydajMaterialProdukcji>().Count() > 0)
                {
                    Application.OpenForms[typeof(WydajMaterialProdukcji).Name].Close();
                }
                if (Application.OpenForms.OfType<WyborOferty>().Count() > 0)
                {
                    Application.OpenForms[typeof(WyborOferty).Name].Close();
                }
            }
            
        }
    }
}
