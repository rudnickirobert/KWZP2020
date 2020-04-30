using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class FORM_Faktury_Zewnetrzne_Przekazanie : Form
    {
        public SzwalniaEntities db;
        public FORM_Faktury_Zewnetrzne_Przekazanie(SzwalniaEntities db)
        {
            InitializeComponent();
        }

        private void LBL_NP_Click(object sender, EventArgs e)
        {

        }

        private void FORM_Faktury_Zewnetrzne_Przekazanie_Load(object sender, EventArgs e)
        {

        }

       private void BUTTON_MouseClick(object sender, MouseEventArgs e)
        {
            FORM_Faktury_Zewnetrzne FORM_Faktury_Zewnetrzne = new FORM_Faktury_Zewnetrzne(db,TXTBOX1.Text);
            FORM_Faktury_Zewnetrzne.Show();
        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
