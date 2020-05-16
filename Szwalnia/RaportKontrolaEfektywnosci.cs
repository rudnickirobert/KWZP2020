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
    public partial class RaportKontrolaEfektywnosci : Form
    {
        public SzwalniaEntities db;

        public RaportKontrolaEfektywnosci(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            dgvKontrolaProcesu.DataSource = db.vKontrolaProcesu.ToList();
            dgvKontrolaProcesu.Columns[0].HeaderText = "ID procesu produkcyjnego";
            dgvKontrolaProcesu.Columns[1].HeaderText = "ID zamówienia";
            dgvKontrolaProcesu.Columns[2].HeaderText = "Nazwa elementu";
            dgvKontrolaProcesu.Columns[7].HeaderText = "Data kontroli";
            dgvKontrolaProcesu.Columns[3].HeaderText = "Ilość [szt]";
            dgvKontrolaProcesu.Columns[4].HeaderText = "Liczba poprawnie wykonanych";
            dgvKontrolaProcesu.Columns[5].HeaderText = "Status produktów";
            dgvKontrolaProcesu.Columns[6].HeaderText = "Bilans produktów";

            string[] statusProduktow = { "Nadwyżka produktów", "Poprawna ilość produktów", "Niedobór produktów" };
            cbxStatus.DataSource = statusProduktow.ToList();
            cbxStatus.DisplayMember = "Status produktów";
        }

        private void btnSzukajIDPrcoes_Click(object sender, EventArgs e)
        {
            dgvKontrolaProcesu.DataSource = this.db.vKontrolaProcesu.Where(proces => proces.ID_procesu_produkcyjnego == nudProces.Value).ToList();
        }

        private void btnIDZamowienia_Click(object sender, EventArgs e)
        {
            dgvKontrolaProcesu.DataSource = this.db.vKontrolaProcesu.Where(zamowienie => zamowienie.ID_zamówienia == nudZamowienie.Value).ToList();
        }

        private void btnSzukajStatus_Click(object sender, EventArgs e)
        {
            dgvKontrolaProcesu.DataSource = this.db.vKontrolaProcesu.Where(status => status.Status_produktów.Contains(cbxStatus.SelectedValue.ToString())).ToList();
        }

        private void btnSzukajData_Click(object sender, EventArgs e)
        {
            dgvKontrolaProcesu.DataSource = this.db.vKontrolaProcesu.Where(data => (data.Data_kontroli.Value.Day == dtpDataKontroli.Value.Day) && (data.Data_kontroli.Value.Month == dtpDataKontroli.Value.Month) && (data.Data_kontroli.Value.Year == dtpDataKontroli.Value.Year)).ToList();
        }


        private void btnWszystkie_Click(object sender, EventArgs e)
        {
            dgvKontrolaProcesu.DataSource = db.vKontrolaProcesu.ToList();
        }
    }
}
