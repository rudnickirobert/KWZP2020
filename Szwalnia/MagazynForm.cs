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
    public partial class MagazynForm : Form
    {
        public SzwalniaEntities Szwalnia;
        public MagazynForm(SzwalniaEntities przekazane)
        {
            Szwalnia = przekazane;
            InitializeComponent();
        }

        private void btnElementyForm_Click(object sender, EventArgs e)
        {
            Wybor_elementu wybor = new Wybor_elementu(Szwalnia);
            wybor.Show();
            this.Close();
        }

 
    }
}
