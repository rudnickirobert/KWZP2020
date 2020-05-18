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

            //Polki_regaly id = db.Polki_regaly.Where(idRegal => idRegal.ID_Polka == idPolki).FirstOrDefault();
            //Regaly storage = db.Regaly.Where(regal => regal.ID_regal == id.ID_regal).FirstOrDefault();

            vStan_magazynowy_polki content = db.vStan_magazynowy_polki.Where(zawartosc => zawartosc.ID_Polka == idPolki).FirstOrDefault();

            lblTitle.Text = "Półka nr " + content.ID_Polka.ToString() + ", regał: " +content.Oznaczenie;
            lblNazwaElementu.Text = content.Element_Nazwa;
            lblIdElementu.Text = content.ID_Element.ToString();
            lblIloscJednostka.Text = content.Ile.ToString() + ' ' + content.Jednostka;

            if (content.Okres_Przydatnosci_Miesiace != 0)
            {
                DateTime data = Convert.ToDateTime(content.Przydatnosc);
                lblPrzydatnosc.Text = data.ToString("dd.MM.yyyy") + "r.";
            }
            else
            {
                lblPrzydatnosc.Font = new Font(lblPrzydatnosc.Font.FontFamily, 8);
                lblPrzydatnosc.Location = new Point(158,199);
                lblPrzydatnosc.Text = "Nie dotyczy";
            }
        }
    }
}
