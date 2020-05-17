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
    public partial class ZawartoscPolki : Form
    {
        public SzwalniaEntities db;
        public ZawartoscPolki(int idPolki)
        {
            InitializeComponent();
            db = Start.szwalnia;
        }
    }
}
