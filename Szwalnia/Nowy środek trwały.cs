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
    public partial class NowySrodekTrwaly : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerSrodka;
        public NowySrodekTrwaly(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            dgvUkryty.DataSource = db.Srodki_Trwale.ToList();
            int ostatniNumerSrodkaa = dgvUkryty.Rows.Count;
            lblNumer.Text = (ostatniNumerSrodka + 1).ToString();


            cbDzial.DataSource = db.Dzialy.ToList();
            cbDzial.ValueMember = "ID_Dzialu";
            cbDzial.DisplayMember = "Nazwa_dzialu";
            cbDzial.Refresh();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Srodki_Trwale srodkiTrwale = new Srodki_Trwale();
            srodkiTrwale.Nazwa = txtNazwa.Text;
            srodkiTrwale.Numer_seryjny = txtNr.Text;
            srodkiTrwale.Producent = txtProducent.Text;
            srodkiTrwale.Roczny_stopien_amortyzacji = txtAmort.Text;
            srodkiTrwale.Zamortyzowane = Convert.ToBoolean(chbAmortyzacja.Checked);
            srodkiTrwale.ID_Dzialu = Convert.ToInt32(cbDzial.SelectedValue);
            srodkiTrwale.Gwarancja = Convert.ToDateTime(dtpGwarancja.Value);
            db.Srodki_Trwale.Add(srodkiTrwale);
            db.SaveChanges();
            MessageBox.Show("Dodano nowy środek trwały");
            txtNazwa.Text = "";
            txtNr.Text = "";
            txtAmort.Text = "";
            chbAmortyzacja.Text = "";
            txtProducent.Text = "";
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Srodki_Trwale srodkiTrwale = new Srodki_Trwale();
            srodkiTrwale.Nazwa = txtNazwa.Text;
            srodkiTrwale.Numer_seryjny = txtNr.Text;
            srodkiTrwale.Producent = txtProducent.Text;
            srodkiTrwale.Roczny_stopien_amortyzacji = txtAmort.Text;
            srodkiTrwale.Zamortyzowane = Convert.ToBoolean(chbAmortyzacja.Checked);
            srodkiTrwale.ID_Dzialu = Convert.ToInt32(cbDzial.SelectedValue);
            srodkiTrwale.Gwarancja = Convert.ToDateTime(dtpGwarancja.Value);
            db.Srodki_Trwale.Add(srodkiTrwale);
            db.SaveChanges();
            MessageBox.Show("Dodano nowy środek trwały");
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
