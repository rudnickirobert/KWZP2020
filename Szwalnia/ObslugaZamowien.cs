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
    public partial class ObslugaZamowien : Form
    {
        public SzwalniaEntities db;
        public ObslugaZamowien()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void ObslugaZamowien_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms.OfType<MagazynForm>().Count() > 0)
            {
                Application.OpenForms[typeof(MagazynForm).Name].Show();
            }
            else
            {
                MagazynForm otworzNowyMagazynForm = new MagazynForm();
                otworzNowyMagazynForm.Show();
            }
        }

        private void btnAddWorkersDeliverers_Click(object sender, EventArgs e)
        {
            PrzypiszPracownikaKuriera nowePrzyporzadkowanie = new PrzypiszPracownikaKuriera();
            nowePrzyporzadkowanie.Show();
            this.Hide();
        }

        private void btnPrzyjmijProdukty_Click(object sender, EventArgs e)
        {
            PrzyjmowanieGotowychProduktow przyjmowanie = new PrzyjmowanieGotowychProduktow();
            przyjmowanie.Show();
            this.Hide();
        }

        private void btnWydajKurierowi_Click(object sender, EventArgs e)
        {

        }
    }
}
