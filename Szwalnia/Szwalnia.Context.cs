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
        public virtual DbSet<Zamowienia_Przydzial> Zamowienia_Przydzial { get; set; }
        public virtual DbSet<Zamowienie_Element> Zamowienie_Element { get; set; }
        public virtual DbSet<Zawartosc> Zawartosc { get; set; }
        public virtual DbSet<Znajomosc_Jezykow> Znajomosc_Jezykow { get; set; }
        public virtual DbSet<vCechyElementu> vCechyElementu { get; set; }
        public virtual DbSet<vCzas_do_serwisu> vCzas_do_serwisu { get; set; }
        public virtual DbSet<vDokumentacja_info> vDokumentacja_info { get; set; }
        public virtual DbSet<vDokumentacja_proces> vDokumentacja_proces { get; set; }
        public virtual DbSet<vDokumentacja_technologiczna> vDokumentacja_technologiczna { get; set; }
        public virtual DbSet<vElementy_proces> vElementy_proces { get; set; }
        public virtual DbSet<vEtapy_proces> vEtapy_proces { get; set; }
        public virtual DbSet<vIdZamowienieElementProcesProdukcyjny> vIdZamowienieElementProcesProdukcyjny { get; set; }
        public virtual DbSet<vMaszyny_numer_seryjny> vMaszyny_numer_seryjny { get; set; }
        public virtual DbSet<vMaszyny_proces> vMaszyny_proces { get; set; }
        public virtual DbSet<vMaszyny_rodzaj_liczba> vMaszyny_rodzaj_liczba { get; set; }
        public virtual DbSet<vMaszyny_serwis> vMaszyny_serwis { get; set; }
        public virtual DbSet<vNiezuzyteWMiesiacu> vNiezuzyteWMiesiacu { get; set; }
        public virtual DbSet<vObsluga> vObsluga { get; set; }
        public virtual DbSet<vPolki_na_regalach> vPolki_na_regalach { get; set; }
        public virtual DbSet<vProces_elementy> vProces_elementy { get; set; }
        public virtual DbSet<vProces_Etapy> vProces_Etapy { get; set; }
        public virtual DbSet<vProces_Maszyna> vProces_Maszyna { get; set; }
        public virtual DbSet<vProces_technologiczny> vProces_technologiczny { get; set; }
        public virtual DbSet<vProcesMaxOdpadMiesiac> vProcesMaxOdpadMiesiac { get; set; }
        public virtual DbSet<vProcesy> vProcesy { get; set; }
        public virtual DbSet<vRealizacjaProcesuProdukcyjnegoDetails> vRealizacjaProcesuProdukcyjnegoDetails { get; set; }
        public virtual DbSet<vRegaly_alfabetycznie> vRegaly_alfabetycznie { get; set; }
        public virtual DbSet<vResurs> vResurs { get; set; }
        public virtual DbSet<vRodzaj_Maszyny> vRodzaj_Maszyny { get; set; }
        public virtual DbSet<vRoznicaDatDni> vRoznicaDatDni { get; set; }
        public virtual DbSet<vRoznicaDniBezWeekend> vRoznicaDniBezWeekend { get; set; }
        public virtual DbSet<vRoznicaGodzin> vRoznicaGodzin { get; set; }
        public virtual DbSet<vSrednia_ilosc_maszyn> vSrednia_ilosc_maszyn { get; set; }
        public virtual DbSet<vSredniCzasWgElementu> vSredniCzasWgElementu { get; set; }
        public virtual DbSet<vStan_magazynowy_polki> vStan_magazynowy_polki { get; set; }
        public virtual DbSet<vSuma_czasu_procesu> vSuma_czasu_procesu { get; set; }
        public virtual DbSet<vSzacowanyCzasWykonania> vSzacowanyCzasWykonania { get; set; }
        public virtual DbSet<vTechnolodzy> vTechnolodzy { get; set; }
        public virtual DbSet<vWszystkie_Elementy> vWszystkie_Elementy { get; set; }
        public virtual DbSet<vWszystkie_Maszyny> vWszystkie_Maszyny { get; set; }
        public virtual DbSet<vZamowienieProcesyProdukcyjne> vZamowienieProcesyProdukcyjne { get; set; }
        public virtual DbSet<vPolki_Rozmiary> vPolki_Rozmiary { get; set; }
    }
}
