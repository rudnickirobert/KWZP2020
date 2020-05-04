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
    public partial class lblNazwa : Form
    {
        public lblNazwa(SzwalniaEntities szwalnia, int ID)
        {
            InitializeComponent();
            Kurierzy kurier = szwalnia.Kurierzy.Where(wybrany => wybrany.ID_Kurier == ID).First();
            lbl1.Text = "Szczegoly kuriera o ID: " + kurier.ID_Kurier;
            txtNazwa.Text = kurier.Nazwa;
            txtTel1.Text = kurier.Telefon_1.ToString();
            txtTel2.Text = kurier.Telefon_2.ToString();
            txtEmail.Text = kurier.Email;

        }
    }
}
