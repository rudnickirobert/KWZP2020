USE master
DROP DATABASE Baza_szwalnia
GO
CREATE DATABASE Baza_szwalnia
GO
USE Baza_szwalnia

CREATE TABLE OUTSOURCED_pracownicy (
ID_pracownika char(10) PRIMARY KEY, 
Dane1 char(5), 
Dane2 char(5)
)
CREATE TABLE OUTSOURCED_zamowienia (
ID_zamowienia char(10) PRIMARY KEY, 
Dane1 char(5), 
Dane2 char(5)
)
CREATE TABLE Magazyn_polki_rozmiary (
ID_rozmiar_polki char(5) PRIMARY KEY,
Wysokosc int,
Szerokosc int,
Glebokosc int
)
CREATE TABLE Magazyn_polki (
ID_polka char(10) PRIMARY KEY,
ID_rozmiar_polki char(5) 
	FOREIGN KEY REFERENCES 
	Magazyn_polki_rozmiary(ID_rozmiar_polki)
)

CREATE TABLE Magazyn_elementy_typy (
ID_Element_typ int IDENTITY(1,1) PRIMARY KEY,
Typ char(15)
)

CREATE TABLE Magazyn_elementy_jednostki (
ID_jednostka int IDENTITY(1,1) PRIMARY KEY,
Jednostka char(10)
)
CREATE TABLE Magazyn_elementy (
ID_element int IDENTITY(1,1) PRIMARY KEY,
ID_Element_typ int
	FOREIGN KEY REFERENCES
	Magazyn_elementy_typy (ID_Element_typ),
Element_nazwa char(20),
Element_oznaczenie char(20),
--pe³na iloœæ w opakowaniu zbiorczym np. szpula 12.3 m
Element_ilosc real, 
ID_jednostka int
	FOREIGN KEY REFERENCES
	Magazyn_elementy_jednostki(ID_jednostka)
)

CREATE TABLE Magazyn_elementy_cechy_slownik(
ID_cecha int IDENTITY(1,1) PRIMARY KEY,
Cecha char(20)
)

CREATE TABLE Magazyn_elementy_cechy(
ID_element int 
	FOREIGN KEY REFERENCES
	Magazyn_elementy (ID_element),
ID_cecha int 
	FOREIGN KEY REFERENCES
	Magazyn_elementy_cechy_slownik(ID_cecha),
Wartosc_cechy real
)


CREATE TABLE Magazyn_umowy_kurierzy (
ID_kurier char(10) PRIMARY KEY,
Nazwa char(20),
Telefon_1 int, 
Telefon_2 int, 
Email char(20), 
Koszt_km int, 
Koszt_staly int
)
CREATE TABLE Magazyn_dostawcy_zaopatrzenie (
ID_dostawcy char(10) PRIMARY KEY,
Nazwa char(20),
Telefon_1 int, 
Telefon_2 int, 
Email char(20)
)
CREATE TABLE Magazyn_dostawcy_oferta (
ID_dostawcy char(10) 
	FOREIGN KEY REFERENCES  
	Magazyn_dostawcy_zaopatrzenie(ID_dostawcy), 
ID_element int 
	FOREIGN KEY REFERENCES 
	Magazyn_elementy(ID_element), 
Cena int,
Ilosc_minimalna int,
Ilosc_maksymalna int,
Ilosc_w_opakowaniu_zbiorczym int
	)
CREATE TABLE Magazyn_zamowienia_przydzial (
ID_zamowienia char(10) 
	FOREIGN KEY REFERENCES  
	OUTSOURCED_zamowienia(ID_zamowienia), 
ID_pracownika char(10) 
	FOREIGN KEY REFERENCES 
	OUTSOURCED_pracownicy(ID_pracownika), 
ID_kurier char(10) 
	FOREIGN KEY REFERENCES 
	Magazyn_umowy_kurierzy(ID_kurier)
)
CREATE TABLE Magazyn_zamowienia_dostawy (
ID_dostawy int IDENTITY(1,1) PRIMARY KEY,
ID_zamowienia char(10) 
	FOREIGN KEY REFERENCES
	OUTSOURCED_zamowienia(ID_zamowienia),
/*ID_element int
	FOREIGN KEY REFERENCES 
	Magazyn_elementy(ID_element),*/
Data_dostawy_planowana char(10),
Data_dostawy_rzeczywista char(10),
/*
Ilosc int, 
Cena_jedn money,
Cena money
*/
)
CREATE TABLE Dostawy_zawartosc (
ID_dostawy int
	FOREIGN KEY REFERENCES
	Magazyn_zamowienia_dostawy(ID_dostawy),
ID_element int
	FOREIGN KEY REFERENCES 
	Magazyn_elementy(ID_element),
Ilosc int, 
Cena_jedn money,
Cena money
)

CREATE TABLE Zamowienia_zawartosc (
ID_zamowienia char(10) 
	FOREIGN KEY REFERENCES
	OUTSOURCED_zamowienia(ID_zamowienia),
ID_element int
	FOREIGN KEY REFERENCES 
	Magazyn_elementy(ID_element),
Ilosc int, 
Cena_jedn money,
Cena money
)
/*
CREATE TABLE Magazyn_zamowienia_zaopatrzenie (
ID_zamowienia char(10)
	FOREIGN KEY REFERENCES  
	OUTSOURCED_zamowienia(ID_zamowienia), 
ID_pracownika char(10) 
	FOREIGN KEY REFERENCES 
	OUTSOURCED_pracownicy(ID_pracownika), 
ID_dostawcy char(10)
	FOREIGN KEY REFERENCES  
	Magazyn_dostawcy_zaopatrzenie(ID_dostawcy),
Data_dostawy_planowana char(10),
Data_dostawy_rzeczywista char(10),
Czy_akceptowane bit NOT NULL DEFAULT 0
)
*/
CREATE TABLE Magazyn_zawartosc (
ID_polka char(10) UNIQUE
	FOREIGN KEY REFERENCES 
	Magazyn_polki(ID_polka),
ID_element int
	FOREIGN KEY REFERENCES 
	Magazyn_elementy(ID_element),
ID_dostawy int
	FOREIGN KEY REFERENCES
	Magazyn_zamowienia_dostawy(ID_dostawy),
Ilosc int
)


/*
--Janusz
CREATE TABLE Rodzaje_czesci (
    ID_rodzaju_czesci int PRIMARY KEY,
    Nazwa char(30),
    )

 
 
CREATE TABLE Czesci_produkcja (
    ID_element int
    FOREIGN KEY REFERENCES
    Magazyn_elementy(ID_element),
    Miejsce_docelowe char(30),
    ID_rodzaju_czesci int
    FOREIGN KEY REFERENCES  
    Rodzaje_czesci(ID_rodzaju_czesci),
    Oznaczenie char(5),
    Jakosc char(5),
    Producent char(30),
    Ilosc int, 
    Cena_jedn int
)

 

CREATE TABLE Czesci_magazyn (
    ID_element int
    FOREIGN KEY REFERENCES
    Magazyn_elementy(ID_element),
    Miejsce_docelowe char(30),
    ID_rodzaju_czesci int
    FOREIGN KEY REFERENCES  
    Rodzaje_czesci(ID_rodzaju_czesci),
    Oznaczenie char(5),
    Jakosc char(5),
    Producent char(30),
    Ilosc int, 
    Cena_jedn int
)

 

CREATE TABLE Material_tkaniny (
    ID_element int
    FOREIGN KEY REFERENCES
    Magazyn_elementy(ID_element),
    Nazwa char(50),
    Kolor char(6),
    Faktura char(20),
    Spec_przechowywanie bit,
    Dlugosc_m int, 
    Szerokosc_m int,
    Cena_za_metr int
)

 

CREATE TABLE Material_dzianiny (
    ID_element int
    FOREIGN KEY REFERENCES
    Magazyn_elementy(ID_element),
    Nazwa char(50),
    Kolor char(6),
    Faktura char(20),
    Spec_przechowywanie bit,
    Dlugosc_m int, 
    Szerokosc_m int,
    Cena_za_metr int
)

 

CREATE TABLE Material_wodoodporne (
    ID_element int
    FOREIGN KEY REFERENCES
    Magazyn_elementy(ID_element),
    Nazwa char(50),
    Kolor char(6),
    Spec_przechowywanie bit,
    Dlugosc_m int, 
    Szerokosc_m int,
    Cena_za_metr int
)

 

CREATE TABLE Material_podszewki (
    ID_element int
    FOREIGN KEY REFERENCES
    Magazyn_elementy(ID_element),
    Nazwa char(50),
    Kolor char(6),
    Faktura char(20),
    Dlugosc_m int, 
    Szerokosc_m int,
    Cena_za_metr int
)

 

CREATE TABLE Suwaki (
ID_element int
FOREIGN KEY REFERENCES
Magazyn_elementy(ID_element),
ilosc int,
cena int,
dlugosc_cm int,
kolor char(6)
)

 

CREATE TABLE Guziki (
ID_element int
FOREIGN KEY REFERENCES
Magazyn_elementy(ID_element),
ilosc int,
cena int,
srednica_mm int,
kolor char(6),
ozn_ksztaltu char(1)
)

 

CREATE TABLE Gumki (
ID_element int
FOREIGN KEY REFERENCES
Magazyn_elementy(ID_element),
ilosc_cm int,
cena_m int,
szerokosc_mm int,
kolor char(6)
)

 

CREATE TABLE Sznurki (
ID_element int
FOREIGN KEY REFERENCES
Magazyn_elementy(ID_element),
ilosc_cm int,
cena_m int,
srednica_mm int,
kolor char(6)
)

--magda
*/