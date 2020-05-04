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
    public partial class Oferty_szczegoly : Form
    {
        public Oferty_szczegoly(SzwalniaEntities szwalnia, int ID_Elementu)
        {
            InitializeComponent();
            Oferta oferta = szwalnia.Oferta.Where(wybrany => wybrany.ID_Element == ID_Elementu).First();
            Elementy element = szwalnia.Elementy.Where(wybrany => wybrany.ID_Element == ID_Elementu).First();
            Dostawcy_Zaopatrzenie dostawcy = szwalnia.Dostawcy_Zaopatrzenie.Where(wybrany => wybrany.ID_Dostawcy== oferta.ID_Dostawcy).First();
            Elementy_Jednostki jednostki = szwalnia.Elementy_Jednostki.Where(wybrany => wybrany.ID_Jednostka == oferta.ID_Jednostka).First();
            lblMain.Text = "Szczegoly oferty dla ementu o ID: " + element.ID_Element;
            txt1.Text = element.Element_Nazwa;
            txt2.Text = oferta.Element_Oznaczenie;
            txt3.Text = dostawcy.Nazwa;
            txt4.Text = oferta.Cena_Jedn.ToString();
            txt5.Text = oferta.Ilosc_Minimalna.ToString();
            txt6.Text = oferta.Ilosc_Maksymalna.ToString();
            txt7.Text = oferta.Ilosc_W_Opakowaniu_Pojedynczym.ToString();
            txt8.Text = jednostki.Jednostka;
            txt9.Text = oferta.Ilosc_W_Opakowaniu_Zbiorczym.ToString();
            txt10.Text = oferta.Deklarowany_czas_dostawy.ToString();
            txt11.Text = oferta.Data_Oferty.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Oferty_szczegoly_Load(object sender, EventArgs e)
        {
            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
