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
    public partial class Informacje_o_zatrudnieniu : Form
    {
        public SzwalniaEntities db;
        public Informacje_o_zatrudnieniu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
