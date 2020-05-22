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
    public partial class KlienciSzczegoly : Form
    {
        private SzwalniaEntities db;
        private int id_klienta;
        public KlienciSzczegoly(SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            this.db = db;
            this.id_klienta = ID;
            Klienci customer = db.Klienci.Where(wybrane => wybrane.ID_Klienta == ID).First();
            txtNazwa.Text = customer.Nazwa_Firmy;
            txtNIP.Text = customer.NIP;
            txtAdres.Text = customer.Adres;
            txtTelefon.Text = customer.Telefon;
            txtEmail.Text = customer.E_Mail;

            dgvKlienciSzczegoly.DataSource = db.vKlienciZamowienie.Where(zamowienie => zamowienie.ID_Klienta == customer.ID_Klienta).ToList();
            
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NoweZamowienie noweZamowienie = new NoweZamowienie(this.db, this.id_klienta);
            noweZamowienie.Show();
        }
    }
}

