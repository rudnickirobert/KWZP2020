USE szwalnia
GO

---- Widok cech elementu
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
SELECT        TOP (100) PERCENT dbo.Regaly.Oznaczenie, dbo.Polki.ID_Polka, CAST(dbo.Polki_Rozmiary.Wysokosc AS NVARCHAR) 
                         + ' x ' + CAST(dbo.Polki_Rozmiary.Szerokosc AS NVARCHAR) + ' x ' + CAST(dbo.Polki_Rozmiary.Glebokosc AS NVARCHAR) + ' cm' AS Wymiar
FROM            dbo.Regaly INNER JOIN
                         dbo.Polki_regaly ON dbo.Regaly.ID_regal = dbo.Polki_regaly.ID_regal INNER JOIN
                         dbo.Polki ON dbo.Polki_regaly.ID_Polka = dbo.Polki.ID_Polka INNER JOIN
                         dbo.Polki_Rozmiary ON dbo.Polki.ID_Rozmiar_Polki = dbo.Polki_Rozmiary.ID_Rozmiar_Polki
ORDER BY dbo.Polki.ID_Polka
GO

---- Widok rozmiarow polek (posegregowane po wymiarach)
CREATE VIEW [dbo].[vPolki_Rozmiary]
AS
SELECT        TOP (100) PERCENT ID_Rozmiar_Polki, Wysokosc, Szerokosc, Glebokosc, CAST(dbo.Polki_Rozmiary.Wysokosc AS NVARCHAR) 
                         + ' x ' + CAST(dbo.Polki_Rozmiary.Szerokosc AS NVARCHAR) + ' x ' + CAST(dbo.Polki_Rozmiary.Glebokosc AS NVARCHAR) + ' cm' AS Wymiar
FROM            dbo.Polki_Rozmiary
ORDER BY Wysokosc, Szerokosc, Glebokosc
GO

-- Widok oznaczeñ rega³ów alfabetycznie
CREATE VIEW [dbo].[vRegaly_alfabetycznie]
AS
SELECT        TOP (100) PERCENT ID_regal, Oznaczenie
FROM            dbo.Regaly
ORDER BY Oznaczenie
GO
-- Widok podsumowujacy materialy z magazynu ktore zostaly przypisane do zamowien
CREATE VIEW [dbo].[vMaterialyZMagazynu]
AS
SELECT        dbo.Zamowienia_Dostawy_Wlasne.ID_Zamowienia, dbo.Dostawy_Wlasne_Zawartosc.ID_Element, SUM(dbo.Dostawy_Wlasne_Zawartosc.Ilosc) * - 1 AS Ilosc
FROM            dbo.Dostawy_Wlasne_Zawartosc INNER JOIN
                         dbo.Zamowienia_Dostawy_Wlasne ON dbo.Dostawy_Wlasne_Zawartosc.ID_Zamowienia_dostawy_wlasne = dbo.Zamowienia_Dostawy_Wlasne.ID_Zamowienia_dostawy_wlasne
GROUP BY dbo.Zamowienia_Dostawy_Wlasne.ID_Zamowienia, dbo.Dostawy_Wlasne_Zawartosc.ID_Element
GO
--Widok podsumowujacy materialy potrzebne do wykonania zamowienia
CREATE VIEW [dbo].[vMaterialyDoZamowienia]
AS
SELECT        dbo.Zamowienia.ID_Zamowienia, dbo.Elementy_Proces.ID_Element, SUM(dbo.Elementy_Proces.Liczba) AS Ilosc
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Elementy_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Elementy_Proces.ID_Proces_Technologiczny INNER JOIN
                         dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Zamowienia INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Zamowienia.ID_Zamowienia = dbo.Zamowienie_Element.ID_Zamowienia ON dbo.Proces_Zamowienie.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element
WHERE        (dbo.Proces_Zamowienie.Kompletny_Proces = 1)
GROUP BY dbo.Zamowienia.ID_Zamowienia, dbo.Elementy_Proces.ID_Element
GO
--Widok podsumowujacy juz zamowione materialy
CREATE VIEW [dbo].[vMaterialyZamowione]
AS
SELECT        dbo.Zamowienia_Dostawy.ID_Zamowienia, dbo.Dostawy_Zawartosc.ID_Element, dbo.Dostawy_Zawartosc.Ilosc_Dostarczona * dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym * - 1 AS Ilosc
FROM            dbo.Zamowienia_Dostawy INNER JOIN
                         dbo.Dostawy_Zawartosc ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostawy_Zawartosc.ID_Dostawy INNER JOIN
                         dbo.Oferta ON dbo.Dostawy_Zawartosc.ID_oferta = dbo.Oferta.ID_Oferta
WHERE        (dbo.Zamowienia_Dostawy.ID_statusu IS NOT NULL)
GO
--Widok podsumowujacy materialy brakujace ktore trzeba domowic
CREATE VIEW [dbo].[vMaterialyDoZamowieniaBrak]
AS
SELECT        Wszystko.ID_Zamowienia, dbo.Elementy.ID_Element, dbo.Elementy.Element_Nazwa, SUM(Wszystko.Ilosc) AS Ilosc
FROM            (SELECT        ID_Zamowienia, ID_Element, Ilosc
                          FROM            dbo.vMaterialyDoZamowienia
                          UNION ALL
                          SELECT        ID_Zamowienia, ID_Element, Ilosc
                          FROM            dbo.vMaterialyZamowione
                          UNION ALL
                          SELECT        ID_Zamowienia, ID_Element, Ilosc
                          FROM            dbo.vMaterialyZMagazynu) AS Wszystko INNER JOIN
                         dbo.Elementy ON Wszystko.ID_Element = dbo.Elementy.ID_Element
GROUP BY Wszystko.ID_Zamowienia, dbo.Elementy.Element_Nazwa, dbo.Elementy.ID_Element
HAVING        (SUM(Wszystko.Ilosc) > 0)
GO

--widok ofert
CREATE VIEW [dbo].[vOferta]
AS
SELECT        dbo.Oferta.ID_Element, dbo.Oferta.ID_Oferta, dbo.Dostawcy_Zaopatrzenie.ID_Dostawcy, dbo.Oferta.Element_Oznaczenie, dbo.Oferta.Cena_Jedn, dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym, 
                         dbo.Oferta.Deklarowany_czas_dostawy, dbo.Dostawcy_Zaopatrzenie.Nazwa, dbo.Oferta.Ilosc_Minimalna, dbo.Oferta.Ilosc_Maksymalna, dbo.Dostawcy_Zaopatrzenie.Telefon_1
FROM            dbo.Oferta INNER JOIN
                         dbo.Dostawcy_Zaopatrzenie ON dbo.Oferta.ID_Dostawcy = dbo.Dostawcy_Zaopatrzenie.ID_Dostawcy
GROUP BY dbo.Oferta.ID_Element, dbo.Oferta.ID_Oferta, dbo.Oferta.Element_Oznaczenie, dbo.Oferta.Cena_Jedn, dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym, dbo.Dostawcy_Zaopatrzenie.ID_Dostawcy, 
                         dbo.Dostawcy_Zaopatrzenie.Nazwa, dbo.Dostawcy_Zaopatrzenie.Telefon_1, dbo.Oferta.Ilosc_Minimalna, dbo.Oferta.Ilosc_Maksymalna, dbo.Oferta.Deklarowany_czas_dostawy
GO
---- Widok stanu magazynowego wg pó³ek
CREATE VIEW [dbo].[vStan_magazynowy_polki]
AS
SELECT         dbo.Zawartosc.ID_Zawartosc, dbo.Zawartosc.ID_Polka, dbo.Regaly.Oznaczenie, dbo.Elementy.Element_Nazwa, dbo.Zawartosc.ID_Element, dbo.Zawartosc.ID_Dostawy, CASE WHEN dbo.Elementy.Okres_Przydatnosci_Miesiace = 0 THEN DATEADD(YEAR, 
                         50, dbo.Zamowienia_Dostawy.Data_Dostawy_Rzeczywista) ELSE DATEADD(MONTH, dbo.Elementy.Okres_Przydatnosci_Miesiace, dbo.Zamowienia_Dostawy.Data_Dostawy_Rzeczywista) END AS Przydatnosc, dbo.Elementy.Okres_Przydatnosci_Miesiace,
                         dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym * dbo.Zawartosc.Ilosc_Paczek AS Ile, dbo.Elementy_Jednostki.Jednostka
FROM            dbo.Polki_regaly INNER JOIN
                         dbo.Regaly ON dbo.Polki_regaly.ID_regal = dbo.Regaly.ID_regal INNER JOIN
                         dbo.Polki ON dbo.Polki_regaly.ID_Polka = dbo.Polki.ID_Polka INNER JOIN
                         dbo.Zawartosc INNER JOIN
                         dbo.Zamowienia_Dostawy ON dbo.Zawartosc.ID_Dostawy = dbo.Zamowienia_Dostawy.ID_Dostawy INNER JOIN
                         dbo.Elementy ON dbo.Zawartosc.ID_Element = dbo.Elementy.ID_Element ON dbo.Polki.ID_Polka = dbo.Zawartosc.ID_Polka INNER JOIN
                         dbo.Oferta ON dbo.Elementy.ID_Element = dbo.Oferta.ID_Element INNER JOIN
                         dbo.Dostawy_Zawartosc ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostawy_Zawartosc.ID_Dostawy AND dbo.Elementy.ID_Element = dbo.Dostawy_Zawartosc.ID_Element AND 
                         dbo.Oferta.ID_Oferta = dbo.Dostawy_Zawartosc.ID_oferta INNER JOIN
                         dbo.Elementy_Jednostki ON dbo.Oferta.ID_Jednostka = dbo.Elementy_Jednostki.ID_jednostka
GO

--widok zawartosci magazynu do przydzia³u do zamowien
CREATE VIEW [dbo].[vZawartoscMagazynuDoPrzydzialu]
AS
SELECT        dbo.Polki.ID_Polka, dbo.Zawartosc.ID_Element, dbo.Zawartosc.ID_Dostawy, dbo.Oferta.Element_Oznaczenie, dbo.Zawartosc.Ilosc_Paczek * dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym AS Ilosc, 
                         CAST(dbo.Oferta.Cena_Jedn AS DECIMAL(18, 2)) AS Cena
FROM            dbo.Zawartosc INNER JOIN
                         dbo.Zamowienia_Dostawy ON dbo.Zawartosc.ID_Dostawy = dbo.Zamowienia_Dostawy.ID_Dostawy INNER JOIN
                         dbo.Dostawy_Zawartosc ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostawy_Zawartosc.ID_Dostawy INNER JOIN
                         dbo.Oferta ON dbo.Dostawy_Zawartosc.ID_oferta = dbo.Oferta.ID_Oferta INNER JOIN
                         dbo.Polki ON dbo.Zawartosc.ID_Polka = dbo.Polki.ID_Polka
GO

--widok pokazuj¹cy od kogo jest która dostawa i do którego zamówienia
CREATE VIEW [dbo].[vDostawcyDostawDoZamowien]
AS
SELECT        dbo.Zamowienia_Dostawy.ID_Zamowienia, dbo.Zamowienia_Dostawy.ID_Dostawy, dbo.Oferta.ID_Dostawcy, dbo.Zamowienia_Dostawy.ID_statusu
FROM            dbo.Zamowienia_Dostawy INNER JOIN
                         dbo.Dostawy_Zawartosc ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostawy_Zawartosc.ID_Dostawy INNER JOIN
                         dbo.Oferta ON dbo.Dostawy_Zawartosc.ID_oferta = dbo.Oferta.ID_Oferta
WHERE        (dbo.Zamowienia_Dostawy.ID_statusu <> 3)
GO
--lista dostaw do przyjecia
CREATE VIEW [dbo].[vDostawyDoOdbioru]
AS
SELECT        dbo.Zamowienia_Dostawy.ID_Dostawy, dbo.Dostawy_Zawartosc.ID_Element, dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym AS Ilosc_w_paczce, 
                         dbo.Dostawy_Zawartosc.Ilosc_Dostarczona * dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym AS Ilosc
FROM            dbo.Zamowienia_Dostawy INNER JOIN
                         dbo.Dostawy_Zawartosc ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostawy_Zawartosc.ID_Dostawy INNER JOIN
                         dbo.Oferta ON dbo.Dostawy_Zawartosc.ID_oferta = dbo.Oferta.ID_Oferta LEFT OUTER JOIN
                         dbo.Dostarczenia_Wewn ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostarczenia_Wewn.ID_Dostawy
WHERE        (dbo.Dostarczenia_Wewn.ID_Dostawy IS NULL)
GO
--lista wolnych polek
CREATE VIEW [dbo].[vWolnePolki]
AS
SELECT        dbo.Polki.ID_Polka
FROM            dbo.Zawartosc RIGHT OUTER JOIN
                         dbo.Polki ON dbo.Zawartosc.ID_Polka = dbo.Polki.ID_Polka
WHERE        (dbo.Zawartosc.ID_Polka IS NULL)
GO
--lista pracownikow magazynu 
CREATE VIEW [dbo].[vPracownicyMagazynu]
AS
SELECT        dbo.Pracownicy.ID_Pracownika, dbo.Pracownicy.Imie + ' ' + dbo.Pracownicy.Nazwisko AS Dane_osobowe, dbo.Pracownicy_Zatrudnienie.ID_Dzialu
FROM            dbo.Pracownicy INNER JOIN
                         dbo.Pracownicy_Zatrudnienie ON dbo.Pracownicy.ID_Pracownika = dbo.Pracownicy_Zatrudnienie.ID_Pracownika
WHERE        (dbo.Pracownicy_Zatrudnienie.ID_Dzialu = 2)
GO
---- Widok stanu magazynowego wg elementów
CREATE VIEW [dbo].[vStan_magazynowy_elementy]
AS
SELECT        TOP (100) PERCENT dbo.Elementy.Element_Nazwa, dbo.Elementy.ID_Element, SUM(dbo.Oferta.Ilosc_W_Opakowaniu_Pojedynczym * dbo.Zawartosc.Ilosc_Paczek) AS Ile, dbo.Elementy_Jednostki.Jednostka
FROM            dbo.Zawartosc INNER JOIN
                         dbo.Zamowienia_Dostawy ON dbo.Zawartosc.ID_Dostawy = dbo.Zamowienia_Dostawy.ID_Dostawy INNER JOIN
                         dbo.Elementy ON dbo.Zawartosc.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Oferta ON dbo.Elementy.ID_Element = dbo.Oferta.ID_Element INNER JOIN
                         dbo.Dostawy_Zawartosc ON dbo.Zamowienia_Dostawy.ID_Dostawy = dbo.Dostawy_Zawartosc.ID_Dostawy AND dbo.Elementy.ID_Element = dbo.Dostawy_Zawartosc.ID_Element AND 
                         dbo.Oferta.ID_Oferta = dbo.Dostawy_Zawartosc.ID_oferta INNER JOIN
                         dbo.Elementy_Jednostki ON dbo.Oferta.ID_Jednostka = dbo.Elementy_Jednostki.ID_jednostka
GROUP BY dbo.Elementy_Jednostki.Jednostka, dbo.Elementy.Element_Nazwa, dbo.Elementy.ID_Element
ORDER BY dbo.Elementy.ID_Element
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

CREATE VIEW vSredniCzasWedlugElementu
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


----Srednia liczba sztuk

CREATE VIEW vSredniaLiczbaSztuk
AS
SELECT  ISNULL(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)), -1) as 'id', dbo.Elementy_Typy.Typ, avg(dbo.Zamowienie_Element.Ilosc) as 'Sredia_liczba_sztuk'
FROM     dbo.Elementy_Typy INNER JOIN
                  dbo.Elementy ON dbo.Elementy_Typy.ID_Element_Typ = dbo.Elementy.ID_Element_Typ INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Elementy.ID_Element = dbo.Zamowienie_Element.ID_Element
Group BY dbo.Elementy_Typy.Typ
GO

------------Szacowany czas wykonania zamowienia wersja 2

CREATE VIEW vSredniCzasSztuki
AS
SELECT ISNULL(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)), -1) as 'id', dbo.vSredniCzasWedlugElementu.Nazwa_produktu, dbo.vSredniCzasWedlugElementu.Sredni_czas, dbo.vSredniaLiczbaSztuk.Sredia_liczba_sztuk, (1.0*dbo.vSredniCzasWedlugElementu.Sredni_czas/dbo.vSredniaLiczbaSztuk.Sredia_liczba_sztuk) as 'Sredni_czas_szt'
FROM     dbo.vSredniaLiczbaSztuk INNER JOIN
                  dbo.vSredniCzasWedlugElementu ON dbo.vSredniaLiczbaSztuk.Typ = dbo.vSredniCzasWedlugElementu.Nazwa_produktu
GO

-- Nieuzyty materia³ odpad
CREATE VIEW vNieuzytyMaterialOdpad AS
SELECT        dbo.Zamowienie_Element.ID_Zamowienia, dbo.Proces_Produkcyjny.ID_Zamowienie_Element, dbo.Material_Na_Produkcji.ID_Material_Na_Produkcji AS [ID Materia³u Na Produkcji], 
                         dbo.Material_Na_Produkcji.ID_Procesu_Produkcyjnego AS [ID Procesu Produkcyjnego], dbo.Material_Na_Produkcji.ID_Elementy_Proces AS [ID Elementy Procesu], dbo.Elementy_Proces.ID_Element, 
                         dbo.Elementy.Element_Nazwa AS [Nazwa Elementu], dbo.Elementy_Jednostki.Jednostka, dbo.Material_Na_Produkcji.Odpad, dbo.Material_Na_Produkcji.Niezuzyty_material AS [Nieu¿yty Materia³], 
                         dbo.Material_Na_Produkcji.Magazyn_odebral_material AS [Magazyn Odebra³ Materia³], dbo.Proces_Produkcyjny.Data_Zakonczenia AS [Data Zakoñczenia]
FROM            dbo.Elementy_Jednostki INNER JOIN
                         dbo.Elementy_Proces ON dbo.Elementy_Jednostki.ID_jednostka = dbo.Elementy_Proces.ID_jednostka INNER JOIN
                         dbo.Material_Na_Produkcji ON dbo.Elementy_Proces.ID_Elementy_Proces = dbo.Material_Na_Produkcji.ID_Elementy_Proces INNER JOIN
                         dbo.Elementy ON dbo.Elementy_Proces.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Proces_Produkcyjny ON dbo.Material_Na_Produkcji.ID_Procesu_Produkcyjnego = dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Proces_Produkcyjny.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element
GO

-- vPrzydzialZasobow

CREATE VIEW vPrzydzialZasobow
AS
SELECT dbo.Realizacja_Procesu.ID_Procesu_Produkcyjnego AS 'ID procesu produkcyjnego', dbo.Przydzial_Zasobow.ID_Realizacji_Procesu AS 'ID realizacji procesu', dbo.Rodzaj_Etapu.Nazwa AS 'Nazwa etapu',
      dbo.Przydzial_Zasobow.ID_Pracownika AS 'ID pracownika', dbo.Pracownicy.Imie AS 'Imiê', dbo.Pracownicy.Nazwisko, 
      dbo.Przydzial_Zasobow.ID_Maszyny AS 'ID maszyna', dbo.Srodki_Trwale.Nazwa AS 'Nazwa maszyny', 
      dbo.Przydzial_Zasobow.Data_Rozpoczecia AS 'Data rozpoczêcia',
      dbo.Przydzial_Zasobow.Data_Zakonczenia AS 'Data zakoñczenia'
FROM  dbo.Przydzial_Zasobow INNER JOIN
      dbo.Realizacja_Procesu ON dbo.Przydzial_Zasobow.ID_Realizacji_Procesu = dbo.Realizacja_Procesu.ID_Realizacji_Procesu INNER JOIN
      dbo.Pracownicy ON dbo.Przydzial_Zasobow.ID_Pracownika = dbo.Pracownicy.ID_Pracownika INNER JOIN
      dbo.Maszyny ON dbo.Przydzial_Zasobow.ID_Maszyny = dbo.Maszyny.ID_Maszyny INNER JOIN
      dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale INNER JOIN
      dbo.Rodzaj_Etapu ON dbo.Realizacja_Procesu.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GO

-- Przydzial Zasobow w etapach
CREATE VIEW vPrzydzialZasobowEtap
AS
SELECT dbo.Realizacja_Procesu.ID_Procesu_Produkcyjnego AS 'ID procesu produkcyjnego', dbo.Przydzial_Zasobow.ID_Realizacji_Procesu AS 'ID realizacji procesu', dbo.Rodzaj_Etapu.Nazwa AS 'Nazwa etapu',
(CAST(dbo.Przydzial_Zasobow.ID_Pracownika AS varchar(10)) + ('  ') + dbo.Pracownicy.Imie + ('  ')  +  dbo.Pracownicy.Nazwisko) AS 'ID Pracownika, Imiê, Nazwisko',
(CAST (dbo.Przydzial_Zasobow.ID_Maszyny AS varchar(10)) + ('  ') + dbo.Srodki_Trwale.Nazwa) AS 'ID Maszyny, Nazwa',
      dbo.Przydzial_Zasobow.Data_Rozpoczecia AS 'Data rozpoczêcia',
      dbo.Przydzial_Zasobow.Data_Zakonczenia AS 'Data zakoñczenia'
FROM  dbo.Przydzial_Zasobow INNER JOIN
      dbo.Realizacja_Procesu ON dbo.Przydzial_Zasobow.ID_Realizacji_Procesu = dbo.Realizacja_Procesu.ID_Realizacji_Procesu INNER JOIN
      dbo.Pracownicy ON dbo.Przydzial_Zasobow.ID_Pracownika = dbo.Pracownicy.ID_Pracownika INNER JOIN
      dbo.Maszyny ON dbo.Przydzial_Zasobow.ID_Maszyny = dbo.Maszyny.ID_Maszyny INNER JOIN
      dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale INNER JOIN
      dbo.Rodzaj_Etapu ON dbo.Realizacja_Procesu.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GO

-- KontrolaProcesu
CREATE VIEW vKontrolaProcesu
AS
SELECT     dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego AS 'ID procesu produkcyjnego' ,dbo.Zamowienie_Element.ID_Zamowienia AS 'ID zamówienia',dbo.Elementy.Element_Nazwa AS 'Nazwa elementu', dbo.Zamowienie_Element.Ilosc AS 'Iloœæ', dbo.Kontrola_Efektywnosci.Liczba_Poprawnych AS 'Liczba poprawnych',
CASE WHEN (dbo.Zamowienie_Element.Ilosc - dbo.Kontrola_Efektywnosci.Liczba_Poprawnych) < 0
THEN  'Nadwy¿ka produktów'
WHEN (dbo.Zamowienie_Element.Ilosc - dbo.Kontrola_Efektywnosci.Liczba_Poprawnych) = 0
THEN  'Poprawna iloœæ produktów'
WHEN (dbo.Zamowienie_Element.Ilosc - dbo.Kontrola_Efektywnosci.Liczba_Poprawnych) > 0
THEN  'Niedobór produktów do zamówienia'
END AS 'Status produktów',
ABS((dbo.Zamowienie_Element.Ilosc - dbo.Kontrola_Efektywnosci.Liczba_Poprawnych)) AS 'Bilans produktów', dbo.Kontrola_Efektywnosci.Data_Kontroli AS 'Data kontroli'
FROM            dbo.Proces_Produkcyjny INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Proces_Produkcyjny.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                         dbo.Elementy ON dbo.Zamowienie_Element.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Kontrola_Efektywnosci ON dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego = dbo.Kontrola_Efektywnosci.ID_Procesu_Produkcyjnego
GO


-- wszyscy pracownicy produkcji

CREATE VIEW vWszyscyPracownicyProdukcji
AS
SELECT        dbo.Pracownicy.ID_Pracownika, (CAST(dbo.Pracownicy.ID_Pracownika AS varchar(10)) + ('    ') + dbo.Pracownicy.Imie + (' ')  +  dbo.Pracownicy.Nazwisko + (' - ') + dbo.Stanowisko.Stanowisko) AS 'Pracownik', dbo.Dzialy.ID_Dzialu, dbo.Dzialy.Nazwa_dzialu, dbo.Pracownicy_Zatrudnienie.Data_Zatrudnienia, dbo.Pracownicy_Zatrudnienie.Koniec_umowy
FROM            dbo.Pracownicy INNER JOIN
                         dbo.Pracownicy_Zatrudnienie ON dbo.Pracownicy.ID_Pracownika = dbo.Pracownicy_Zatrudnienie.ID_Pracownika INNER JOIN
                         dbo.Dzialy ON dbo.Pracownicy_Zatrudnienie.ID_Dzialu = dbo.Dzialy.ID_Dzialu INNER JOIN
                         dbo.Stanowisko ON dbo.Pracownicy_Zatrudnienie.ID_Stanowiska = dbo.Stanowisko.ID_Stanowiska
WHERE 
	  dbo.Dzialy.ID_Dzialu = 3
	  AND
	  (dbo.Pracownicy_Zatrudnienie.Koniec_umowy > GETDATE() AND dbo.Pracownicy_Zatrudnienie.Data_Zatrudnienia < GETDATE())
GO

-- wolni pracownicy produkcji

CREATE VIEW vWolniPracownicyProdukcji
AS 
SELECT dbo.Pracownicy.ID_Pracownika, (CAST(dbo.Pracownicy.ID_Pracownika AS varchar(10)) + ('    ') + dbo.Pracownicy.Imie + (' ')  +  dbo.Pracownicy.Nazwisko + (' - ') + dbo.Stanowisko.Stanowisko) AS 'Pracownik',
       (CAST (dbo.Dzialy.ID_Dzialu AS varchar (10)) + (' Dzia³ ') + dbo.Dzialy.Nazwa_dzialu) AS 'ID Dzia³u, Nazwa',
	   dbo.Urlop.Data_rozpoczecia AS 'Data Rozpoczêcia Urlopu', dbo.Urlop.Data_zakonczenia AS 'Data Zakoñczenia Urlopu', 
       dbo.Przydzial_Zasobow.Data_Rozpoczecia AS 'Data Rozpoczêcia' , dbo.Przydzial_Zasobow.Data_Zakonczenia AS 'Data Zakoñczenia',
	   (CAST(dbo.Stanowisko.ID_Stanowiska AS varchar(10)) + ('    ') +  dbo.Stanowisko.Stanowisko) AS 'ID Stanowiska, Nazwa Stanowiska', dbo.Pracownicy_Zatrudnienie.Data_Zatrudnienia, dbo.Pracownicy_Zatrudnienie.Koniec_umowy
FROM   

	   dbo.Pracownicy_Zatrudnienie LEFT JOIN

       dbo.Pracownicy ON dbo.Pracownicy_Zatrudnienie.ID_Pracownika = dbo.Pracownicy.ID_Pracownika LEFT JOIN

	   dbo.Dzialy ON dbo.Pracownicy_Zatrudnienie.ID_Dzialu = dbo.Dzialy.ID_Dzialu LEFT JOIN

       dbo.Stanowisko ON dbo.Pracownicy_Zatrudnienie.ID_Stanowiska = dbo.Stanowisko.ID_Stanowiska LEFT JOIN
	   
	   dbo.Urlop ON dbo.Pracownicy.ID_Pracownika = dbo.Urlop.ID_Pracownika 
			AND (dbo.Urlop.Data_zakonczenia > GETDATE() AND dbo.Urlop.Data_rozpoczecia < GETDATE())
			
	   LEFT JOIN dbo.Przydzial_Zasobow ON dbo.Pracownicy.ID_Pracownika = dbo.Przydzial_Zasobow.ID_Pracownika 
			AND (dbo.Przydzial_Zasobow.Data_Zakonczenia > GETDATE() AND dbo.Przydzial_Zasobow.Data_Rozpoczecia < GETDATE())

WHERE ((dbo.Urlop.Data_zakonczenia < GETDATE() OR dbo.Urlop.Data_rozpoczecia > GETDATE()) 
	  OR dbo.Urlop.Data_zakonczenia IS NULL OR dbo.Urlop.Data_rozpoczecia IS NULL) 
	  AND
	  ((dbo.Przydzial_Zasobow.Data_Zakonczenia < GETDATE() OR dbo.Przydzial_Zasobow.Data_Rozpoczecia > GETDATE()) 
	  OR dbo.Przydzial_Zasobow.Data_Zakonczenia IS NULL OR dbo.Przydzial_Zasobow.Data_Rozpoczecia IS NULL)
	 AND
	 (dbo.Pracownicy_Zatrudnienie.Koniec_umowy > GETDATE() AND dbo.Pracownicy_Zatrudnienie.Data_Zatrudnienia < GETDATE())
	 AND
	 dbo.Dzialy.ID_Dzialu = 3
GO


-- wszystkie maszyny

CREATE VIEW vWszystkieMaszyny
AS
SELECT dbo.Maszyny.ID_Maszyny, (CAST(dbo.Maszyny.ID_Maszyny AS varchar(10)) + ('    ') + dbo.Srodki_Trwale.Nazwa) AS 'Maszyna'
FROM   dbo.Maszyny INNER JOIN
       dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale
GO

-- wolne maszyny

CREATE VIEW vWolneMaszyny
AS
SELECT dbo.Maszyny.ID_Maszyny, (CAST(dbo.Maszyny.ID_Maszyny AS varchar(10)) + ('    ') + dbo.Srodki_Trwale.Nazwa) AS 'Maszyna', dbo.Srodki_Trwale.ID_Srodki_Trwale AS 'ID Œrodki Trwa³e', dbo.Przydzial_Zasobow.Data_Zakonczenia AS 'Data Zakoñczenia', 
       dbo.Przydzial_Zasobow.Data_Rozpoczecia AS 'Data Rozpoczêcia ', dbo.Obsluga_Techniczna.Data_Rozpoczecia AS 'Data Rozpoczêcia Naprawy/Serwisu', dbo.Obsluga_Techniczna.Data_Zakonczenia AS 'Data Zakoñczenia Naprawy/Serwisu'
FROM   dbo.Maszyny LEFT JOIN
       dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale LEFT JOIN
       dbo.Przydzial_Zasobow ON dbo.Maszyny.ID_Maszyny = dbo.Przydzial_Zasobow.ID_Maszyny 
	AND (dbo.Przydzial_Zasobow.Data_Zakonczenia > GETDATE() 
	AND dbo.Przydzial_Zasobow.Data_Rozpoczecia < GETDATE()) LEFT JOIN
       dbo.Obsluga_Techniczna ON dbo.Maszyny.ID_Maszyny = dbo.Obsluga_Techniczna.ID_Maszyny 
	AND (dbo.Obsluga_Techniczna.Data_Zakonczenia < GETDATE() 
	AND dbo.Obsluga_Techniczna.Data_Rozpoczecia > GETDATE()) 

WHERE ((dbo.Przydzial_Zasobow.Data_Zakonczenia < GETDATE() OR dbo.Przydzial_Zasobow.Data_Rozpoczecia > GETDATE())
      OR dbo.Przydzial_Zasobow.Data_Zakonczenia IS NULL OR dbo.Przydzial_Zasobow.Data_Rozpoczecia IS NULL)
      AND 
     ((dbo.Obsluga_Techniczna.Data_Zakonczenia < GETDATE() OR dbo.Obsluga_Techniczna.Data_Rozpoczecia > GETDATE()) 
     OR dbo.Obsluga_Techniczna.Data_Zakonczenia IS NULL OR dbo.Obsluga_Techniczna.Data_Rozpoczecia IS NULL)
GO

--elementy w procesie produkcyjnym
CREATE VIEW vElementyProcesProdukcyjny AS
SELECT        dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Proces_Produkcyjny.ID_Zamowienie_Element, dbo.Elementy_Proces.ID_Elementy_Proces, (CAST(dbo.Elementy_Proces.ID_Element AS varchar(10)) + (' ') + dbo.Elementy.Element_Nazwa) AS 'Element', dbo.Elementy_Proces.ID_Element, dbo.Elementy.Element_Nazwa, 
                         dbo.Elementy_Proces.Liczba, dbo.Elementy_Proces.ID_jednostka, dbo.Elementy_Jednostki.Jednostka
FROM            dbo.Elementy_Proces INNER JOIN
                         dbo.Proces_Technologiczny ON dbo.Elementy_Proces.ID_Proces_Technologiczny = dbo.Proces_Technologiczny.ID_Proces_Technologiczny INNER JOIN
                         dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Proces_Zamowienie.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                         dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                         dbo.Elementy ON dbo.Elementy_Proces.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Elementy_Jednostki ON dbo.Elementy_Proces.ID_jednostka = dbo.Elementy_Jednostki.ID_jednostka
GO

------Szacowany czas wg technologow

CREATE VIEW vCzasZamowieniaTechnologow
AS
SELECT  dbo.Zamowienia.ID_Zamowienia, dbo.Zamowienie_Element.ID_Zamowienie_Element, dbo.Elementy.Element_Nazwa, sum(dbo.Etapy_W_Procesie.Czas) as 'Suma_czasu_godz'
FROM     dbo.Zamowienie_Element INNER JOIN
                  dbo.Elementy ON dbo.Zamowienie_Element.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                  dbo.Zamowienia ON dbo.Zamowienie_Element.ID_Zamowienia = dbo.Zamowienia.ID_Zamowienia INNER JOIN
                  dbo.Proces_Zamowienie ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Zamowienie.ID_Zamowienie_Element INNER JOIN
                  dbo.Etapy_W_Procesie ON dbo.Proces_Zamowienie.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny
GROUP BY dbo.Zamowienie_Element.ID_Zamowienie_Element, dbo.Zamowienia.ID_Zamowienia, dbo.Elementy.Element_Nazwa
GO

CREATE VIEW vSzacowanaDataZamowieniaTechnologow
AS
SELECT ID_Zamowienia, ID_Zamowienie_Element, Element_Nazwa, Suma_czasu_godz,
CASE WHEN (22 - datepart(hh,CURRENT_TIMESTAMP)) > Suma_czasu_godz THEN CURRENT_TIMESTAMP + (Suma_czasu_godz/24.0)
ELSE CURRENT_TIMESTAMP + ((((Suma_czasu_godz - (22- datepart(hh,CURRENT_TIMESTAMP)))/16)+1)*8 + Suma_czasu_godz)/24.0 + (((((Suma_czasu_godz - (22- datepart(hh,CURRENT_TIMESTAMP)))/16)+1) + DATEPART(dw,CURRENT_TIMESTAMP))/7)*2 
END AS 'Prognozowana_data_wykonania'
FROM     dbo.vCzasZamowieniaTechnologow
GO
-----Widoki od technologii potrzebne na produkcji

CREATE VIEW vPotrzebnyMaterialDoProcesuProdukcyjnego
AS
SELECT        dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Elementy_Proces.ID_Element, dbo.Elementy.Element_Nazwa, dbo.Elementy_Proces.Liczba, dbo.Elementy_Jednostki.Jednostka
FROM            dbo.Elementy_Proces INNER JOIN
                         dbo.Proces_Technologiczny ON dbo.Elementy_Proces.ID_Proces_Technologiczny = dbo.Proces_Technologiczny.ID_Proces_Technologiczny INNER JOIN
                         dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Proces_Zamowienie.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                         dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                         dbo.Elementy ON dbo.Elementy_Proces.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Elementy_Jednostki ON dbo.Elementy_Proces.ID_jednostka = dbo.Elementy_Jednostki.ID_jednostka
GO

CREATE VIEW vPotrzebneEtapyDoProcesuProdukcyjnego
AS
SELECT dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas
FROM     dbo.Proces_Technologiczny INNER JOIN
                  dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Proces_Zamowienie.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                  dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                  dbo.Etapy_W_Procesie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Rodzaj_Etapu ON dbo.Etapy_W_Procesie.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GO

CREATE VIEW vPotrzebneMaszynyDoProcesuProdukcyjnego
AS
SELECT dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, dbo.Maszyny_Proces.Liczba_Maszyn
FROM     dbo.Proces_Technologiczny INNER JOIN
                  dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Proces_Zamowienie.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                  dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                  dbo.Maszyny_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Maszyny_Proces.ID_Proces_Technologiczny INNER JOIN
                  dbo.Rodzaj_Maszyny ON dbo.Maszyny_Proces.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
GO

CREATE VIEW vPotrzebnaDokumentacjaDoProcesuProdukcyjnego
AS
SELECT dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Dokumentacje.ID_Dokumentacji, dbo.Rodzaj_Dokumentacji.Nazwa AS [Rodzaj], dbo.Dokumentacje.Plik
FROM     dbo.Proces_Technologiczny INNER JOIN
                  dbo.Proces_Zamowienie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Zamowienie_Element ON dbo.Proces_Zamowienie.ID_Zamowienie_Element = dbo.Zamowienie_Element.ID_Zamowienie_Element INNER JOIN
                  dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                  dbo.Dokumentacja_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Dokumentacja_Proces.ID_Proces_Technologiczny INNER JOIN
                  dbo.Dokumentacje ON dbo.Dokumentacja_Proces.ID_Dokumentacji = dbo.Dokumentacje.ID_Dokumentacji INNER JOIN
                  dbo.Rodzaj_Dokumentacji ON dbo.Dokumentacje.ID_Rodzaj_Dokumentacji = dbo.Rodzaj_Dokumentacji.ID_Rodzaj_Dokumentacji
GO

-- Odebrany material
CREATE VIEW vOdebranyMaterialMagazyn
AS
SELECT dbo.Proces_Produkcyjny.ID_Procesu_Produkcyjnego, dbo.Dostarczenia_Wewn.ID_Dostarczenia, dbo.Elementy.Element_Nazwa, dbo.Elementy.ID_Element, - dbo.Dostarczenia_Wewn.Ilosc_Dostarczona AS 'Wartoœæ', 
                  dbo.Dostarczenia_Wewn.Data_Dostarczenia
FROM     dbo.Zamowienie_Element INNER JOIN
                  dbo.Proces_Produkcyjny ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Produkcyjny.ID_Zamowienie_Element INNER JOIN
                  dbo.Dostarczenia_Wewn ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Dostarczenia_Wewn.ID_Zamowienie_element INNER JOIN
                  dbo.Elementy ON dbo.Dostarczenia_Wewn.ID_element = dbo.Elementy.ID_Element
WHERE  (dbo.Dostarczenia_Wewn.Ilosc_Dostarczona < 0) AND ID_Miejsca = 2
GO

CREATE VIEW vOdebranyMaterialProdukcja
AS
SELECT dbo.Odbior_Dostarczenia.ID_Procesu_Produkcyjnego, dbo.Dostarczenia_Wewn.ID_Dostarczenia, dbo.Elementy.Element_Nazwa, dbo.Elementy.ID_Element, - dbo.Dostarczenia_Wewn.Ilosc_Dostarczona as 'Ilosc_dostarczona', 
                  dbo.Dostarczenia_Wewn.Data_Dostarczenia
FROM     dbo.Odbior_Dostarczenia INNER JOIN
                  dbo.Dostarczenia_Wewn ON dbo.Odbior_Dostarczenia.ID_Dostarczenia = dbo.Dostarczenia_Wewn.ID_Dostarczenia INNER JOIN
                  dbo.Elementy ON dbo.Dostarczenia_Wewn.ID_element = dbo.Elementy.ID_Element
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

CREATE VIEW vObsluga  AS
SELECT        dbo.Srodki_Trwale.Nazwa AS [Nazwa maszyny], dbo.Obsluga_Techniczna.Data_Rozpoczecia AS [Data rozpoczêcia], dbo.Obsluga_Techniczna.Data_Zakonczenia AS [Data zakoñczenia], 
                         dbo.Srodki_Trwale.Numer_seryjny AS [Numer seryjny], dbo.Rodzaj_Obslugi.Nazwa AS [Rodzaj obs³ugi], dbo.Pracownicy.Imie + ' ' + dbo.Pracownicy.Nazwisko AS [Imiê i nazwisko]
FROM            dbo.Srodki_Trwale INNER JOIN
                         dbo.Maszyny ON dbo.Srodki_Trwale.ID_Srodki_trwale = dbo.Maszyny.ID_Srodki_Trwale INNER JOIN
                         dbo.Obsluga_Techniczna ON dbo.Maszyny.ID_Maszyny = dbo.Obsluga_Techniczna.ID_Maszyny INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny INNER JOIN
                         dbo.Rodzaj_Obslugi ON dbo.Obsluga_Techniczna.ID_Rodzaj_Obslugi = dbo.Rodzaj_Obslugi.ID_Rodzaj_Obslugi INNER JOIN
                         dbo.Pracownicy ON dbo.Obsluga_Techniczna.ID_Pracownika = dbo.Pracownicy.ID_Pracownika
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

CREATE VIEW vProces_technologiczny AS
SELECT        dbo.Zamowienia.ID_Zamowienia AS [Numer zamówienia], dbo.Elementy.Element_Nazwa AS [Nazwa elementu], dbo.Zamowienie_Element.Ilosc AS [Liczba sztuk],
                         dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Proces_Zamowienie.Kompletny_Proces AS [Kompletny proces]
FROM            dbo.Zamowienia INNER JOIN
                         dbo.Zamowienie_Element ON dbo.Zamowienia.ID_Zamowienia = dbo.Zamowienie_Element.ID_Zamowienia INNER JOIN
                         dbo.Elementy ON dbo.Zamowienie_Element.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Proces_Zamowienie ON dbo.Zamowienie_Element.ID_Zamowienie_Element = dbo.Proces_Zamowienie.ID_Zamowienie_Element INNER JOIN
                         dbo.Proces_Technologiczny ON dbo.Proces_Zamowienie.ID_Proces_Technologiczny = dbo.Proces_Technologiczny.ID_Proces_Technologiczny
GO

CREATE VIEW vProcesy AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas AS [Czas (h)]
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Etapy_W_Procesie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Rodzaj_Etapu ON dbo.Etapy_W_Procesie.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GROUP BY dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas
GO

CREATE VIEW vElementy_proces AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Elementy.Element_Nazwa AS [Nazwa elementu], dbo.Elementy_Proces.Liczba, dbo.Elementy_Jednostki.Jednostka
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Elementy_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Elementy_Proces.ID_Proces_Technologiczny INNER JOIN
                         dbo.Elementy ON dbo.Elementy_Proces.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Elementy_Jednostki ON dbo.Elementy_Proces.ID_jednostka = dbo.Elementy_Jednostki.ID_jednostka
GO

CREATE VIEW vDokumentacja_proces AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Rodzaj_Dokumentacji.Nazwa AS [Rodzaj dokumentacji], dbo.Pracownicy.Imie + ' ' + dbo.Pracownicy.Nazwisko AS Autor, 
                         dbo.Dokumentacje.Plik AS Lokalizacja, dbo.Dokumentacje.Data_Wykonania AS [Data wykonania]
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Dokumentacja_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Dokumentacja_Proces.ID_Proces_Technologiczny INNER JOIN
                         dbo.Dokumentacje ON dbo.Dokumentacja_Proces.ID_Dokumentacji = dbo.Dokumentacje.ID_Dokumentacji INNER JOIN
                         dbo.Rodzaj_Dokumentacji ON dbo.Dokumentacje.ID_Rodzaj_Dokumentacji = dbo.Rodzaj_Dokumentacji.ID_Rodzaj_Dokumentacji INNER JOIN
                         dbo.Pracownicy ON dbo.Dokumentacje.ID_Pracownika = dbo.Pracownicy.ID_Pracownika
GO

CREATE VIEW vEtapy_proces AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas AS [Czas (h)]
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Etapy_W_Procesie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Rodzaj_Etapu ON dbo.Etapy_W_Procesie.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GROUP BY dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas
GO

CREATE VIEW vTechnolodzy AS
SELECT        dbo.Pracownicy.ID_Pracownika, dbo.Pracownicy.Imie + ' ' + dbo.Pracownicy.Nazwisko AS Autor
FROM            dbo.Pracownicy INNER JOIN
                         dbo.Pracownicy_Zatrudnienie ON dbo.Pracownicy.ID_Pracownika = dbo.Pracownicy_Zatrudnienie.ID_Pracownika INNER JOIN
                         dbo.Stanowisko ON dbo.Pracownicy_Zatrudnienie.ID_Stanowiska = dbo.Stanowisko.ID_Stanowiska
GROUP BY dbo.Pracownicy.Imie, dbo.Pracownicy.Nazwisko, dbo.Stanowisko.Stanowisko, dbo.Pracownicy.ID_Pracownika
HAVING        (dbo.Stanowisko.Stanowisko = 'Technolog')
GO

CREATE VIEW vMaszyny_proces AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Rodzaj_Maszyny.Rodzaj_Maszyny AS [Rodzaj maszyny], dbo.Maszyny_Proces.Liczba_Maszyn AS [Liczba maszyn], 
                         dbo.Maszyny_Proces.Liczba_Rbh_Maszyna AS [Liczba roboczogodzin maszyny], dbo.Rodzaj_Maszyny.Koszt_Rbh AS [Koszt roboczogodziny maszyny]
FROM            dbo.Srodki_Trwale INNER JOIN
                         dbo.Maszyny ON dbo.Srodki_Trwale.ID_Srodki_trwale = dbo.Maszyny.ID_Srodki_Trwale INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny INNER JOIN
                         dbo.Proces_Technologiczny INNER JOIN
                         dbo.Maszyny_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Maszyny_Proces.ID_Proces_Technologiczny ON 
                         dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny = dbo.Maszyny_Proces.ID_Rodzaj_Maszyny
GROUP BY dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Maszyny_Proces.Liczba_Maszyn, dbo.Maszyny_Proces.Liczba_Rbh_Maszyna, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, dbo.Rodzaj_Maszyny.Koszt_Rbh
GO

CREATE VIEW vDokumentacja_technologiczna AS
SELECT        dbo.Rodzaj_Dokumentacji.Nazwa
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Dokumentacja_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Dokumentacja_Proces.ID_Proces_Technologiczny INNER JOIN
                         dbo.Dokumentacje ON dbo.Dokumentacja_Proces.ID_Dokumentacji = dbo.Dokumentacje.ID_Dokumentacji INNER JOIN
                         dbo.Pracownicy ON dbo.Dokumentacje.ID_Pracownika = dbo.Pracownicy.ID_Pracownika INNER JOIN
                         dbo.Rodzaj_Dokumentacji ON dbo.Dokumentacje.ID_Rodzaj_Dokumentacji = dbo.Rodzaj_Dokumentacji.ID_Rodzaj_Dokumentacji
GROUP BY dbo.Rodzaj_Dokumentacji.Nazwa
GO

CREATE VIEW vResurs AS
SELECT        TOP (100) PERCENT dbo.Przydzial_Zasobow.ID_Maszyny, dbo.Srodki_Trwale.Producent, dbo.Srodki_Trwale.Nazwa, dbo.Srodki_Trwale.Numer_seryjny, dbo.Maszyny.Resurs_Rbh - DATEDIFF(HH,
                         dbo.Przydzial_Zasobow.Data_Rozpoczecia, dbo.Przydzial_Zasobow.Data_Zakonczenia) AS Pozostaly_Resurs
FROM            dbo.Przydzial_Zasobow INNER JOIN
                         dbo.Maszyny ON dbo.Przydzial_Zasobow.ID_Maszyny = dbo.Maszyny.ID_Maszyny INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny INNER JOIN
                         dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale
ORDER BY dbo.Przydzial_Zasobow.ID_Maszyny
GO

CREATE VIEW vCzas_do_serwisu AS
SELECT dbo.Srodki_Trwale.Producent, dbo.Srodki_Trwale.Nazwa, dbo.Srodki_Trwale.Numer_seryjny, CONVERT (date ,DATEADD(DD, dbo.Maszyny.Serwis_Co_Ile, dbo.Obsluga_Techniczna.Data_Zakonczenia),120) AS Kiedy_Serwis
FROM     dbo.Maszyny INNER JOIN
                  dbo.Rodzaj_Maszyny ON dbo.Maszyny.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny INNER JOIN
                  dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale INNER JOIN
                  dbo.Obsluga_Techniczna ON dbo.Maszyny.ID_Maszyny = dbo.Obsluga_Techniczna.ID_Maszyny INNER JOIN
                  dbo.Rodzaj_Obslugi ON dbo.Obsluga_Techniczna.ID_Rodzaj_Obslugi = dbo.Rodzaj_Obslugi.ID_Rodzaj_Obslugi
WHERE  (dbo.Rodzaj_Obslugi.Nazwa = 'Serwis')
GO

CREATE VIEW vProces_Etapy AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Etapy_W_Procesie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Rodzaj_Etapu ON dbo.Etapy_W_Procesie.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GROUP BY dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas
GO

CREATE VIEW vProces_Maszyna AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, dbo.Maszyny_Proces.Liczba_Maszyn, dbo.Maszyny_Proces.Liczba_Rbh_Maszyna
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Maszyny_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Maszyny_Proces.ID_Proces_Technologiczny INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny_Proces.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
GO



CREATE VIEW vWszystkie_Elementy AS
SELECT        ID_Element, Element_Nazwa
FROM            dbo.Elementy
GO

CREATE VIEW vWszystkie_Maszyny AS
SELECT        dbo.Maszyny.ID_Maszyny, dbo.Srodki_Trwale.Producent, dbo.Srodki_Trwale.Nazwa, dbo.Srodki_Trwale.Numer_seryjny, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny
FROM            dbo.Srodki_Trwale INNER JOIN
                         dbo.Maszyny ON dbo.Srodki_Trwale.ID_Srodki_trwale = dbo.Maszyny.ID_Srodki_Trwale INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
GO

CREATE VIEW vRodzaj_Maszyny AS
SELECT        ID_Rodzaj_Maszyny, Rodzaj_Maszyny
FROM            dbo.Rodzaj_Maszyny
GO

CREATE VIEW vMaszyny_numer_seryjny AS
SELECT        dbo.Maszyny.ID_Maszyny, dbo.Srodki_Trwale.Nazwa + ', ' + dbo.Srodki_Trwale.Numer_seryjny AS Suma
FROM            dbo.Srodki_Trwale INNER JOIN
                         dbo.Maszyny ON dbo.Srodki_Trwale.ID_Srodki_trwale = dbo.Maszyny.ID_Srodki_Trwale
GROUP BY dbo.Maszyny.ID_Maszyny, dbo.Srodki_Trwale.Nazwa, dbo.Srodki_Trwale.Numer_seryjny
GO

CREATE VIEW vDokumentacja_info AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Rodzaj_Dokumentacji.Nazwa AS Rodzaj, dbo.Pracownicy.Imie + ' ' + dbo.Pracownicy.Nazwisko AS [Imiê i nazwisko], 
                         dbo.Dokumentacje.Data_Wykonania AS [Data wykonania]
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Dokumentacja_Proces ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Dokumentacja_Proces.ID_Proces_Technologiczny INNER JOIN
                         dbo.Dokumentacje ON dbo.Dokumentacja_Proces.ID_Dokumentacji = dbo.Dokumentacje.ID_Dokumentacji INNER JOIN
                         dbo.Pracownicy ON dbo.Dokumentacje.ID_Pracownika = dbo.Pracownicy.ID_Pracownika INNER JOIN
                         dbo.Rodzaj_Dokumentacji ON dbo.Dokumentacje.ID_Rodzaj_Dokumentacji = dbo.Rodzaj_Dokumentacji.ID_Rodzaj_Dokumentacji
GROUP BY dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Dokumentacji.Nazwa, dbo.Dokumentacje.Data_Wykonania, dbo.Pracownicy.Imie, dbo.Pracownicy.Nazwisko
GO

CREATE VIEW vProces_elementy AS
SELECT        dbo.Proces_Technologiczny.ID_Proces_Technologiczny AS [Numer procesu], dbo.Rodzaj_Etapu.Nazwa AS [Nazwa etapu], dbo.Etapy_W_Procesie.Czas AS [Czas godziny]
FROM            dbo.Proces_Technologiczny INNER JOIN
                         dbo.Etapy_W_Procesie ON dbo.Proces_Technologiczny.ID_Proces_Technologiczny = dbo.Etapy_W_Procesie.ID_Proces_Technologiczny INNER JOIN
                         dbo.Rodzaj_Etapu ON dbo.Etapy_W_Procesie.ID_Etapu = dbo.Rodzaj_Etapu.ID_Etapu
GROUP BY dbo.Proces_Technologiczny.ID_Proces_Technologiczny, dbo.Rodzaj_Etapu.Nazwa, dbo.Etapy_W_Procesie.Czas
GO

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
-----------------------------------------KONIEC PRZYGOTOWANIE PRODUKCJI----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
USE master