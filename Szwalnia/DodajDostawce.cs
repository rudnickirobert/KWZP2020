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
            lblTelefon2.Enabled = false;
            mtxtTel2.Enabled = false;
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
                {
                    dostawcaNowy.Telefon_2 = Convert.ToInt32(mtxtTel2.Text);
                }
                dostawcaNowy.Email = txtEmail.Text;

                if(!db.Dostawcy_Zaopatrzenie.Where(dostawca => dostawca.Nazwa == txtNazwa.Text).Any())
                {
                    if (!db.Dostawcy_Zaopatrzenie.Where(dostawca => dostawca.Telefon_1 == dostawcaNowy.Telefon_1).Any())
                    {
                        if (!db.Dostawcy_Zaopatrzenie.Where(dostawca => dostawca.Email == txtEmail.Text).Any())
                        {
                            db.Dostawcy_Zaopatrzenie.Add(dostawcaNowy);
                            db.SaveChanges();
                            MessageBox.Show("Dodano nowego dostawcę.");
                        }
                        else
                        {
                            MessageBox.Show("Dostawca z takim adresem e-mail już istnieje.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dostawca z takim numerem telefonu już istnieje.");
                    }
                }
                else
                {
                    MessageBox.Show("Dostawca o takiej nazwie już istnieje");
                }

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
