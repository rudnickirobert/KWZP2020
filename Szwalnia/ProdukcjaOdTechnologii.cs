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
    public partial class ProdukcjaOdTechnologii : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        public ProdukcjaOdTechnologii(SzwalniaEntities db, int idProcesu )
        {
            InitializeComponent();
            this.db = db;
            lblOpis.Text = "Technologia do procesu produkcyjnego o ID " + idProcesu;

            dgvPotrzebnyMaterialDoProcesuProdukcyjnego.DataSource = this.db.vPotrzebnyMaterialDoProcesuProdukcyjnego.Where(nun => nun.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            dgvPotrzebnyMaterialDoProcesuProdukcyjnego.Columns[0].Visible = false;
            dgvPotrzebnyMaterialDoProcesuProdukcyjnego.Columns[1].HeaderText = "ID elementu";
            dgvPotrzebnyMaterialDoProcesuProdukcyjnego.Columns[2].HeaderText = "Nazwa elementu";
            dgvPotrzebnyMaterialDoProcesuProdukcyjnego.Columns[3].HeaderText = "Liczba";
            dgvPotrzebnyMaterialDoProcesuProdukcyjnego.Columns[4].HeaderText = "Jednostka";

            dgvPotrzebneEtapyDoProcesuProdukcyjnego.DataSource = this.db.vPotrzebneEtapyDoProcesuProdukcyjnego.Where(nun => nun.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            dgvPotrzebneEtapyDoProcesuProdukcyjnego.Columns[0].Visible = false;
            dgvPotrzebneEtapyDoProcesuProdukcyjnego.Columns[1].HeaderText = "Etap";
            dgvPotrzebneEtapyDoProcesuProdukcyjnego.Columns[2].HeaderText = "Czas trwania [h]";
            dgvPotrzebneEtapyDoProcesuProdukcyjnego.Columns[1].Width = 140;

            dgvPotrzebneMaszynyDoProcesuProdukcyjnego.DataSource = this.db.vPotrzebneMaszynyDoProcesuProdukcyjnego.Where(nun => nun.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            dgvPotrzebneMaszynyDoProcesuProdukcyjnego.Columns[0].Visible = false;
            dgvPotrzebneMaszynyDoProcesuProdukcyjnego.Columns[1].HeaderText = "Rodzaj";
            dgvPotrzebneMaszynyDoProcesuProdukcyjnego.Columns[2].HeaderText = "Liczba";
            dgvPotrzebneMaszynyDoProcesuProdukcyjnego.Columns[1].Width = 140;

            dgvPotrzebnaDokumentacjaDoProcesuProdukcyjnego.DataSource = this.db.vPotrzebnaDokumentacjaDoProcesuProdukcyjnego.Where(nun => nun.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            dgvPotrzebnaDokumentacjaDoProcesuProdukcyjnego.Columns[0].Visible = false;
            dgvPotrzebnaDokumentacjaDoProcesuProdukcyjnego.Columns[1].HeaderText = "ID Dokumentacji";
            dgvPotrzebnaDokumentacjaDoProcesuProdukcyjnego.Columns[2].HeaderText = "Rodzaj";

            
            dgvUkryty.DataSource = this.db.vKompletnyProces.Where(proces => proces.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            bool gotowe = Convert.ToBoolean(dgvUkryty.Rows[0].Cells[2].Value);
            
            if ( gotowe == true)
            {
                lblGotowe.Text = "Status: Technologia jest kompletna";
            }
            else
            { 
                lblGotowe.Text = "Status: Technologia nie jest kompletna";
            }
          
        }

        
    }
}
