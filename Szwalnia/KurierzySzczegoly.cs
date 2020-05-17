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
    public partial class KurierzySzczegoly : Form
    {
        public SzwalniaEntities db;
        public KurierzySzczegoly(SzwalniaEntities szwalnia, int ID)
        {
            db = szwalnia;
            InitializeComponent();
            Kurierzy kurier = szwalnia.Kurierzy.Where(wybrany => wybrany.ID_Kurier == ID).First();
            txtNazwa.Text = kurier.Nazwa;
            txtTel1.Text = kurier.Telefon_1.ToString();
            txtTel2.Text = kurier.Telefon_2.ToString();
            txtEmail.Text = kurier.Email;
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["KurierzyLista"].Show();
            this.Hide();
        }

        private void KurierzySzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
