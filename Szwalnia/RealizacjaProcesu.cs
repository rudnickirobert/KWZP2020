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
    public partial class RealizacjaProcesu : Form
    {
        public SzwalniaEntities db;
        public RealizacjaProcesu(SzwalniaEntities db,int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == IdProcesu).First();
            lblProces.Text = "Realizacja procesu dla procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
            dgvRealizacjaProcesu.DataSource = db.vRealizacjaProcesuProdukcyjnegoDetails.Where(realizacja => realizacja.ID_Procesu_Produkcyjnego == proces.ID_Procesu_Produkcyjnego).ToList();
            dgvRealizacjaProcesu.Columns[1].Visible = false;
        }

    }
}
