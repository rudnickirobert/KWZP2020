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
        public KlienciSzczegoly( SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            Klienci customer = db.Klienci.Where(wybrane => wybrane.ID_Klienta == ID).First();
            lblTitle.Text = "Dane klienta o ID: " + customer.ID_Klienta;
            txtNazwa.Text = customer.Nazwa_Firmy;
            txtNIP.Text = customer.NIP;
            txtAdres.Text = customer.Adres;
            txtTelefon.Text = customer.Telefon;
            txtEmail.Text = customer.E_Mail;
        }

        private void btnWrocKlienci_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
