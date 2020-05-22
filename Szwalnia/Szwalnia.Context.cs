﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szwalnia
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SzwalniaEntities : DbContext
    {
        public SzwalniaEntities()
            : base("name=SzwalniaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Czesci_Obsluga> Czesci_Obsluga { get; set; }
        public virtual DbSet<Dokumentacja_Proces> Dokumentacja_Proces { get; set; }
        public virtual DbSet<Dokumentacje> Dokumentacje { get; set; }
        public virtual DbSet<Dostarczenia_Wewn> Dostarczenia_Wewn { get; set; }
        public virtual DbSet<Dostarczenia_Zewn> Dostarczenia_Zewn { get; set; }
        public virtual DbSet<Dostawcy_Zaopatrzenie> Dostawcy_Zaopatrzenie { get; set; }
        public virtual DbSet<Dostawy_Wlasne_Zawartosc> Dostawy_Wlasne_Zawartosc { get; set; }
        public virtual DbSet<Dostawy_Zawartosc> Dostawy_Zawartosc { get; set; }
        public virtual DbSet<Dzialy> Dzialy { get; set; }
        public virtual DbSet<Elementy> Elementy { get; set; }
        public virtual DbSet<Elementy_Cechy> Elementy_Cechy { get; set; }
        public virtual DbSet<Elementy_Cechy_Slownik> Elementy_Cechy_Slownik { get; set; }
        public virtual DbSet<Elementy_Jednostki> Elementy_Jednostki { get; set; }
        public virtual DbSet<Elementy_Proces> Elementy_Proces { get; set; }
        public virtual DbSet<Elementy_Typy> Elementy_Typy { get; set; }
        public virtual DbSet<Etapy_W_Procesie> Etapy_W_Procesie { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Faktury_Zewnetrzne> Faktury_Zewnetrzne { get; set; }
        public virtual DbSet<Grupa> Grupa { get; set; }
        public virtual DbSet<Jezyk> Jezyk { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Kontrola_Efektywnosci> Kontrola_Efektywnosci { get; set; }
        public virtual DbSet<Kurierzy> Kurierzy { get; set; }
        public virtual DbSet<Maszyny> Maszyny { get; set; }
        public virtual DbSet<Maszyny_Proces> Maszyny_Proces { get; set; }
        public virtual DbSet<Material_Na_Produkcji> Material_Na_Produkcji { get; set; }
        public virtual DbSet<Miejsca> Miejsca { get; set; }
        public virtual DbSet<Obsluga_Techniczna> Obsluga_Techniczna { get; set; }
        public virtual DbSet<Odbior_Dostarczenia> Odbior_Dostarczenia { get; set; }
        public virtual DbSet<Oferta> Oferta { get; set; }
        public virtual DbSet<Pensja> Pensja { get; set; }
        public virtual DbSet<Polki> Polki { get; set; }
        public virtual DbSet<Polki_regaly> Polki_regaly { get; set; }
        public virtual DbSet<Polki_Rozmiary> Polki_Rozmiary { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Pracownicy_Zatrudnienie> Pracownicy_Zatrudnienie { get; set; }
        public virtual DbSet<Proces_Produkcyjny> Proces_Produkcyjny { get; set; }
        public virtual DbSet<Proces_Technologiczny> Proces_Technologiczny { get; set; }
        public virtual DbSet<Proces_Zamowienie> Proces_Zamowienie { get; set; }
        public virtual DbSet<Przydzial_Zasobow> Przydzial_Zasobow { get; set; }
        public virtual DbSet<Realizacja_Procesu> Realizacja_Procesu { get; set; }
        public virtual DbSet<Regaly> Regaly { get; set; }
        public virtual DbSet<Rodzaj_Dokumentacji> Rodzaj_Dokumentacji { get; set; }
        public virtual DbSet<Rodzaj_Etapu> Rodzaj_Etapu { get; set; }
        public virtual DbSet<Rodzaj_Maszyny> Rodzaj_Maszyny { get; set; }
        public virtual DbSet<Rodzaj_Obslugi> Rodzaj_Obslugi { get; set; }
        public virtual DbSet<Rodzaj_Umowy> Rodzaj_Umowy { get; set; }
        public virtual DbSet<Rodzaj_Urlopu> Rodzaj_Urlopu { get; set; }
        public virtual DbSet<Srodki_Trwale> Srodki_Trwale { get; set; }
        public virtual DbSet<Stanowisko> Stanowisko { get; set; }
        public virtual DbSet<Statusy> Statusy { get; set; }
        public virtual DbSet<Typy_cechy_rejestr> Typy_cechy_rejestr { get; set; }
        public virtual DbSet<Umowy_Kurierzy> Umowy_Kurierzy { get; set; }
        public virtual DbSet<Urlop> Urlop { get; set; }
        public virtual DbSet<Wymiar_Urlopu> Wymiar_Urlopu { get; set; }
        public virtual DbSet<Zamowienia> Zamowienia { get; set; }
        public virtual DbSet<Zamowienia_Dostawy> Zamowienia_Dostawy { get; set; }
        public virtual DbSet<Zamowienia_Dostawy_Wlasne> Zamowienia_Dostawy_Wlasne { get; set; }
        public virtual DbSet<Zamowienia_Przydzial> Zamowienia_Przydzial { get; set; }
        public virtual DbSet<Zamowienie_Element> Zamowienie_Element { get; set; }
        public virtual DbSet<Zawartosc> Zawartosc { get; set; }
        public virtual DbSet<Znajomosc_Jezykow> Znajomosc_Jezykow { get; set; }
        public virtual DbSet<vAktywnoscPracownikaTeraz> vAktywnoscPracownikaTeraz { get; set; }
        public virtual DbSet<vBilans> vBilans { get; set; }
        public virtual DbSet<vCalkowityKosztZamowienia> vCalkowityKosztZamowienia { get; set; }
        public virtual DbSet<vCechyElementu> vCechyElementu { get; set; }
        public virtual DbSet<vCenaZaMaterial> vCenaZaMaterial { get; set; }
        public virtual DbSet<vCzas_do_serwisu> vCzas_do_serwisu { get; set; }
        public virtual DbSet<vCzasZamowieniaTechnologow> vCzasZamowieniaTechnologow { get; set; }
        public virtual DbSet<vDanePracownika> vDanePracownika { get; set; }
        public virtual DbSet<vDokumentacja_info> vDokumentacja_info { get; set; }
        public virtual DbSet<vDokumentacja_proces> vDokumentacja_proces { get; set; }
        public virtual DbSet<vDokumentacja_technologiczna> vDokumentacja_technologiczna { get; set; }
        public virtual DbSet<vDostarczeniaNaProdukcje> vDostarczeniaNaProdukcje { get; set; }
        public virtual DbSet<vDostawcyDostawDoZamowien> vDostawcyDostawDoZamowien { get; set; }
        public virtual DbSet<vDostawyDoOdbioru> vDostawyDoOdbioru { get; set; }
        public virtual DbSet<vDostawyDoWydania> vDostawyDoWydania { get; set; }
        public virtual DbSet<vDostawyIloscDoWydania> vDostawyIloscDoWydania { get; set; }
        public virtual DbSet<vDostawyKtoreMoznaPonowniePrzypisac> vDostawyKtoreMoznaPonowniePrzypisac { get; set; }
        public virtual DbSet<vDostawyMagazynuIDostawcow> vDostawyMagazynuIDostawcow { get; set; }
        public virtual DbSet<vDostawyNiewydaneBezDat> vDostawyNiewydaneBezDat { get; set; }
        public virtual DbSet<vDostawyNiewydaneBezDatBezPowtorzen> vDostawyNiewydaneBezDatBezPowtorzen { get; set; }
        public virtual DbSet<vDostawyNiewydaneZPolkami> vDostawyNiewydaneZPolkami { get; set; }
        public virtual DbSet<vDostawyNiewydaneZPolkamiNiesumowane> vDostawyNiewydaneZPolkamiNiesumowane { get; set; }
        public virtual DbSet<vDostawyZawartoscInformacjeDostawcy> vDostawyZawartoscInformacjeDostawcy { get; set; }
        public virtual DbSet<vElementy_proces> vElementy_proces { get; set; }
        public virtual DbSet<vElementyDlaZamowien> vElementyDlaZamowien { get; set; }
        public virtual DbSet<vElementyProcesProdukcyjny> vElementyProcesProdukcyjny { get; set; }
        public virtual DbSet<vElemntyy> vElemntyy { get; set; }
        public virtual DbSet<vEtapy_proces> vEtapy_proces { get; set; }
        public virtual DbSet<vEwidencja_dostaw_wewnetrznych> vEwidencja_dostaw_wewnetrznych { get; set; }
        public virtual DbSet<vEwidencja_dostaw_zewnetrznych> vEwidencja_dostaw_zewnetrznych { get; set; }
        public virtual DbSet<vFaktury> vFaktury { get; set; }
        public virtual DbSet<vFakturyZewnetrzne> vFakturyZewnetrzne { get; set; }
        public virtual DbSet<vImieNazwiskoPracownika> vImieNazwiskoPracownika { get; set; }
        public virtual DbSet<vJezyk> vJezyk { get; set; }
        public virtual DbSet<vJezykiPracownika> vJezykiPracownika { get; set; }
        public virtual DbSet<vJezykiWFirmie> vJezykiWFirmie { get; set; }
        public virtual DbSet<vKlienci> vKlienci { get; set; }
        public virtual DbSet<vKlienciZamowienie> vKlienciZamowienie { get; set; }
        public virtual DbSet<vKompletnyProces> vKompletnyProces { get; set; }
        public virtual DbSet<vKontrolaProcesu> vKontrolaProcesu { get; set; }
        public virtual DbSet<vKoszty> vKoszty { get; set; }
        public virtual DbSet<vKosztyMaterialowe> vKosztyMaterialowe { get; set; }
        public virtual DbSet<vMaszynownia> vMaszynownia { get; set; }
        public virtual DbSet<vMaszyny_numer_seryjny> vMaszyny_numer_seryjny { get; set; }
        public virtual DbSet<vMaszyny_proces> vMaszyny_proces { get; set; }
        public virtual DbSet<vMaszyny_rodzaj_liczba> vMaszyny_rodzaj_liczba { get; set; }
        public virtual DbSet<vMaszyny_serwis> vMaszyny_serwis { get; set; }
        public virtual DbSet<vMaterialy> vMaterialy { get; set; }
        public virtual DbSet<vMaterialyDoZamowienia> vMaterialyDoZamowienia { get; set; }
        public virtual DbSet<vMaterialyDoZamowieniaBrak> vMaterialyDoZamowieniaBrak { get; set; }
        public virtual DbSet<vMaterialyNiewydaneZDatami> vMaterialyNiewydaneZDatami { get; set; }
        public virtual DbSet<vMaterialyOdebraneZProdukcji> vMaterialyOdebraneZProdukcji { get; set; }
        public virtual DbSet<vMaterialyZamowione> vMaterialyZamowione { get; set; }
        public virtual DbSet<vMechanicy> vMechanicy { get; set; }
        public virtual DbSet<vNieodebraneMaterialyWgDostawcyZNazwaIOferta> vNieodebraneMaterialyWgDostawcyZNazwaIOferta { get; set; }
        public virtual DbSet<vNieodebraneMaterialyWgDostawy> vNieodebraneMaterialyWgDostawy { get; set; }
        public virtual DbSet<vNieodebraneMaterialyWgDostawyZNazwa> vNieodebraneMaterialyWgDostawyZNazwa { get; set; }
        public virtual DbSet<vNieodebraneMaterialyWgZamowienieElement> vNieodebraneMaterialyWgZamowienieElement { get; set; }
        public virtual DbSet<vNierealizowaneZamowienieElement> vNierealizowaneZamowienieElement { get; set; }
        public virtual DbSet<vNieuzytyMaterialOdpad> vNieuzytyMaterialOdpad { get; set; }
        public virtual DbSet<vNiezuzytyMaterialNaProdukcji> vNiezuzytyMaterialNaProdukcji { get; set; }
        public virtual DbSet<vObsluga> vObsluga { get; set; }
        public virtual DbSet<vOdbior_Gotowych_Produktow> vOdbior_Gotowych_Produktow { get; set; }
        public virtual DbSet<vOdebranyMaterialMagazyn> vOdebranyMaterialMagazyn { get; set; }
        public virtual DbSet<vOdebranyMaterialProdukcja> vOdebranyMaterialProdukcja { get; set; }
        public virtual DbSet<vOferta> vOferta { get; set; }
        public virtual DbSet<vOferty_Zebrane> vOferty_Zebrane { get; set; }
        public virtual DbSet<vPolki_na_regalach> vPolki_na_regalach { get; set; }
        public virtual DbSet<vPolki_Rozmiary> vPolki_Rozmiary { get; set; }
        public virtual DbSet<vPotrzebnaDokumentacjaDoProcesuProdukcyjnego> vPotrzebnaDokumentacjaDoProcesuProdukcyjnego { get; set; }
        public virtual DbSet<vPotrzebneEtapyDoProcesuProdukcyjnego> vPotrzebneEtapyDoProcesuProdukcyjnego { get; set; }
        public virtual DbSet<vPotrzebneMaszynyDoProcesuProdukcyjnego> vPotrzebneMaszynyDoProcesuProdukcyjnego { get; set; }
        public virtual DbSet<vPotrzebnyMaterialDoProcesuProdukcyjnego> vPotrzebnyMaterialDoProcesuProdukcyjnego { get; set; }
        public virtual DbSet<vPotrzebyProdukcjiZDatami> vPotrzebyProdukcjiZDatami { get; set; }
        public virtual DbSet<vPracownicyMagazynu> vPracownicyMagazynu { get; set; }
        public virtual DbSet<vProces_elementy> vProces_elementy { get; set; }
        public virtual DbSet<vProces_Etapy> vProces_Etapy { get; set; }
        public virtual DbSet<vProces_Maszyna> vProces_Maszyna { get; set; }
        public virtual DbSet<vProces_technologiczny> vProces_technologiczny { get; set; }
        public virtual DbSet<vProces_technologicznyy> vProces_technologicznyy { get; set; }
        public virtual DbSet<vProcesy> vProcesy { get; set; }
        public virtual DbSet<vProduktyDoWykonania> vProduktyDoWykonania { get; set; }
        public virtual DbSet<vProduktyNiewykonane> vProduktyNiewykonane { get; set; }
        public virtual DbSet<vProduktyWykonane> vProduktyWykonane { get; set; }
        public virtual DbSet<vPrzychody> vPrzychody { get; set; }
        public virtual DbSet<vPrzydzialZasobow> vPrzydzialZasobow { get; set; }
        public virtual DbSet<vPrzydzialZasobowEtap> vPrzydzialZasobowEtap { get; set; }
        public virtual DbSet<vRealizacjaProcesuProdukcyjnego> vRealizacjaProcesuProdukcyjnego { get; set; }
        public virtual DbSet<vRealizowaneZamowienieElement> vRealizowaneZamowienieElement { get; set; }
        public virtual DbSet<vRegaly_alfabetycznie> vRegaly_alfabetycznie { get; set; }
        public virtual DbSet<vResurs> vResurs { get; set; }
        public virtual DbSet<vRodzaj_Maszyny> vRodzaj_Maszyny { get; set; }
        public virtual DbSet<vRodzajUmowy> vRodzajUmowy { get; set; }
        public virtual DbSet<vRozchody> vRozchody { get; set; }
        public virtual DbSet<vRoznicaDatDni> vRoznicaDatDni { get; set; }
        public virtual DbSet<vRoznicaDniBezWeekend> vRoznicaDniBezWeekend { get; set; }
        public virtual DbSet<vRoznicaGodzin> vRoznicaGodzin { get; set; }
        public virtual DbSet<vSrednia_ilosc_maszyn> vSrednia_ilosc_maszyn { get; set; }
        public virtual DbSet<vSredniaLiczbaSztuk> vSredniaLiczbaSztuk { get; set; }
        public virtual DbSet<vSredniCzasSztuki> vSredniCzasSztuki { get; set; }
        public virtual DbSet<vSredniCzasWedlugElementu> vSredniCzasWedlugElementu { get; set; }
        public virtual DbSet<vSrodkiWszystkie> vSrodkiWszystkie { get; set; }
        public virtual DbSet<vSrodkiZamortyzowane> vSrodkiZamortyzowane { get; set; }
        public virtual DbSet<vStan_magazynowy_elementy> vStan_magazynowy_elementy { get; set; }
        public virtual DbSet<vStan_magazynowy_polki> vStan_magazynowy_polki { get; set; }
        public virtual DbSet<vStanowisko> vStanowisko { get; set; }
        public virtual DbSet<vSuma_czasu_procesu> vSuma_czasu_procesu { get; set; }
        public virtual DbSet<vSumaKosztowProdukcji> vSumaKosztowProdukcji { get; set; }
        public virtual DbSet<vSumaKosztowZamowienia> vSumaKosztowZamowienia { get; set; }
        public virtual DbSet<vSzacowanaDataZamowieniaTechnologow> vSzacowanaDataZamowieniaTechnologow { get; set; }
        public virtual DbSet<vTechnolodzy> vTechnolodzy { get; set; }
        public virtual DbSet<vTechnologowie> vTechnologowie { get; set; }
        public virtual DbSet<vUmowyKurierzy> vUmowyKurierzy { get; set; }
        public virtual DbSet<vUmowyKurierzyNazwyKurierow> vUmowyKurierzyNazwyKurierow { get; set; }
        public virtual DbSet<vUrlopPracownika> vUrlopPracownika { get; set; }
        public virtual DbSet<vUrlopyWszyskie> vUrlopyWszyskie { get; set; }
        public virtual DbSet<vWidokPomocniczyDoNiewydaneBezDat> vWidokPomocniczyDoNiewydaneBezDat { get; set; }
        public virtual DbSet<vWolneMaszynyProdukcja> vWolneMaszynyProdukcja { get; set; }
        public virtual DbSet<vWolnePolki> vWolnePolki { get; set; }
        public virtual DbSet<vWolniPracownicyProdukcji> vWolniPracownicyProdukcji { get; set; }
        public virtual DbSet<vWolniPracownicyZarzadzanie> vWolniPracownicyZarzadzanie { get; set; }
        public virtual DbSet<vWszyscyPracownicyProdukcji> vWszyscyPracownicyProdukcji { get; set; }
        public virtual DbSet<vWszystkie_Elementy> vWszystkie_Elementy { get; set; }
        public virtual DbSet<vWszystkie_Maszyny> vWszystkie_Maszyny { get; set; }
        public virtual DbSet<vWszystkieMaszynyProdukcja> vWszystkieMaszynyProdukcja { get; set; }
        public virtual DbSet<vWszystkieZamowienieElement> vWszystkieZamowienieElement { get; set; }
        public virtual DbSet<vWydawanie_Zamowien_Kurierowi> vWydawanie_Zamowien_Kurierowi { get; set; }
        public virtual DbSet<vWynagrodzenia> vWynagrodzenia { get; set; }
        public virtual DbSet<vZamowienia_Do_Wydania> vZamowienia_Do_Wydania { get; set; }
        public virtual DbSet<vZamowienia_Do_Wydania_Kompletne> vZamowienia_Do_Wydania_Kompletne { get; set; }
        public virtual DbSet<vZamowienia_Do_Wydania_Kompletne_Niewydane> vZamowienia_Do_Wydania_Kompletne_Niewydane { get; set; }
        public virtual DbSet<vZamowieniaDostawyWlasneZawartoscPolki> vZamowieniaDostawyWlasneZawartoscPolki { get; set; }
        public virtual DbSet<vZamowieniaDoWykonaniaUDostawcy> vZamowieniaDoWykonaniaUDostawcy { get; set; }
        public virtual DbSet<vZamowieniaDystans> vZamowieniaDystans { get; set; }
        public virtual DbSet<vZamowieniaKomplenteNiewydaneNaPolkach> vZamowieniaKomplenteNiewydaneNaPolkach { get; set; }
        public virtual DbSet<vZamowieniaKompletneNiewydaneNaPolkachCale> vZamowieniaKompletneNiewydaneNaPolkachCale { get; set; }
        public virtual DbSet<vZamowieniaKompletneNiewydaneNaPolkachCaleNumery> vZamowieniaKompletneNiewydaneNaPolkachCaleNumery { get; set; }
        public virtual DbSet<vZamowieniaNieprzypisaneDoPracownikaIKuriera> vZamowieniaNieprzypisaneDoPracownikaIKuriera { get; set; }
        public virtual DbSet<vZamowienie> vZamowienie { get; set; }
        public virtual DbSet<vZamowienieProcesyProdukcyjne> vZamowienieProcesyProdukcyjne { get; set; }
        public virtual DbSet<vZatrudnieniePracownika> vZatrudnieniePracownika { get; set; }
        public virtual DbSet<vZawartoscMagazynuDoPrzydzialu> vZawartoscMagazynuDoPrzydzialu { get; set; }
        public virtual DbSet<vZawartoscMagazynuDoPrzydzialuZabezpieczona> vZawartoscMagazynuDoPrzydzialuZabezpieczona { get; set; }
        public virtual DbSet<vZawartoscZIloscia> vZawartoscZIloscia { get; set; }
        public virtual DbSet<vZyskZZamowienia> vZyskZZamowienia { get; set; }
    }
}
