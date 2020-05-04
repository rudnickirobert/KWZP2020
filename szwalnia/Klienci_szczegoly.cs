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
        public Klienci_szczegoly( SzwalniaEntities db, String employeeNazwaFirmy)
        {
            InitializeComponent();

            Klienci employee = db.Klienci
                .Where(klient => klient.Nazwa_Firmy == employeeNazwaFirmy).First();

            lblTitle.Text = employee.Nazwa_Firmy;
            txtNazwa.Text = employee.Nazwa_Firmy;
            txtNIP.Text = employee.NIP;
            txtAdres.Text = employee.Adres;
            txtTelefon.Text = employee.Telefon;
            txtEmail.Text = employee.E_Mail;

        }
    }
}
