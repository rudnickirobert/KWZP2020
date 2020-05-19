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
    public partial class NowaFakturaZewnetrzna : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerFaktury;
        public NowaFakturaZewnetrzna(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            btnSave.Visible = true;

            dgvUkryty.DataSource = db.Faktury_Zewnetrzne.ToList();
            int numerOstatniejFaktury = dgvUkryty.Rows.Count;
            lblNumerFaktury.Text = (numerOstatniejFaktury + 1).ToString();

            cbGrupa.DataSource = db.Grupa.ToList();
            cbGrupa.ValueMember = "ID_Grupa";
            cbGrupa.DisplayMember = "Nazwa";
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ZabezpieczeniePrzedPustymiPolami();
            UzupelnianiePol();

            db.SaveChanges();
            MessageBox.Show("Dodano nową fakturę zewnętrzną");
            this.Close();
        }

        private void UzupelnianiePol()
        {
            if (int.TryParse(txtKosztNetto.Text, out int netto) && int.TryParse(txtKosztBrutto.Text, out int brutto) && int.TryParse(txtWartoscPodatku.Text, out int net))
            {
                FakturyOknoDialogowe2(netto, brutto, net);
            }
            else
            {
                MessageBox.Show("Proszę wpisać wartości liczbowe", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKosztNetto.ForeColor = Color.FromArgb(255, 0, 0);
                txtKosztBrutto.ForeColor = Color.FromArgb(255, 0, 0);
                txtWartoscPodatku.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void ZabezpieczeniePrzedPustymiPolami()
        {
            if (String.IsNullOrWhiteSpace(txtNrFaktury.Text) || String.IsNullOrWhiteSpace(txtNazwaFirmy.Text) || String.IsNullOrWhiteSpace(txtKosztNetto.Text) || String.IsNullOrWhiteSpace(txtKosztBrutto.Text) || String.IsNullOrWhiteSpace(txtWartoscPodatku.Text))
            {
                FakturyOknoDialogowe1();
            }
        }

        private static void FakturyOknoDialogowe1()
        {
            MessageBox.Show("Wszystkie pola muszą być uzupełnione", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FakturyOknoDialogowe2(int netto, int brutto, int net)
        {
            Faktury_Zewnetrzne fakturyZewnetrzne = new Faktury_Zewnetrzne();
            fakturyZewnetrzne.Nr_Faktury = txtNrFaktury.Text;
            fakturyZewnetrzne.Nazwa_Firmy = txtNazwaFirmy.Text;
            fakturyZewnetrzne.Netto = netto;
            fakturyZewnetrzne.Brutto = brutto;
            fakturyZewnetrzne.Podatek = net;
            fakturyZewnetrzne.ID_Grupa = Convert.ToInt32(cbGrupa.SelectedValue);
            db.Faktury_Zewnetrzne.Add(fakturyZewnetrzne);
        }
    }
}

