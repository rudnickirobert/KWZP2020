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
    
    public partial class vOferta
    {
        public Nullable<int> ID_Element { get; set; }
        public int ID_Oferta { get; set; }
        public int ID_Dostawcy { get; set; }
        public string Element_Oznaczenie { get; set; }
        public Nullable<decimal> Cena_Jedn { get; set; }
        public Nullable<float> Ilosc_W_Opakowaniu_Pojedynczym { get; set; }
        public Nullable<int> Deklarowany_czas_dostawy { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> Ilosc_Minimalna { get; set; }
        public Nullable<int> Ilosc_Maksymalna { get; set; }
        public Nullable<int> Telefon_1 { get; set; }
    }
}
