USE Szwalnia
GO
CREATE VIEW vObsluga AS 
SELECT dbo.Obsluga_Techniczna.ID_Obslugi, dbo.Rodzaj_Obslugi.Nazwa, dbo.Maszyny.ID_Maszyny, dbo.Maszyny.Producent, dbo.Maszyny.Model, dbo.Elementy.Element_Nazwa
FROM     dbo.Elementy INNER JOIN
                  dbo.Czesci_Obsluga ON dbo.Elementy.ID_Element = dbo.Czesci_Obsluga.ID_Element CROSS JOIN
                  dbo.Obsluga_Techniczna INNER JOIN
                  dbo.Rodzaj_Obslugi ON dbo.Obsluga_Techniczna.ID_Rodzaj_Obslugi = dbo.Rodzaj_Obslugi.ID_Rodzaj_Obslugi INNER JOIN
                  dbo.Maszyny ON dbo.Obsluga_Techniczna.ID_Maszyny = dbo.Maszyny.ID_Maszyny
GO

CREATE VIEW vMaszyny_rodzaj_liczba AS
SELECT        dbo.Maszyny_Proces.ID_Maszyny_Proces, dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, dbo.Maszyny_Proces.Liczba, dbo.Maszyny_Proces.Liczba_Rbh
FROM            dbo.Maszyny_Proces INNER JOIN
                         dbo.Rodzaj_Maszyny ON dbo.Maszyny_Proces.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
GO

CREATE VIEW vMaszyny_serwis AS 
SELECT ID_Maszyny, Model, Producent, Resurs_rbh, Resurs_data_serwisu
FROM     dbo.Maszyny
WHERE  (Resurs_data_serwisu <= DATEADD(MM, 2, GETDATE())) OR
                  (Resurs_rbh < 80)
GO

Create view vSuma_czasu_proces as 
(SELECT ID_Proces_Technologiczny, SUM(Czas) as suma_czasu  
from Etapy_W_Procesie GROUP BY ID_Proces_Technologiczny);
GO

CREATE VIEW vSrednia_ilosc_maszyn AS
SELECT dbo.Rodzaj_Maszyny.Rodzaj_Maszyny, SUM(dbo.Maszyny_Proces.Liczba) / COUNT(dbo.Proces_Zamowienie.ID_Proces_Zamowienie) AS srednia_ilosc_maszyn
FROM     dbo.Proces_Zamowienie INNER JOIN
                  dbo.Maszyny_Proces ON dbo.Maszyny_Proces.ID_Proces_Technologiczny = dbo.Proces_Zamowienie.ID_Proces_Technologiczny INNER JOIN
                  dbo.Rodzaj_Maszyny ON dbo.Maszyny_Proces.ID_Rodzaj_Maszyny = dbo.Rodzaj_Maszyny.ID_Rodzaj_Maszyny
GROUP BY dbo.Rodzaj_Maszyny.Rodzaj_Maszyny
GO