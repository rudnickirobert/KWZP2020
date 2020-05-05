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
    public partial class Klienci_szczegoly : Form
    {
        public Klienci_szczegoly( SzwalniaEntities db, String customerNazwaFirmy)
        {
            InitializeComponent();

            Klienci customer = db.Klienci
                .Where(klient => klient.Nazwa_Firmy == customerNazwaFirmy).First();

            lblTitle.Text = customer.Nazwa_Firmy;
            txtNazwa.Text = customer.Nazwa_Firmy;
            txtNIP.Text = customer.NIP;
            txtAdres.Text = customer.Adres;
            txtTelefon.Text = customer.Telefon;
            txtEmail.Text = customer.E_Mail;

        }
    }
}
