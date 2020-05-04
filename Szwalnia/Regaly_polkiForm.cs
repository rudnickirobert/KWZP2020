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
    public partial class Regaly_polkiForm : Form
    {
        public SzwalniaEntities szwalnia_passed;
        public Regaly_polkiForm(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            szwalnia_passed = szwalnia;
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zapelnienie_regalu regal = new Zapelnienie_regalu(szwalnia_passed, textBox2.Text);
            regal.Show();
            this.Close();
        }
    }
}
