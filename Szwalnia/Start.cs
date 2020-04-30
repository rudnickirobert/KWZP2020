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
        public SzwalniaEntities db;
        public Start()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
        }

        private void btnElementy_Click(object sender, EventArgs e)
        {
            Wybor_elementu wybor = new Wybor_elementu(db);
            wybor.Show();
        }

        private void btnKlienci_Click(object sender, EventArgs e)
        {

        }

        private void btnFakturyZewnetrzne_MouseClick(object sender, MouseEventArgs e)
        {

            FORM_Faktury_Zewnetrzne_Przekazanie FORM_Faktury_Zewnetrzne_Przekazanie = new FORM_Faktury_Zewnetrzne_Przekazanie(db);
            FORM_Faktury_Zewnetrzne_Przekazanie.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
