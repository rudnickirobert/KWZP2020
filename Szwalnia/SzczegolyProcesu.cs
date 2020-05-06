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
    public partial class SzczegolyProcesu : Form
    {
        public SzwalniaEntities db;
        public SzczegolyProcesu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
    }
}
