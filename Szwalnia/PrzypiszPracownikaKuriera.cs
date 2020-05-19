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
        public int[] arrBackupDanych;
        public bool boolCzyZainicjalizowane = false;
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

            if (db.vUmowyKurierzy.Any())
            {
                dgvKurierzy.DataSource = db.vUmowyKurierzy.ToList();
            }
            else
            {
                DataTable brakUmow = new DataTable();
                brakUmow.Columns.Add("Informacja");
                brakUmow.Rows.Add("Nie istnieją żadne umowy z kurierami");
                dgvKurierzy.DataSource = brakUmow;
            }

            if (db.vZamowieniaNieprzypisaneDoPracownikaIKuriera.Where(nieprzypisane => nieprzypisane.ID_Zamowienia > 0).Any())
            {
                czyZostalyZamowieniaDoPrzypisania = true;
                cmbZamowienia.DataSource = db.vZamowieniaNieprzypisaneDoPracownikaIKuriera.ToList();
                cmbZamowienia.DisplayMember = "ID_Zamowienia";
                cmbZamowienia.ValueMember = "ID_Zamowienia";
                int intIDZamowieniaWybrane = Convert.ToInt32(cmbZamowienia.SelectedValue);
                vZamowieniaDystans dystansZamowienia = db.vZamowieniaDystans.Where(wybraneZamowienie => wybraneZamowienie.ID_Zamowienia == intIDZamowieniaWybrane).First();
                int intDystans = Convert.ToInt32(dystansZamowienia.Odleglosc_km);
                arrBackupDanych = new int[dgvKurierzy.Rows.Count];
                for (int i = 0; i < dgvKurierzy.Rows.Count; i++)
                {
                    arrBackupDanych[i] = Convert.ToInt32(dgvKurierzy.Rows[i].Cells[4].Value);
                    dgvKurierzy.Rows[i].Cells[4].Value = Convert.ToString(arrBackupDanych[i] * intDystans);
                    dgvKurierzy.Rows[i].Cells[6].Value = Convert.ToString(Convert.ToInt32(dgvKurierzy.Rows[i].Cells[4].Value) + Convert.ToInt32(dgvKurierzy.Rows[i].Cells[5].Value));
                }
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
            boolCzyZainicjalizowane = true;
        }

        private void dgvKurierzy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vUmowyKurierzy.Any() && db.vZamowieniaNieprzypisaneDoPracownikaIKuriera.Any())
            {

            }
        }

        private void cmbZamowienia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boolCzyZainicjalizowane)
            {
                int intIDZamowieniaWybrane = Convert.ToInt32(cmbZamowienia.SelectedValue);
                vZamowieniaDystans dystansZamowienia = db.vZamowieniaDystans.Where(wybraneZamowienie => wybraneZamowienie.ID_Zamowienia == intIDZamowieniaWybrane).First();
                int intDystans = Convert.ToInt32(dystansZamowienia.Odleglosc_km);
                for (int i = 0; i < dgvKurierzy.Rows.Count; i++)
                {
                    dgvKurierzy.Rows[i].Cells[4].Value = Convert.ToString(arrBackupDanych[i] * intDystans);
                    dgvKurierzy.Rows[i].Cells[6].Value = Convert.ToString(Convert.ToInt32(dgvKurierzy.Rows[i].Cells[4].Value) + Convert.ToInt32(dgvKurierzy.Rows[i].Cells[5].Value));
                }
            }
        }

        private void PrzypiszPracownikaKuriera_FormClosed(object sender, FormClosedEventArgs e)
        {
            //restart zawartości dgv
            for (int i = 0; i < dgvKurierzy.Rows.Count; i++)
            {
                dgvKurierzy.Rows[i].Cells[4].Value = Convert.ToString(arrBackupDanych[i]);
                dgvKurierzy.Rows[i].Cells[6].Value = null;
            }

            Start.GetForm.Show();
        }
    }
}
