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
    
    public partial class vSrodkiZamortyzowane
    {
        public int ID_Srodki_trwale { get; set; }
        public string Nazwa { get; set; }
        public string Producent { get; set; }
        public string Numer_seryjny { get; set; }
        public string Koszt_zakupu { get; set; }
        public string Roczny_stopien_amortyzacji { get; set; }
        public bool Zamortyzowane { get; set; }
    }
}
