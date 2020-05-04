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
    public partial class Suma_Czasu_Pokaz : Form
    {
        private SzwalniaEntities db;
        public Suma_Czasu_Pokaz()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
            dgv_Suma_Czas.DataSource = db.vSuma_Czasu_Proces.ToList();
        }

        private void Suma_Czasu_Pokaz_Load(object sender, EventArgs e)
        {

        }
    }
}
