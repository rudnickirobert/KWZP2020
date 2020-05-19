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
        public int idProcesu;
        public const string pustePole = "  .  .       :  :";
        public NowaRealizacjaProcesu(SzwalniaEntities db,int idProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            cbxEtap.DataSource = db.Rodzaj_Etapu.ToList();
            cbxEtap.DisplayMember = "Nazwa";
            cbxEtap.ValueMember = "ID_etapu";
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
                realizacjaProcesu.ID_Procesu_Produkcyjnego = this.idProcesu;
                realizacjaProcesu.ID_Etapu = Convert.ToInt32(cbxEtap.SelectedValue);

                if (mtbDataRozpoczecia.Text != pustePole)
                {
                    realizacjaProcesu.Data_Rozpoczecia_Procesu = Convert.ToDateTime(mtbDataRozpoczecia.Text);
                }

                if (mtbDataZakonczenia.Text != pustePole)
                {
                    realizacjaProcesu.Data_Zakonczenia_Procesu = Convert.ToDateTime(mtbDataZakonczenia.Text);
                }

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
