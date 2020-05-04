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
        public Szczegoly(SzwalniaEntities db, int sourcesIdProcesuProdukcyjnego)
        {
            InitializeComponent();
            lblId.Text = sourcesIdProcesuProdukcyjnego.ToString();
            Realizacja_Procesu sources = db.Realizacja_Procesu.Where(przydzial => przydzial.ID_Procesu_Produkcyjnego == sourcesIdProcesuProdukcyjnego).First();

            dgvPrzydzialZasobow.DataSource = db.v_Przydzial_Zasobow.Where(view => view.ID_Procesu_Produkcyjnego == sources.ID_Procesu_Produkcyjnego).ToList();
            dgvPrzydzialZasobow.Columns[0].Visible = false;
        }
    }
}
