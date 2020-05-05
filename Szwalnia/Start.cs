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
            MagazynForm magazynForm = new MagazynForm(szwalnia);
            magazynForm.Show();
        }

        private void btnRealizacjaProcesu_Click(object sender, EventArgs e)
        {
            RealizacjaProcesuSzczegoly realizacjaProcesu = new RealizacjaProcesuSzczegoly(szwalnia);
            realizacjaProcesu.Show();
        }

        private void btnZarzadzanie_MouseClick(object sender, MouseEventArgs e)
        {
            ZarzadzanieForm zarzadzanieForm = new ZarzadzanieForm(szwalnia);
            zarzadzanieForm.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
