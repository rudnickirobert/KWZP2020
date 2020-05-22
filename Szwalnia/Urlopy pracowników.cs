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
    public partial class UrlopyPracownikow : Form
    {
        public SzwalniaEntities db;
        public UrlopyPracownikow(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            dgvUrlopy.DataSource = db.vUrlopyWszyskie.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NowyUrlop nowyUrlop = new NowyUrlop(db);
            nowyUrlop.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
           dgvUrlopy.DataSource = db.vUrlopyWszyskie.Where(data => (((data.Data_rozpoczecia.Day >= dtpPierwszaDataRozpoczecia.Value.Day) && (data.Data_rozpoczecia.Day <= dtpDrugaDataRozpoczecia.Value.Day)) && ((data.Data_rozpoczecia.Month >= dtpPierwszaDataRozpoczecia.Value.Month) && (data.Data_rozpoczecia.Month <= dtpDrugaDataRozpoczecia.Value.Month)) && ((data.Data_rozpoczecia.Year >= dtpPierwszaDataRozpoczecia.Value.Year) && (data.Data_rozpoczecia.Year <= dtpDrugaDataRozpoczecia.Value.Year)))).ToList();

        }

        private void btnSzukaj2_Click(object sender, EventArgs e)
        {
            dgvUrlopy.DataSource = db.vUrlopyWszyskie.Where(data => (((data.Data_zakonczenia.Day >= dtpPierwszaDataZakonczenia.Value.Day) && (data.Data_zakonczenia.Day <= dtpDrugaDataZakonczenia.Value.Day)) && ((data.Data_zakonczenia.Month >= dtpPierwszaDataZakonczenia.Value.Month) && (data.Data_zakonczenia.Month <= dtpDrugaDataZakonczenia.Value.Month)) && ((data.Data_zakonczenia.Year >= dtpPierwszaDataZakonczenia.Value.Year) && (data.Data_zakonczenia.Year <= dtpDrugaDataZakonczenia.Value.Year)))).ToList();

        }

        private void btnWszystkie_Click(object sender, EventArgs e)
        {
            dgvUrlopy.DataSource = db.vUrlopyWszyskie.ToList();
        }
    }
}
