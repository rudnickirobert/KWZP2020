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
    public partial class PanelJezykow : Form
    {
        public SzwalniaEntities db;
        public PanelJezykow(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            DodajNowyJezyk dodajNowyJezyk = new DodajNowyJezyk(db);
            dodajNowyJezyk.Show();

        }

        private void btnZnajomosc_Click(object sender, EventArgs e)
        {
            ZnajomoscJezykowWFirmie znajomoscJezykowWFirmie = new ZnajomoscJezykowWFirmie(db);
            znajomoscJezykowWFirmie.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
