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

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btnRealProc_Click(object sender, EventArgs e)
        {
            Realizacja_proc_szcz real_proc = new Realizacja_proc_szcz(db);
            real_proc.Show();
        }
    }
}
