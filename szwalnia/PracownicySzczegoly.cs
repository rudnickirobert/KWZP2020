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
    public partial class PracownicySzczegoly : Form
    {
        public PracownicySzczegoly( SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            Pracownicy pracownicy = db.Pracownicy.Where(wybrane => wybrane.ID_Pracownika == ID).First();
            lblTitle.Text = "Dane pracownika o ID: " + pracownicy.ID_Pracownika;
            txtImie.Text = pracownicy.Imie;
            txtNazwisko.Text = pracownicy.Nazwisko;
            txtTelefonPracownika.Text = pracownicy.Telefon;
        }
    }
}
