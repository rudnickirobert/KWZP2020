using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class PopupAcceptDeny : Form
    {
        public SzwalniaEntities db;
        Dostawcy_Zaopatrzenie dostawcaWybrany = new Dostawcy_Zaopatrzenie();
        public PopupAcceptDeny(int intIDDostawcy)
        {
            InitializeComponent();
            db = Start.szwalnia;
            dostawcaWybrany = db.Dostawcy_Zaopatrzenie.Where(wybrany => wybrany.ID_Dostawcy == intIDDostawcy).First();
            lblInfo.Text = "Czy na pewno chcesz wybrać ofertę " + dostawcaWybrany.Nazwa + " ?";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //akcja zapisz dostawce
            WyborOferty.czyZamknietyPrzezInny = true;
            Application.OpenForms["WyborOferty"].Close();
            DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(!db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any());
            formularzDodawanieDostaw.Show();
            this.Close();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            //akcja powrot
            Application.OpenForms["WyborOferty"].Show();
            this.Close();
            
        }
        
    }
}
