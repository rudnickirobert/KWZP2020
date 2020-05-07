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
    public partial class KontrolaEfektywnosciFormSzczegoly : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public KontrolaEfektywnosciFormSzczegoly(SzwalniaEntities db, int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu;
            Kontrola_Efektywnosci NumerProcesu = db.Kontrola_Efektywnosci.Where(IDProcesu => IDProcesu.ID_Procesu_Produkcyjnego == IdProcesu).First();
            txtNumerProcesu.Text = NumerProcesu.ID_Procesu_Produkcyjnego.ToString();
            txtDataKontroli.Text = NumerProcesu.Data_Kontroli.ToLongDateString();
            txtLiczbaPoprawnych.Text = NumerProcesu.Liczba_Poprawnych.ToString();
            txtUwagiDoKontroli.Text = NumerProcesu.Uwagi.ToString();
            chkZgodnosc.Checked = NumerProcesu.Zgodnosc_Zamowienia.GetValueOrDefault();
        }
    }
}
