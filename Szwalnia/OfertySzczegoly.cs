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
    public partial class OfertySzczegoly : Form
    {
        public SzwalniaEntities db;
        public OfertySzczegoly(SzwalniaEntities szwalnia, int ID)
        {
            db = szwalnia;
            InitializeComponent();
            vOferty_Zebrane oferta = szwalnia.vOferty_Zebrane.Where(wybrany => wybrany.ID_Oferta == ID).First();
            txtElement.Text = oferta.Element_Nazwa;
            txtOznacz.Text = oferta.Element_Oznaczenie;
            txtDostawca.Text = oferta.Nazwa;
            txtCenaJedn.Text = oferta.Cena_Jedn.ToString();
            txtData.Text = oferta.Data_Oferty.ToString();
            txtIloscMin.Text = oferta.Ilosc_Minimalna.ToString();
            txtIloscMax.Text = oferta.Ilosc_Maksymalna.ToString();
            txtIloscPoj.Text = oferta.Ilosc_W_Opakowaniu_Pojedynczym.ToString();
            txtJednostka.Text = oferta.Jednostka;
            txtIloscZbiorcza.Text = oferta.Ilosc_W_Opakowaniu_Zbiorczym.ToString();
            txtData.Text = oferta.Data_Oferty.ToString();
        }

        private void OfertySzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Oferty"].Show();
            this.Hide();
        }
    }
}
