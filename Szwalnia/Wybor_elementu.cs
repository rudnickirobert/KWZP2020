using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class Wybor_elementu : Form
    {
        public SzwalniaEntities szwalnia_passed;

        public Wybor_elementu(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            szwalnia_passed = szwalnia;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (numID.Value > 0)
            {
                lblError.Text = "";
                Element_szczegoly Szczegoly_element = new Element_szczegoly(szwalnia_passed, Decimal.ToInt32(numID.Value));
                Szczegoly_element.Show();
                this.Close();
            }
            else
            {
                lblError.Text = "Bledne ID";
            }                
        }
    }
}
