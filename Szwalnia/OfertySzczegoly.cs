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
            //vOferty_Zebrane oferta = szwalnia.Elementy.Where(wybrany => wybrany.ID_Element == ID).First();
            //txtElement.Text = "Szczegoly elementu o ID: " + element.ID_Element;
            //txtNazwa.Text = oferta.Element_Nazwa;

        }
    }
}
