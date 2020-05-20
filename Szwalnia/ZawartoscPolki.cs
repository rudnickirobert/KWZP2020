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

            vStan_magazynowy_polki content = db.vStan_magazynowy_polki.Where(zawartosc => zawartosc.Nr_polki == idPolki).FirstOrDefault();

            lblTitle.Text = "Półka nr " + content.Nr_polki.ToString() + ", regał: " + content.Regal;
            lblNazwaElementu.Text = content.Nazwa_elementu;
            lblIdElementu.Text = content.Nr_elementu.ToString();
            lblIloscJednostka.Text = content.Ile.ToString();
            lblPrzydatnosc.Text = content.Przydatnosc;

            if (content.Przydatnosc == "Nie dotyczy")
            {
                lblPrzydatnosc.Font = new Font(lblPrzydatnosc.Font.FontFamily, 8);
                lblPrzydatnosc.Location = new Point(158, 199);
            }
        }
    }
}
