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
    
    public partial class vPrzydzialZasobowEtap
    {
        public int ID_procesu_produkcyjnego { get; set; }
        public int ID_realizacji_procesu { get; set; }
        public string Nazwa_etapu { get; set; }
        public string ID_Pracownika__Imię__Nazwisko { get; set; }
        public string ID_Maszyny__Nazwa { get; set; }
        public Nullable<System.DateTime> Data_rozpoczęcia { get; set; }
        public Nullable<System.DateTime> Data_zakończenia { get; set; }
    }
}
