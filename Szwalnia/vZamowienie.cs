//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szwalnia
{
    using System;
    using System.Collections.Generic;
    
    public partial class vZamowienie
    {
        public int ID_Zamowienia { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Nazwa_Firmy { get; set; }
        public Nullable<System.DateTime> Data_Zlozenia { get; set; }
        public Nullable<System.DateTime> Data_Zakonczenia { get; set; }
        public Nullable<bool> Umowa { get; set; }
        public int ID_Pracownika { get; set; }
        public string Imie_Pracownika { get; set; }
        public string Nazwisko_Pracownika { get; set; }
    }
}
