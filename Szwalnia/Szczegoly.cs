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
    public partial class Szczegoly : Form
    {
        public Szczegoly(SzwalniaEntities db, int sourcesidPP)
        {
            InitializeComponent();
            lblID.Text = sourcesidPP.ToString();
            Przydzial_Zasobow sources = db.Przydzial_Zasobow.Where(przydzial => przydzial.ID_Realizacji_Procesu == sourcesidPP).First();

            dvg.DataSource = db.v_PrzydzialZasobow.Where(view => view.ID_Realizacji_Procesu == sources.ID_Realizacji_Procesu).ToList();
        }

        private void Szczegoly_Load(object sender, EventArgs e)
        {

        }
    }
}
