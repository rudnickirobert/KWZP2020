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
    
    public partial class vOferty_Zebrane
    {
        public int ID_Oferta { get; set; }
        public string Element_Nazwa { get; set; }
        public string Element_Oznaczenie { get; set; }
        public string Nazwa { get; set; }
        public Nullable<decimal> Cena_Jedn { get; set; }
        public Nullable<System.DateTime> Data_Oferty { get; set; }
        public Nullable<int> Ilosc_Minimalna { get; set; }
        public Nullable<int> Ilosc_Maksymalna { get; set; }
        public Nullable<float> Ilosc_W_Opakowaniu_Pojedynczym { get; set; }
        public string Jednostka { get; set; }
        public Nullable<int> Ilosc_W_Opakowaniu_Zbiorczym { get; set; }
        public Nullable<int> Deklarowany_czas_dostawy { get; set; }
    }
}
