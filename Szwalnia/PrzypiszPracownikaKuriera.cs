using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class PrzypiszPracownikaKuriera : Form
    {
        public bool czyZostalyZamowieniaDoPrzypisania = false;
        public SzwalniaEntities db;
        public PrzypiszPracownikaKuriera()
        {
            InitializeComponent();
            db = Start.szwalnia;

            if (db.vPracownicyMagazynu.Where(pracownik => pracownik.ID_Pracownika > 0).Any())
            {
                cmbPracownicy.DataSource = db.vPracownicyMagazynu.ToList();
                cmbPracownicy.DisplayMember = "Dane_osobowe";
                cmbPracownicy.ValueMember = "ID_Pracownika";
            }
            else
            {
                DataTable brakPracownikow = new DataTable();
                brakPracownikow.Columns.Add("Informacja");
                brakPracownikow.Rows.Add("Nie ma takich pracownikow");
                cmbPracownicy.DataSource = brakPracownikow;
                cmbPracownicy.DisplayMember = "Informacja";
                cmbPracownicy.ValueMember = "Informacja";
            }

            if(db.vZamowieniaNieprzypisaneDoPracownikaIKuriera.Where(nieprzypisane => nieprzypisane.ID_Zamowienia>0).Any())
            {
                czyZostalyZamowieniaDoPrzypisania = true;
                cmbZamowienia.DataSource = db.vZamowieniaNieprzypisaneDoPracownikaIKuriera.ToList();
                cmbZamowienia.DisplayMember = "ID_Zamowienia";
                cmbZamowienia.ValueMember = "ID_Zamowienia";
            }
            else
            {
                DataTable brakZamowienDoPrzypisania = new DataTable();
                brakZamowienDoPrzypisania.Columns.Add("Informacja");
                brakZamowienDoPrzypisania.Rows.Add("Nie ma już zamówień do przypisania");
                cmbZamowienia.DataSource = brakZamowienDoPrzypisania;
                cmbZamowienia.DisplayMember = "Informacja";
                cmbZamowienia.ValueMember = "Informacja";
            }

        }

    }
}
