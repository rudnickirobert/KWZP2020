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
        public SzwalniaEntities szwalnia;
        public Start()
        {
            InitializeComponent();
            szwalnia = new SzwalniaEntities();
        }

        private void btnMagazyn_Click(object sender, EventArgs e)
        {
            MagazynForm magForm = new MagazynForm(szwalnia);
            magForm.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void btnRealizacjaProcesu_Click(object sender, EventArgs e)
        {
            Realizacja_procesu_szczegoly real_proc = new Realizacja_procesu_szczegoly(szwalnia);
            real_proc.Show();
        }
    }
}
