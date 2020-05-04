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
    
    public partial class Start : Form 
    {
        public SzwalniaEntities Szwalnia;
        public Start()
        {
            InitializeComponent();
            Szwalnia = new SzwalniaEntities();
        }

        private void btnMagazyn_Click(object sender, EventArgs e)
        {
            MagazynForm MagForm = new MagazynForm(Szwalnia);
            MagForm.Show();
        }
    }
}
