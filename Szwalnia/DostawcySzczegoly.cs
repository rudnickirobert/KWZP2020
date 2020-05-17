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
    public partial class DostawcySzczegoly : Form
    {
        public SzwalniaEntities db;
        public DostawcySzczegoly(SzwalniaEntities szwalnia, int ID)
        {
            db = szwalnia;
            InitializeComponent();
            Dostawcy_Zaopatrzenie dostawca = szwalnia.Dostawcy_Zaopatrzenie.Where(wybrany => wybrany.ID_Dostawcy == ID).First();
            txtNazwa.Text = dostawca.Nazwa;
            txtTel1.Text = dostawca.Telefon_1.ToString();
            txtTel2.Text = dostawca.Telefon_2.ToString();
            txtEmail.Text = dostawca.Email;
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Dostawcy"].Show();
            this.Hide();
        }

        private void DostawcySzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
