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
    public partial class Element_szczegoly : Form
    {
        public Element_szczegoly(SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            Elementy element = db.Elementy.Where(wybrany => wybrany.ID_Element == ID).First();
            lblElement.Text = "Szczegoly elementu o ID: " + element.ID_Element;
        }

        private void Element_szczegoly_Load(object sender, EventArgs e)
        {

        }
    }
}
