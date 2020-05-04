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
            Oferta oferta = szwalnia.Elementy.Where(wybrany => wybrany.ID_Element == ID_Elementu);
            Elementy element = szwalnia.Elementy.Where(wybrany => wybrany.ID_Element == ID_Elementu).First();
            Dostawcy_Zaopatrzenie dostawcy = szwalnia.Elementy.Where(wybrany => wybrany.ID_Oferta == oferta.ID_Oferta).First();
            lblMain.Text = "Szczegoly oferty dla ementu o ID: " + element.ID_Element;
            txt1.Text = element.Element_Nazwa;
            txt2.Text = oferta.Element_Oznaczenie;
            txt3.Text = dostawcy.Nazwa;
            txt4.Text = oferta.Cena_Jedn.ToString();
            txt5.Text = oferta.Ilosc_Minimalna.ToString();
            txt6.Text = oferta.Ilosc_Maksymalna.ToString();
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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.Oferta' . Możesz go przenieść lub usunąć.
            this.ofertaTableAdapter.Fill(this.szwalniaDataSet.Oferta);

        }
    }
}
