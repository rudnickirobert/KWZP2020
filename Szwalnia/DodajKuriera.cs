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

        private void DodajKuriera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
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
    }
}
