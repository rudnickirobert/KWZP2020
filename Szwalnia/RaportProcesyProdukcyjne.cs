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
    public partial class RaportProcesyProdukcyjne : Form
    {
        public SzwalniaEntities db;
        public RaportProcesyProdukcyjne(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvProcesy.DataSource = db.vZamowienieProcesyProdukcyjne.ToList();

        }

        private void btnSzukajRozpoczecie_Click(object sender, EventArgs e)
        {
            dgvProcesy.DataSource = db.vZamowienieProcesyProdukcyjne.Where(data =>( ((data.Data_Rozpoczecia.Value.Day >= dtpPierwszaDataRozpoczecia.Value.Day) && (data.Data_Rozpoczecia.Value.Day <= dtpDrugaDataRozpoczecia.Value.Day)) && ((data.Data_Rozpoczecia.Value.Month >= dtpPierwszaDataRozpoczecia.Value.Month) && (data.Data_Rozpoczecia.Value.Month <= dtpDrugaDataRozpoczecia.Value.Month)) && ((data.Data_Rozpoczecia.Value.Year >= dtpPierwszaDataRozpoczecia.Value.Year) && (data.Data_Rozpoczecia.Value.Year <= dtpDrugaDataRozpoczecia.Value.Year)))).ToList();
        }

        private void btnSzukajZakonczenie_Click(object sender, EventArgs e) 
        {
            dgvProcesy.DataSource = db.vZamowienieProcesyProdukcyjne.Where(data => (((data.Data_Zakonczenia.Value.Day >= dtpPierwszaDataZakonczenia.Value.Day) && (data.Data_Zakonczenia.Value.Day <= dtpDrugaDataZakonczenia.Value.Day)) && ((data.Data_Zakonczenia.Value.Month >= dtpPierwszaDataZakonczenia.Value.Month) && (data.Data_Zakonczenia.Value.Month <= dtpDrugaDataZakonczenia.Value.Month)) && ((data.Data_Zakonczenia.Value.Year >= dtpPierwszaDataZakonczenia.Value.Year) && (data.Data_Zakonczenia.Value.Year <= dtpDrugaDataZakonczenia.Value.Year)))).ToList();
        }
    }
}
