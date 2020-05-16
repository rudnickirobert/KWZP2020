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

--odebrany material
CREATE VIEW vOdebranyMaterial
AS
SELECT dbo.Odbior_Dostarczenia.ID_Procesu_Produkcyjnego, dbo.Dostarczenia_Wewn.ID_Dostarczenia, dbo.Dostarczenia_Wewn.Data_Dostarczenia, dbo.Elementy.Element_Nazwa, dbo.Dostarczenia_Wewn.ID_Zamowienie_element, 
                  dbo.Dostarczenia_Wewn.Ilosc_Dostarczona
FROM     dbo.Odbior_Dostarczenia INNER JOIN
                  dbo.Dostarczenia_Wewn ON dbo.Odbior_Dostarczenia.ID_Dostarczenia = dbo.Dostarczenia_Wewn.ID_Dostarczenia INNER JOIN
                  dbo.Elementy ON dbo.Dostarczenia_Wewn.ID_element = dbo.Elementy.ID_Element
WHERE ID_Miejsca = 2


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
SELECT        dbo.Srodki_Trwale.Nazwa AS [Nazwa maszyny], dbo.Srodki_Trwale.Numer_seryjny AS [Numer seryjny], dbo.Rodzaj_Obslugi.Nazwa AS [Rodzaj obs³ugi],(dbo.Pracownicy.Imie)+(' ')+(dbo.Pracownicy.Nazwisko) AS [Imiê i nazwisko], 
                         dbo.Obsluga_Techniczna.Data_Rozpoczecia AS [Data rozpoczêcia], dbo.Obsluga_Techniczna.Data_Zakonczenia AS [Data zakoñczenia]
FROM            dbo.Obsluga_Techniczna INNER JOIN
                         dbo.Pracownicy ON dbo.Obsluga_Techniczna.ID_Pracownika = dbo.Pracownicy.ID_Pracownika INNER JOIN
                         dbo.Czesci_Obsluga ON dbo.Obsluga_Techniczna.ID_Obsluga_Techniczna = dbo.Czesci_Obsluga.ID_Obsluga_Techniczna INNER JOIN
                         dbo.Elementy ON dbo.Czesci_Obsluga.ID_Element = dbo.Elementy.ID_Element INNER JOIN
                         dbo.Maszyny ON dbo.Obsluga_Techniczna.ID_Maszyny = dbo.Maszyny.ID_Maszyny INNER JOIN
                         dbo.Srodki_Trwale ON dbo.Maszyny.ID_Srodki_Trwale = dbo.Srodki_Trwale.ID_Srodki_trwale INNER JOIN
                         dbo.Rodzaj_Obslugi ON dbo.Obsluga_Techniczna.ID_Rodzaj_Obslugi = dbo.Rodzaj_Obslugi.ID_Rodzaj_Obslugi INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
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