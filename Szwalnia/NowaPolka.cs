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
        private static bool closingByAnotherForm;
        public static bool isClosedByAnotherForm
        {
            get
            {
                return closingByAnotherForm;
            }
            set
            {
                if (closingByAnotherForm != value)
                    closingByAnotherForm = value;
            }
        }
        public NowaPolka()
        {
            InitializeComponent();
            db = Start.szwalnia;
            nowaPolka = db.Polki.Count()+1;
            lblNumerNowejPolki.Text = nowaPolka.ToString();
            cmbOznaczenie.Sorted = true;
            cmbOznaczenie.DataSource = db.vRegaly_alfabetycznie.ToList();
            cmbOznaczenie.DisplayMember = "Oznaczenie";
            cmbOznaczenie.ValueMember = "ID_regal";
            cmbRozmiar.Sorted = true;
            cmbRozmiar.DataSource = db.vPolki_Rozmiary.ToList();
            cmbRozmiar.DisplayMember = "Wymiar";
            cmbRozmiar.ValueMember = "ID_Rozmiar_Polki";
        }
        private void btnDodajPolke_Click(object sender, EventArgs e)
        {
            Polki polkaNew = new Polki();
            polkaNew.ID_Rozmiar_Polki = Convert.ToInt32(cmbRozmiar.SelectedValue);
            db.Polki.Add(polkaNew);

            Polki_regaly polkaRegalNew = new Polki_regaly();
            polkaRegalNew.ID_regal = Convert.ToInt32(cmbOznaczenie.SelectedValue);
            polkaRegalNew.ID_Polka = nowaPolka;
            db.Polki_regaly.Add(polkaRegalNew);
            db.SaveChanges();
            
            MessageBox.Show("Pomyślnie dodano do bazy półkę " + nowaPolka.ToString() + "\nRegał: " + cmbOznaczenie.Text + "\nWymiary: " + cmbRozmiar.Text);
            nowaPolka++;
            lblNumerNowejPolki.Text = nowaPolka.ToString();
        }
        private void btnNowyRegal_Click(object sender, EventArgs e)
        {
            isClosedByAnotherForm = true;
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
            if (!isClosedByAnotherForm)
                Start.GetForm.Show();
        }
    }
}
