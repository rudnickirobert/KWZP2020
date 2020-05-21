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
    public partial class DodajDostawce : Form
    {
        public SzwalniaEntities db;
        public Dostawcy_Zaopatrzenie dostawcaNowy = new Dostawcy_Zaopatrzenie();
        public DodajDostawce()
        {
            db = Start.szwalnia;
            InitializeComponent();
        }

        private bool isSupplierValid()
        {
            if (db.Dostawcy_Zaopatrzenie.Where(dostawca => dostawca.Nazwa == txtNazwa.Text).Any())
            {
                MessageBox.Show("Dostawca o takiej nazwie już istnieje");
                return false;
            }

            if (db.Dostawcy_Zaopatrzenie.Where(dostawca => dostawca.Telefon_1 == dostawcaNowy.Telefon_1).Any())
            {
                MessageBox.Show("Dostawca z takim numerem telefonu już istnieje.");
                return false;
            }

            if (db.Dostawcy_Zaopatrzenie.Where(dostawca => dostawca.Email == txtEmail.Text).Any())
            {
                MessageBox.Show("Dostawca z takim adresem e-mail już istnieje.");
                return false;
            }
            return true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNazwa.TextLength == 0)
            {
                MessageBox.Show("Wpisz nazwę dostawcy!");                
            }
            else
            {
                dostawcaNowy.Nazwa = txtNazwa.Text;
                dostawcaNowy.Telefon_1 = Convert.ToInt32(mtxtTel1.Text);
                if (chkTel2.Checked == true)
                    dostawcaNowy.Telefon_2 = Convert.ToInt32(mtxtTel2.Text);

                dostawcaNowy.Email = txtEmail.Text;

                if (!this.isSupplierValid())
                    return;

                db.Dostawcy_Zaopatrzenie.Add(dostawcaNowy);
                db.SaveChanges();
                MessageBox.Show("Dodano nowego dostawcę.");
            }
        }

        private void chkTel2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTel2.Checked == true)
            {
                lblTelefon2.Enabled = true;
                mtxtTel2.Enabled = true;
            }
            else
            {
                lblTelefon2.Enabled = false;
                mtxtTel2.Enabled = false;
            }
        }

        private void DodajDostawce_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(Dostawcy).Name].Show();
            this.Hide();
        }
    }
}
