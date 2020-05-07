USE szwalnia
---- Widok cech elementu

GO

CREATE VIEW [dbo].[vCechyElementu]
AS
SELECT Elementy.ID_Element,Cecha, Wartosc_Cechy_Liczbowa, Jednostka, Wartosc_Cechy_Slowna 
FROM Elementy INNER JOIN 
	Elementy_Cechy ON Elementy.ID_Element = Elementy_Cechy.ID_Element INNER JOIN 
	Elementy_Cechy_Slownik ON Elementy_Cechy.ID_Cecha = Elementy_Cechy_Slownik.ID_Cecha INNER JOIN 
	Elementy_Jednostki ON Elementy_Cechy.ID_Jednostka = Elementy_Jednostki.ID_jednostka
GO

---- Widok polek na regalach (z wymiarami)
CREATE VIEW [dbo].[vPolki_na_regalach]
AS
SELECT        TOP (100) PERCENT dbo.Regaly.Oznaczenie, dbo.Polki.ID_Polka, dbo.Polki_Rozmiary.Wysokosc, dbo.Polki_Rozmiary.Szerokosc, dbo.Polki_Rozmiary.Glebokosc
FROM            dbo.Regaly INNER JOIN
                         dbo.Polki_regaly ON dbo.Regaly.ID_Regal = dbo.Polki_regaly.ID_Regal INNER JOIN
                         dbo.Polki ON dbo.Polki_regaly.ID_Polka = dbo.Polki.ID_Polka INNER JOIN
                         dbo.Polki_Rozmiary ON dbo.Polki.ID_Rozmiar_Polki = dbo.Polki_Rozmiary.ID_Rozmiar_Polki
ORDER BY dbo.Polki.ID_Polka
GO

---- Widok zawartosci polek
CREATE VIEW [dbo].[vZawartosc_polki]
AS
SELECT        dbo.Regaly.ID_Regal, dbo.Regaly.Oznaczenie, dbo.Zawartosc.ID_Polka, dbo.Elementy.Element_Nazwa, dbo.Zawartosc.Ilosc_Paczek, dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym, dbo.Elementy_Jednostki.Jednostka, 
                         dbo.Zawartosc.Ilosc_Paczek * dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym AS Ile_sztuk
FROM            dbo.Polki INNER JOIN
                         dbo.Zawartosc ON dbo.Polki.ID_Polka = dbo.Zawartosc.ID_Polka INNER JOIN
                         dbo.Zamowienia_Dostawy ON dbo.Zawartosc.ID_Dostawy = dbo.Zamowienia_Dostawy.ID_Dostawy INNER JOIN
                         dbo.Elementy ON dbo.Zawartosc.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Oferta ON dbo.Elementy.ID_Element = dbo.Oferta.ID_Element INNER JOIN
                         dbo.Elementy_Jednostki ON dbo.Oferta.ID_Jednostka = dbo.Elementy_Jednostki.ID_jednostka INNER JOIN
                         dbo.Polki_regaly ON dbo.Polki.ID_Polka = dbo.Polki_regaly.ID_Polka INNER JOIN
                         dbo.Regaly ON dbo.Polki_regaly.ID_Regal = dbo.Regaly.ID_Regal
GO

CREATE VIEW vRealizacjaProcesuProdukcyjnegoDetails 
AS
SELECT dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Realizacja_Procesu.ID_Realizacji_Procesu, dbo.Rodzaj_Etapu.Nazwa as 'Nazwa etapu', dbo.Realizacja_Procesu.Data_Rozpoczecia_Procesu, 
                  dbo.Realizacja_Procesu.Data_Zakonczenia_Procesu
FROM     dbo.Realizacja_Procesu INNER JOIN
                  dbo.Rodzaj_Etapu ON dbo.Realizacja_Procesu.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu INNER JOIN
                  dbo.Proces_Produkcyjny ON dbo.Realizacja_Procesu.ID_Procesu_Produkcyjnego = dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego
				  
				  
GO

-- widok Procesu Produkcyjnego dla ID Zamowienia
CREATE VIEW vZamowienieProcesyProdukcyjne 
AS
SELECT        dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Zamowienie_Element.ID_Zamowienia, dbo.Proces_Produkcyjny.ID_Zamowienie_Element, dbo.Elementy_Typy.Typ, 
                         dbo.Proces_Produkcyjny.Proponowana_data_dostawy_materialu, dbo.Proces_Produkcyjny.Data_Rozpoczecia, dbo.Proces_Produkcyjny.Data_Zakonczenia, dbo.Proces_Produkcyjny.Uwagi
FROM            dbo.Proces_Produkcyjny INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Proces_Produkcyjny.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                         dbo.Elementy ON dbo.Zamowienie_Element.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Elementy_Typy ON dbo.Elementy.ID_Element_Typ = dbo.Elementy_Typy.ID_Element_Typ
GO

-- widok Procesu Produkcyjnego dla ID Zamowienie Element

CREATE VIEW vIdZamowienieElementProcesProdukcyjny 
AS
SELECT        dbo.Zamowienie_Element.ID_Zamowienie_Element, dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Proces_Produkcyjny.ID_Zamowienie_Element AS Expr1, 
                         dbo.Proces_Produkcyjny.Proponowana_data_dostawy_materialu, dbo.Proces_Produkcyjny.Data_Rozpoczecia, dbo.Proces_Produkcyjny.Data_Zakonczenia, dbo.Proces_Produkcyjny.Uwagi
FROM            dbo.Proces_Produkcyjny INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Proces_Produkcyjny.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element
GO

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
-----------------------------------------WIDOKI PRZYGOTOWANIE PRODUKCJI----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------

CREATE VIEW vMaszyny_rodzaj_liczba AS
SELECT TOP (100) PERCENT dbo.Maszyny_Proces.ID_Proces_Technologiczny, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, dbo.Srodki_Trwale.Producent, dbo.Maszyny_Proces.Liczba_Maszyn
FROM     dbo.Rodzaj_Maszyny INNER JOIN
                  dbo.Maszyny_Proces ON dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny = dbo.Maszyny_Proces.ID_Rodzaj_Maszyny INNER JOIN
                  dbo.Maszyny ON dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny = dbo.Maszyny.ID_Rodzaj_Maszyny INNER JOIN
                  dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale INNER JOIN
                  dbo.Proces_Technologiczny ON dbo.Maszyny_Proces.ID_Proces_Technologiczny = dbo.Proces_Technologiczny.ID_Proces_Technologiczny INNER JOIN
                  dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Etapy_W_Procesie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Rodzaj_Etapu ON dbo.Etapy_W_Procesie.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GROUP BY dbo.Maszyny_Proces.ID_Proces_Technologiczny, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, dbo.Srodki_Trwale.Producent, dbo.Maszyny_Proces.Liczba_Maszyn
				  GO

CREATE VIEW vMaszyny_serwis  AS
SELECT dbo.Maszyny.ID_Maszyny, dbo.Maszyny.Resurs_Rbh, dbo.Maszyny.Serwis_Co_Ile, dbo.Srodki_Trwale.Producent, dbo.Srodki_Trwale.Nazwa, dbo.Srodki_Trwale.Numer_seryjny
FROM     dbo.Maszyny INNER JOIN
                  dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale
				  GO

CREATE VIEW vObsluga AS
SELECT dbo.Obsluga_Techniczna.ID_Obsluga_Techniczna, dbo.Srodki_Trwale.Nazwa, dbo.Srodki_Trwale.Producent, dbo.Srodki_Trwale.Numer_seryjny, dbo.Rodzaj_Obslugi.Nazwa AS Expr1, dbo.Obsluga_Techniczna.Data_Wykonania, 
                  dbo.Pracownicy.Nazwisko, dbo.Elementy.Element_Nazwa
FROM     dbo.Rodzaj_Obslugi INNER JOIN
                  dbo.Obsluga_Techniczna ON dbo.Rodzaj_Obslugi.ID_Rodzaj_Obslugi = dbo.Obsluga_Techniczna.ID_Rodzaj_Obslugi INNER JOIN
                  dbo.Maszyny ON dbo.Obsluga_Techniczna.ID_Maszyny = dbo.Maszyny.ID_Maszyny INNER JOIN
                  dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale INNER JOIN
                  dbo.Pracownicy ON dbo.Obsluga_Techniczna.ID_Pracownika = dbo.Pracownicy.ID_Pracownika CROSS JOIN
                  dbo.Elementy
				  GO

CREATE VIEW vSrednia_ilosc_maszyn AS
SELECT dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, SUM(dbo.Maszyny_Proces.Liczba_Maszyn) / COUNT(dbo.Proces_Zamowienie.ID_Proces_Zamowienie) AS srednia_ilosc_maszyn
FROM     dbo.Proces_Zamowienie INNER JOIN
                  dbo.Maszyny_Proces ON dbo.Maszyny_Proces.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Rodzaj_Maszyny ON dbo.Maszyny_Proces.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
GROUP BY dbo.Rodzaj_Maszyny.Rodzaj_Maszyny
GO

CREATE VIEW vSuma_czasu_procesu AS
SELECT ID_Proces_Technologiczny, SUM(Czas) AS suma_czasu
FROM     dbo.Etapy_W_Procesie
GROUP BY ID_Proces_Technologiczny
GO
---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
-----------------------------------------KONIEC PRZYGOTOWANIE PRODUKCJI----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
-------------------------------------------ZARZADZANIE Widoki--------------------------------------------------------------------------------
CREATE VIEW vKlienciZamowienie AS
SELECT dbo.Klienci.ID_Klienta, dbo.Klienci.Nazwa_Firmy, dbo.Zamowienia.ID_Zamowienia, dbo.Elementy.Element_Nazwa, dbo.Zamowienie_Element.Ilosc, dbo.Zamowienia.Data_Zlozenia, dbo.Zamowienia.Data_Zakonczenia
FROM     dbo.Zamowienia INNER JOIN
                  dbo.Klienci ON dbo.Zamowienia.ID_Klienta = dbo.Klienci.ID_Klienta INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Zamowienia.ID_Zamowienia = dbo.Zamowienie_Element.ID_Zamowienia INNER JOIN
                  dbo.Elementy ON dbo.Zamowienie_Element.ID_Element = dbo.Elementy.ID_Element
GO

-- Wynagrodzenie czastkowe



CREATE VIEW vWynagrodzenia
AS
SELECT dbo.Pracownicy.Imie, dbo.Pracownicy.Nazwisko, dbo.Pracownicy.Pesel, dbo.Stanowisko.Stanowisko, dbo.Pensja.Pensja, dbo.Etat.Wymiar_Etatu, AVG(DISTINCT dbo.Pensja.Pensja * dbo.Etat.Wymiar_Etatu) AS Wynagrodzenie
FROM     dbo.Pracownicy_Zatrudnienie INNER JOIN
                  dbo.Pracownicy ON dbo.Pracownicy_Zatrudnienie.ID_Pracownika = dbo.Pracownicy.ID_Pracownika INNER JOIN
                  dbo.Stanowisko ON dbo.Pracownicy_Zatrudnienie.ID_Stanowiska = dbo.Stanowisko.ID_Stanowiska INNER JOIN
                  dbo.Pensja ON dbo.Stanowisko.ID_Pensji = dbo.Pensja.ID_Pensja INNER JOIN
                  dbo.Etat ON dbo.Pracownicy_Zatrudnienie.ID_Etatu = dbo.Etat.ID_Etat
GROUP BY dbo.Pracownicy.Imie, dbo.Pracownicy.Nazwisko, dbo.Pracownicy.Pesel, dbo.Stanowisko.Stanowisko, dbo.Pensja.Pensja, dbo.Etat.Wymiar_Etatu
GO


CREATE VIEW vKosztProcesu
AS
SELECT TOP (100) PERCENT dbo.Zamowienia.ID_Zamowienia, dbo.Klienci.Imie, dbo.Klienci.Nazwisko, dbo.Klienci.Nazwa_Firmy, dbo.Klienci.NIP, dbo.Rodzaj_Maszyny.Koszt_Rbh, dbo.vSuma_czasu_procesu.suma_czasu, 
                  AVG(DISTINCT dbo.Rodzaj_Maszyny.Koszt_Rbh * dbo.vSuma_czasu_procesu.suma_czasu) AS Calkowity_koszt_procesu
FROM     dbo.Klienci INNER JOIN
                  dbo.Zamowienia ON dbo.Klienci.ID_Klienta = dbo.Zamowienia.ID_Klienta CROSS JOIN
                  dbo.Rodzaj_Maszyny CROSS JOIN
                  dbo.vSuma_czasu_procesu
GROUP BY dbo.Zamowienia.ID_Zamowienia, dbo.Klienci.Imie, dbo.Klienci.Nazwisko, dbo.Klienci.Nazwa_Firmy, dbo.Klienci.NIP, dbo.vSuma_czasu_procesu.suma_czasu, dbo.Rodzaj_Maszyny.Koszt_Rbh
GO

--Calkowity koszt zamowienia

CREATE VIEW vCalkowityKosztZamowienia
AS
SELECT ID_Zamowienia, SUM(Calkowity_koszt_procesu) AS Calkowity_koszt_produkcji
FROM     dbo.vKosztProcesu
GROUP BY ID_Zamowienia
GO

-- Faktury
CREATE VIEW vFaktury
AS
SELECT dbo.vCalkowityKosztZamowienia.ID_Zamowienia, dbo.Klienci.Imie, dbo.Klienci.Nazwisko, dbo.vCalkowityKosztZamowienia.Calkowity_koszt_produkcji, dbo.vCalkowityKosztZamowienia.Calkowity_koszt_produkcji * 1.20 AS Cena_netto, 
                  dbo.vCalkowityKosztZamowienia.Calkowity_koszt_produkcji * 1.20 * 1.23 AS Cena_brutto
FROM     dbo.Zamowienia INNER JOIN
                  dbo.vCalkowityKosztZamowienia ON dbo.Zamowienia.ID_Zamowienia = dbo.vCalkowityKosztZamowienia.ID_Zamowienia INNER JOIN
                  dbo.Klienci ON dbo.Zamowienia.ID_Klienta = dbo.Klienci.ID_Klienta
GO

-- Przychody

CREATE VIEW vPrzychody
AS
SELECT  SUM(Cena_brutto) AS Przychody
FROM     dbo.vFaktury
GO

-- Rozchody

CREATE VIEW vRozchody
AS
SELECT SUM(dbo.Faktury_Zewnetrzne.Brutto) AS Wydatki, SUM(dbo.vWynagrodzenia.Wynagrodzenie) AS Wyplaty
FROM     dbo.Faktury_Zewnetrzne CROSS JOIN
                  dbo.vWynagrodzenia
GO

-- Bilans

CREATE VIEW vBilans
AS
SELECT dbo.vPrzychody.Przychody, dbo.vRozchody.Wydatki, dbo.vRozchody.Wyplaty, SUM(dbo.vPrzychody.Przychody - dbo.vRozchody.Wydatki - dbo.vRozchody.Wyplaty) AS Bilans
FROM     dbo.vPrzychody CROSS JOIN
                  dbo.vRozchody
GROUP BY dbo.vPrzychody.Przychody, dbo.vRozchody.Wydatki, dbo.vRozchody.Wyplaty
GO

