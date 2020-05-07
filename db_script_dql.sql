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
SELECT        TOP (100) PERCENT dbo.Regaly.Oznaczenie, dbo.Polki.ID_Polka, dbo.Polki_Rozmiary.Wysokosc, dbo.Polki_Rozmiary.Szerokosc, dbo.Polki_Rozmiary.Glebokosc,
				dbo.Polki_Rozmiary.Wysokosc + ' x ' + dbo.Polki_Rozmiary.Szerokosc + ' x ' + dbo.Polki_Rozmiary.Glebokosc + ' cm' AS Wymiar
FROM            dbo.Regaly INNER JOIN
                         dbo.Polki_regaly ON dbo.Regaly.ID_Regal = dbo.Polki_regaly.ID_Regal INNER JOIN
                         dbo.Polki ON dbo.Polki_regaly.ID_Polka = dbo.Polki.ID_Polka INNER JOIN
                         dbo.Polki_Rozmiary ON dbo.Polki.ID_Rozmiar_Polki = dbo.Polki_Rozmiary.ID_Rozmiar_Polki
ORDER BY dbo.Polki.ID_Polka
GO

---- Widok rozmiarow polek (posegregowane po wymiarach)
CREATE VIEW [dbo].[vPolki_Rozmiary]
AS
SELECT        TOP (100) PERCENT ID_Rozmiar_Polki, Wysokosc, Szerokosc, Glebokosc, Wysokosc + ' x ' + Szerokosc + ' x ' + Glebokosc + ' cm' AS Wymiar
FROM            dbo.Polki_Rozmiary
ORDER BY Wysokosc, Szerokosc, Glebokosc
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



---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------WIDOKI PRODUKCJA----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------

--realizacja procesu produkcyjnego

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


---SREDNI CZAS TRWANIA PROCESU

CREATE VIEW vRoznicaDatDni
AS
SELECT ID_Procesu_Produkcyjnego, DATEDIFF(dd, Data_Rozpoczecia, Data_Zakonczenia) as 'Roznica_dat_dni'
FROM     dbo.Proces_Produkcyjny

GO

CREATE VIEW vRoznicaDniBezWeekend
AS
SELECT dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego,  
CASE WHEN (datepart(dw,dbo.Proces_Produkcyjny.Data_Rozpoczecia) + dbo.vRoznicaDatDni.Roznica_dat_dni) > 6 THEN (dbo.vRoznicaDatDni.Roznica_dat_dni - 2) 
ELSE dbo.vRoznicaDatDni.Roznica_dat_dni
end as 'Roznica_dni_bez_weekendu'
FROM     dbo.Proces_Produkcyjny INNER JOIN
                  dbo.vRoznicaDatDni ON dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego = dbo.vRoznicaDatDni.ID_Procesu_Produkcyjnego

GO

CREATE VIEW vRoznicaGodzin
AS
SELECT  dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Proces_Produkcyjny.Data_Rozpoczecia ,dbo.Proces_Produkcyjny.Data_Zakonczenia,
CASE 
WHEN dbo.vRoznicaDniBezWeekend.Roznica_dni_bez_weekendu = 0 THEN DATEDIFF(hh, dbo.Proces_Produkcyjny.Data_Rozpoczecia, dbo.Proces_Produkcyjny.Data_Zakonczenia)
ELSE (22-DATEPART(hh, dbo.Proces_Produkcyjny.Data_Rozpoczecia))+(DATEPART(hh,  dbo.Proces_Produkcyjny.Data_Zakonczenia)-6)+((dbo.vRoznicaDniBezWeekend.Roznica_dni_bez_weekendu-1)*16)
END AS 'Roznica_godzin'
FROM     dbo.Proces_Produkcyjny INNER JOIN
                  dbo.vRoznicaDniBezWeekend ON dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego = dbo.vRoznicaDniBezWeekend.ID_Procesu_Produkcyjnego

GO

CREATE VIEW vSredniCzasWgElementu
AS
SELECT  ISNULL(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)), -1) as 'id', dbo.Elementy_Typy.Typ as 'Nazwa_produktu', avg(dbo.vRoznicaGodzin.Roznica_godzin) as'Sredni_czas'
FROM     dbo.Elementy_Typy INNER JOIN
                  dbo.Elementy ON dbo.Elementy_Typy.ID_Element_Typ = dbo.Elementy.ID_Element_Typ INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Elementy.ID_Element = dbo.Zamowienie_Element.ID_Element INNER JOIN
                  dbo.Proces_Produkcyjny INNER JOIN
                  dbo.vRoznicaGodzin ON dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego = dbo.vRoznicaGodzin.ID_Procesu_Produkcyjnego ON 
                  dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element
GROUP BY dbo.Elementy_Typy.Typ

GO
------
------Szacowany czas wykonania zamowienia
------
CREATE VIEW vSzacowanyCzasWykonania
AS
SELECT ISNULL(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)), -1) as 'id', dbo.Elementy_Typy.Typ ,   CURRENT_TIMESTAMP + ((((dbo.vSredniCzasWgElementu.Sredni_czas - (22- datepart(hh,CURRENT_TIMESTAMP)))/16)+1)*8 + vSredniCzasWgElementu.Sredni_czas)/24.00 + (((((dbo.vSredniCzasWgElementu.Sredni_czas - (22- datepart(hh,CURRENT_TIMESTAMP)))/16)+1) + DATEPART(dw,CURRENT_TIMESTAMP))/7)*2 as 'Szacowany_czas_wykonania'
FROM     dbo.Elementy_Typy INNER JOIN
                  dbo.Elementy ON dbo.Elementy_Typy.ID_Element_Typ = dbo.Elementy.ID_Element_Typ INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Elementy.ID_Element = dbo.Zamowienie_Element.ID_Element INNER JOIN
                  dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                  dbo.vSredniCzasWgElementu ON dbo.Elementy_Typy.Typ = dbo.vSredniCzasWgElementu.Nazwa_produktu

GO

-----Proces generuj¹cy najwiêcej odpadow w miesiacu
 
CREATE VIEW vProcesMaxOdpadMiesiac
AS
SELECT ISNULL(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)), -1) as 'id', datepart(mm, dbo.Proces_Produkcyjny.Data_Zakonczenia) as 'Miesiac', max(dbo.Material_Na_Produkcji.Odpad) as 'Max_odpad_w_msc'
FROM     dbo.Proces_Produkcyjny INNER JOIN
                  dbo.Material_Na_Produkcji ON dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego = dbo.Material_Na_Produkcji.ID_Procesu_Produkcyjnego
GROUP BY datepart(mm, dbo.Proces_Produkcyjny.Data_Zakonczenia)

GO

---Niezuzyte w miesiacu

CREATE VIEW vNiezuzyteWMiesiacu
AS
SELECT ISNULL(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)), -1) as 'id', dbo.Elementy.Element_Nazwa, dbo.Material_Na_Produkcji.Niezuzyty_material,  dbo.Elementy_Jednostki.Jednostka, datepart(mm, dbo.Proces_Produkcyjny.Data_Zakonczenia) as 'Miesiac'
FROM     dbo.Proces_Produkcyjny INNER JOIN
                  dbo.Material_Na_Produkcji ON dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego = dbo.Material_Na_Produkcji.ID_Procesu_Produkcyjnego INNER JOIN
                  dbo.Elementy_Proces ON dbo.Material_Na_Produkcji.ID_Elementy_Proces = dbo.Elementy_Proces.ID_Elementy_Proces INNER JOIN
                  dbo.Elementy ON dbo.Elementy_Proces.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                  dbo.Elementy_Cechy ON dbo.Elementy.ID_Element = dbo.Elementy_Cechy.ID_Element INNER JOIN
                  dbo.Elementy_Jednostki ON dbo.Elementy_Cechy.ID_Jednostka = dbo.Elementy_Jednostki.ID_jednostka
GO

--Rozpoczete Procesy

CREATE VIEW vRozpoczeteProcesy
AS
SELECT * FROM Proces_Produkcyny WHERE Data_Zakonczenia=NULL;
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
---------------------------------------------------------------------------------------------------------------------------
USE master