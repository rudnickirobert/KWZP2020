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
    public partial class WyborElementu : Form
    {
        public SzwalniaEntities db;

        public WyborElementu(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (numID.Value > 0)
            {
                lblError.Text = "";
                ElementSzczegoly Szczegoly_element = new ElementSzczegoly(db, Decimal.ToInt32(numID.Value));
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
