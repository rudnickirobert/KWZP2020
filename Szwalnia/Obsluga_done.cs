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
    public partial class Obsluga_done : Form
    {
        public Obsluga_done(SzwalniaEntities db, String RodzajObslugi)
        {
            InitializeComponent();
            Obsluga_Techniczna Obslga = db.Obsluga_Techniczna.Where(Rodzaj1 => Rodzaj1.Rodzaj_Obslugi.Nazwa == RodzajObslugi).First();
            lblTitle.Text = Obslga.Rodzaj_Obslugi.Nazwa;
            txtRodzaj.Text = Obslga.Rodzaj_Obslugi.Nazwa;
            txtMaszyna.Text = Obslga.Maszyny.Model;
            txtPracownik.Text = Obslga.Pracownicy.Nazwisko;
            txtData.Text = Obslga.Data_Wykonania.ToString();
            dgvObsluga.DataSource = db.vObsluga.Where(Rodzaj1 => Rodzaj1.Nazwa == RodzajObslugi).ToList();

        }

        private void Obsluga_done_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCzesci_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIlosc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
