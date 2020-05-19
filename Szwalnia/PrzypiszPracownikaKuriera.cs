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
        private static bool zamknieciePrzezInnyFormularz;
        public bool czyUruchamiacPoprzedniFormularz = true;
        public static bool czyZamknietyPrzezInny
        {
            get
            {
                return zamknieciePrzezInnyFormularz;
            }
            set
            {
                if (zamknieciePrzezInnyFormularz != value)
                    zamknieciePrzezInnyFormularz = value;
            }
        }
        public bool czyZostalyZamowieniaDoPrzypisania = false;
        public SzwalniaEntities db;
        public int[] intDataBackup;
        public bool czyZainicjowane = false;
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
            if(db.vUmowyKurierzy.Any() && db.vZamowieniaNieprzypisaneDoPracownikaIKuriera.Any() && db.vPracownicyMagazynu.Any())
            {
                dgvKurierzy.DataSource = db.vUmowyKurierzy.ToList();
                intDataBackup = new int[dgvKurierzy.Rows.Count];
                int intIDZamowienia = Convert.ToInt32(cmbZamowienia.SelectedValue);
                vZamowieniaDystans dystansZamowienia = db.vZamowieniaDystans.Where(dystansWybranego => dystansWybranego.ID_Zamowienia == intIDZamowienia).First();
                int intDystans = Convert.ToInt32(dystansZamowienia.Odleglosc_km);
                for (int i = 0; i < dgvKurierzy.Rows.Count; i++)
                {
                    intDataBackup[i] = Convert.ToInt32(dgvKurierzy.Rows[i].Cells[4].Value);
                    dgvKurierzy.Rows[i].Cells[4].Value = Convert.ToString(intDataBackup[i] * intDystans);
                    dgvKurierzy.Rows[i].Cells[6].Value = Convert.ToString(Convert.ToInt32(dgvKurierzy.Rows[i].Cells[4].Value) + Convert.ToInt32(dgvKurierzy.Rows[i].Cells[5].Value));
                }
                czyZainicjowane = true;
            }
            else if (db.vUmowyKurierzy.Any() == false)
            {
                DataTable brakUmow = new DataTable();
                brakUmow.Columns.Add("Informacja");
                brakUmow.Rows.Add("Nie istnieją żadne umowy zawarte z kurierami");
                dgvKurierzy.DataSource = brakUmow;                
            }
            else
            {
                dgvKurierzy.DataSource = null;
            }
            
        }

        private void PrzypiszPracownikaKuriera_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!czyZamknietyPrzezInny && czyUruchamiacPoprzedniFormularz)
            {
                if (Application.OpenForms.OfType<ObslugaZamowien>().Count() > 0)
                {
                    Application.OpenForms[typeof(ObslugaZamowien).Name].Show();
                }
            }
            dgvKurierzy.DataSource = db.vUmowyKurierzy.ToList();
        }

        private void dgvKurierzy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intIDZamowienie = Convert.ToInt32(cmbZamowienia.SelectedValue);
            int intPracownikID = Convert.ToInt32(cmbPracownicy.SelectedValue);
            int intUmowaID = Convert.ToInt32(dgvKurierzy.CurrentRow.Cells[0].Value);
            PopupAcceptDeny akceptujPrzypisanieKurieraIPracownika = new PopupAcceptDeny(intIDZamowienie,intPracownikID,intUmowaID,true);
            akceptujPrzypisanieKurieraIPracownika.Show();
            czyUruchamiacPoprzedniFormularz = false;
            this.Close();
        }

        private void cmbZamowienia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(czyZainicjowane)
            {
                int intIDZamowienia = Convert.ToInt32(cmbZamowienia.SelectedValue);
                vZamowieniaDystans dystansZamowienia = db.vZamowieniaDystans.Where(dystansWybranego => dystansWybranego.ID_Zamowienia == intIDZamowienia).First();
                int intDystans = Convert.ToInt32(dystansZamowienia.Odleglosc_km);
                for (int i = 0; i < dgvKurierzy.Rows.Count; i++)
                {
                    dgvKurierzy.Rows[i].Cells[4].Value = Convert.ToString(intDataBackup[i] * intDystans);
                    dgvKurierzy.Rows[i].Cells[6].Value = Convert.ToString(Convert.ToInt32(dgvKurierzy.Rows[i].Cells[4].Value) + Convert.ToInt32(dgvKurierzy.Rows[i].Cells[5].Value));
                }
            }
        }


        private void PrzypiszPracownikaKuriera_FormClosing(object sender, FormClosingEventArgs e)
        {

            for (int i = 0; i < dgvKurierzy.Rows.Count; i++)
            {
                dgvKurierzy.Rows[i].Cells[4].Value = Convert.ToString(intDataBackup[i]);
                dgvKurierzy.Rows[i].Cells[6].Value = null;
            }
            dgvKurierzy.DataSource = null;
        }
    }
}
