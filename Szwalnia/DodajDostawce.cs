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
        public DodajDostawce(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
            label4.Enabled = false;
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
                
                db.Dostawcy_Zaopatrzenie.Add(dostawcaNowy);
                db.SaveChanges();
                MessageBox.Show("Dodano nowego dostawcę.");

            }
        }

        private void chkTel2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTel2.Checked == false)
            {
                label4.Enabled = false;
                mtxtTel2.Enabled = false;
            }
            else
            {
                label4.Enabled = true;
                mtxtTel2.Enabled = true;
            }
        }
    }
}
