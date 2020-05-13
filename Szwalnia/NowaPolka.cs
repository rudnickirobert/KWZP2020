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
    public partial class NowaPolka : Form
    {
        public SzwalniaEntities db;
        int nowaPolka;
        public NowaPolka(int ostatniaPolka)
        {
            InitializeComponent();
            db = Start.szwalnia;
            nowaPolka = ostatniaPolka+1;
            lblNumerNowejPolki.Text = nowaPolka.ToString();
            cmbOznaczenie.DataSource = db.Regaly.ToList();
            cmbOznaczenie.DisplayMember = "Oznaczenie";
            cmbOznaczenie.ValueMember = "ID_regal"; //chyba
            cmbRozmiar.DataSource = db.vPolki_Rozmiary.ToList();
            cmbRozmiar.DisplayMember = "Wymiar";
            cmbRozmiar.ValueMember = "ID_Rozmiar_Polki";
        }

        private void btnNowyRegal_Click(object sender, EventArgs e)
        {
            NowyRegal nowy = new NowyRegal();
            nowy.Show();
            this.Hide();
        }

        private void btnNowyRozmiarPolki_Click(object sender, EventArgs e)
        {
            NowyRozmiarPolki nowy = new NowyRozmiarPolki();
            nowy.Show();
            this.Hide();
        }

        private void NowaPolka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
