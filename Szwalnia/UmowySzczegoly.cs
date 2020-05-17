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
    public partial class UmowySzczegoly : Form
    {
        public SzwalniaEntities db;
        public UmowySzczegoly(SzwalniaEntities szwalnia, int ID)
        {
            db = szwalnia;
            InitializeComponent();
            Umowy_Kurierzy umowa = szwalnia.Umowy_Kurierzy.Where(wybrany => wybrany.ID_Umowy == ID).First();
            txtNazwa.Text = umowa.ID_Kurier.ToString(); //arghhh
            txtData.Text = umowa.Data_Zawarcia.ToString();
            txtCzas.Text = umowa.Czas_Dostawy.ToString();
            txtKosztKm.Text = umowa.Koszt_Km.ToString();
            txtKosztStaly.Text = umowa.Koszt_Staly.ToString();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["UmowyKurierzy"].Show();
            this.Hide();
        }

        private void UmowySzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
