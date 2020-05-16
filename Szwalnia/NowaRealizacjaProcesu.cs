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
    public partial class NowaRealizacjaProcesu : Form
    {
        public SzwalniaEntities db;
        public int idEtapu;
        public NowaRealizacjaProcesu(SzwalniaEntities db,int idEtapu)
        {
            InitializeComponent();
            this.db = db;
            this.idEtapu = idEtapu;
            cbxEtap.DataSource = db.Rodzaj_Etapu.ToList();
            cbxEtap.DisplayMember = "Nazwa";
            cbxEtap.ValueMember = "Nazwa";
        }

        private void btnAnuluj_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Realizacja_Procesu realizacjaProcesu = new Realizacja_Procesu();
            if (string.IsNullOrEmpty(cbxEtap.Text))
            {
                MessageBox.Show("Uzupełnienie pola 'Nazwa etapu' jest wymagane!");
            }
            else
            {
                realizacjaProcesu.ID_Etapu = Convert.ToInt32(cbxEtap.Text);
                realizacjaProcesu.Data_Rozpoczecia_Procesu = Convert.ToDateTime(mtbDataRozpoczecia);
                realizacjaProcesu.Data_Zakonczenia_Procesu = Convert.ToDateTime(mtbDataZakonczenia);
                db.Realizacja_Procesu.Add(realizacjaProcesu);
                db.SaveChanges();
                MessageBox.Show("Dodano nową realizację");
            }
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            cbxEtap.Text = "";
            mtbDataRozpoczecia.Text = "";
            mtbDataZakonczenia.Text = "";
        }

        private void btnDzisRozpoczecie_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczecia.Text = DateTime.Now.ToString();
        }

        private void btnDzisZakonczenie_Click(object sender, EventArgs e)
        {
            mtbDataZakonczenia.Text = DateTime.Now.ToString();
        }
    }
}
