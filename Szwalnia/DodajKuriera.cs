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
    public partial class DodajKuriera : Form
    {
        public SzwalniaEntities db;
        public Kurierzy kurierNowy = new Kurierzy();
        private bool isDelivererValid()
        {
            if (db.Kurierzy.Where(kurierNowy => kurierNowy.Nazwa == txtNazwa.Text).Any())
            {
                MessageBox.Show("Dostawca o takiej nazwie już istnieje");
                return false;
            }

            if (db.Kurierzy.Where(kurierNowy => kurierNowy.Telefon_1 == this.kurierNowy.Telefon_1).Any())
            {
                MessageBox.Show("Dostawca z takim numerem telefonu już istnieje.");
                return false;
            }

            if (db.Kurierzy.Where(kurierNowy => kurierNowy.Email == txtEmail.Text).Any())
            {
                MessageBox.Show("Dostawca z takim adresem e-mail już istnieje.");
                return false;
            }
            return true;
        }
        public DodajKuriera()
        {
            db = Start.szwalnia;
            InitializeComponent();
            lblTelefon2.Enabled = false;
            mtxtTel2.Enabled = false;
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(KurierzyLista).Name].Show();
            this.Hide();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNazwa.TextLength == 0)
            {
                MessageBox.Show("Wpisz nazwę kuriera!");
            }
            else
            {
                kurierNowy.Nazwa = txtNazwa.Text;
                kurierNowy.Telefon_1 = Convert.ToInt32(mtxtTel1.Text);
                if (chkTel2.Checked == true)
                {
                    kurierNowy.Telefon_2 = Convert.ToInt32(mtxtTel2.Text);
                }
                kurierNowy.Email = txtEmail.Text;
                if (!this.isDelivererValid())
                    return;
                db.Kurierzy.Add(kurierNowy);
                db.SaveChanges();
                MessageBox.Show("Dodano nowego kuriera.");
            }
        }

        private void chkTel2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTel2.Checked == false)
            {
                lblTelefon2.Enabled = false;
                mtxtTel2.Enabled = false;
            }
            else
            {
                lblTelefon2.Enabled = true;
                mtxtTel2.Enabled = true;
            }
        }
        private void DodajKuriera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
