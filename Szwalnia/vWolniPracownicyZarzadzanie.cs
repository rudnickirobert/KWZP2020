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
    
    public partial class vWolniPracownicyZarzadzanie
    {
        public Nullable<int> ID_Pracownika { get; set; }
        public string Pracownik { get; set; }
        public string ID_Działu__Nazwa { get; set; }
        public Nullable<System.DateTime> Data_Rozpoczęcia_Urlopu { get; set; }
        public Nullable<System.DateTime> Data_Zakończenia_Urlopu { get; set; }
        public Nullable<System.DateTime> Data_Rozpoczęcia { get; set; }
        public Nullable<System.DateTime> Data_Zakończenia { get; set; }
        public string ID_Stanowiska__Nazwa_Stanowiska { get; set; }
        public System.DateTime Data_Zatrudnienia { get; set; }
        public System.DateTime Koniec_umowy { get; set; }
    }
}
