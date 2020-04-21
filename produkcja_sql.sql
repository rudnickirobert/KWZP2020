CREATE TABLE Produkcja_zlecen 
(Nr_zlecenia int PRIMARY KEY NOT NULL, -- obca tabela
Data_rozpoczecia smalldatetime NULL,
Data_zakonczenia smalldatetime NULL,
ID_dokumentacja_proces int NULL, -- obca tabela
Uwagi text NULL);

CREATE TABLE Rodzaj_Etapu (
Nr_Etapu int PRIMARY KEY NOT NULL,
Nazwa char(30) NOT NULL);

CREATE TABLE Material_na_produkcji
(Nr_zlecenia int FOREIGN KEY REFERENCES Produkcja_zlecen (Nr_zlecenia) NOT NULL, -- obca tabela
ID_element char(15) NOT NULL, -- obca tabela
Liczba float NOT NULL,
Nr_miary int NOT NULL, -- obca tabela
Odpad float NULL);

CREATE TABLE Proces_Produkcyjny(
Nr_Procesu int PRIMARY KEY NOT NULL,
Nr_Zlecenia int FOREIGN KEY REFERENCES Produkcja_zlecen (Nr_zlecenia ) NOT NULL, -- obca tabela
Nr_Etapu int FOREIGN KEY REFERENCES Rodzaj_Etapu(Nr_Etapu) NOT NULL,
Data_Rozpoczecia_Procesu SMALLDATETIME NOT NULL,
Data_Zakonczenia_Procesu SMALLDATETIME NULL,
Data_Kontroli SMALLDATETIME NULL,
Uwagi_Kontroli char(30) NOT NULL);

CREATE TABLE Przydzial_zasobow (
Nr_procesu int FOREIGN KEY REFERENCES Proces_Produkcyjny (Nr_Procesu)  NOT NULL,
Nr_pracownikow int  NOT NULL, -- obca tabela
Nr_maszyny int NOT NULL ); -- obca tabela


CREATE TABLE Zapotrzebowanie_opakowan 
(Nr_zlecenia int FOREIGN KEY REFERENCES Produkcja_zlecen (Nr_zlecenia) NOT NULL, -- obca tabela
Nr_elementu int NOT NULL, -- obca tabela
Liczba int NOT NULL,
Czy_otrzymano bit NULL,
Uwagi text NULL);

CREATE TABLE Kontrola_efektywnosci (
Nr_zlecenia int FOREIGN KEY REFERENCES Produkcja_zlecen (Nr_zlecenia) NOT NULL, -- obca tabela
Data_Kontroli_Jakosci smalldatetime NOT NULL,
Dokument image NOT NULL,
Zatwierdzenie_kontroli bit NOT NULL,
Uwagi text NULL,
Liczba_poprawnych int NOT NULL,
Liczba_blednych int NOT NULL );