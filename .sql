
USE master
GO
drop database baza_zadanie
GO
CREATE DATABASE Baza_zadanie
GO
USE Baza_zadanie
GO

CREATE TABLE Klienci (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Imie varchar(50) not null,
	Nazwisko varchar(50) not null,
	Nazwa_Firmy varchar(100) unique, 
	NIP varchar(10) UNIQUE, 
	Adres varchar(100) not null,
	Telefon varchar(15) not null unique, 
	E_Mail varchar(50) not null unique
);
CREATE TABLE Produkty (
	ID int IDENTITY (1,1) PRIMARY KEY, 
	Nazwa varchar(50) not null,
);

CREATE TABLE Zamowienia (
	ID int IDENTITY (1,1) PRIMARY KEY, 
	ID_Klienta int FOREIGN KEY REFERENCES Klienci(ID),
	ID_Produktu int FOREIGN KEY REFERENCES Produkty(ID), 
	Ilosc_towaru int not null,
	Data_zlozenia datetime ,
	Data_zakonczenia datetime,
	Dokumentacja bit,
);

CREATE TABLE Pensja (
	ID int IDENTITY (1,1) PRIMARY KEY,
	Pensja real not null
);

CREATE TABLE Stanowisko (
	ID int IDENTITY (1,1) PRIMARY KEY, 
	Stanowisko varchar(50) not null, 
	Opis varchar(200) not null,
	ID_Pensji int FOREIGN KEY REFERENCES Pensja(ID)
);

CREATE TABLE Rodzaj_Umowy (
	ID int IDENTITY (1,1) PRIMARY KEY,  
	Rodzaj_umowy varchar(30) not null unique, 
	Uwagi varchar(100)
);

CREATE TABLE Etat (
	ID int IDENTITY (1,1) PRIMARY KEY, 
	Wymiar_etatu varchar(5) not null unique, 
	Uwagi varchar(100)
);

CREATE TABLE Pracownicy (
	ID int IDENTITY (1,1) PRIMARY KEY, 
	Imie varchar(50) not null,
	Nazwisko varchar(50) not null,
	Pesel varchar(11) not null unique,
	Adres varchar(100) not null,
	Telefon varchar(15) not null unique,
	Data_zatrudnienia DATE not null default GETDATE(),
	ID_Stanowiska int FOREIGN KEY REFERENCES Stanowisko(ID),
	ID_Etatu int FOREIGN KEY REFERENCES  Etat(ID),
	ID_Rodzaju_umowy int FOREIGN KEY REFERENCES  Rodzaj_umowy(ID),
	Urlop BIT not null
);

	
CREATE TABLE Jezyk (
	ID int IDENTITY (1,1) PRIMARY KEY, 
	Jezyk varchar(40) not null unique, 
	Informacje_dodatkowe varchar(200) not null
);
CREATE TABLE Znajomosc_jezykow (
	ID int IDENTITY (1,1) PRIMARY KEY,
	ID_Jezyka int FOREIGN KEY REFERENCES Jezyk(ID),
	ID_Pracownika int FOREIGN KEY REFERENCES Pracownicy(ID),
);
CREATE TABLE Faktury (
	ID_Faktury int IDENTITY(1,1) PRIMARY KEY,
	ID_Zamowienia int FOREIGN KEY REFERENCES Zamowienia(ID),
	ID_Klienta int FOREIGN KEY REFERENCES Klienci(ID),
    Cena_netto real not null,
	Cena_brutto real not null,
	Podatek_VAT real not null
);
CREATE TABLE Koszt_jednostkowy (
	ID_produktu int FOREIGN KEY REFERENCES Produkty(ID),
	Koszt_produkcji real not null,
);
 -- Koszty do bilansu 
CREATE TABLE Faktury_zewnetrzne (
	ID int IDENTITY (1,1) PRIMARY KEY,
	Nr_faktury real not null,
	Nazwa_firmy varchar(100) unique,
	cena_netto real not null,
	cena_brutto real not null,
	podatek real not null,
);
