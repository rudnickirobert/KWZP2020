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
    
    public partial class vKlienciZamowienie
    {
        public int ID_Klienta { get; set; }
        public int ID_Zamowienia { get; set; }
        public string Element_Nazwa { get; set; }
        public int Ilosc { get; set; }
        public Nullable<System.DateTime> Data_Zlozenia { get; set; }
        public Nullable<System.DateTime> Data_Zakonczenia { get; set; }
    }
}