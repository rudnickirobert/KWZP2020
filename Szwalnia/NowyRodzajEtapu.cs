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
    public partial class NowyRodzajEtapu : Form
    {
        public SzwalniaEntities db;
        public NowyRodzajEtapu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
    }
}
