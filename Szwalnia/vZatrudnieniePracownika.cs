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
    
    public partial class vZatrudnieniePracownika
    {
        public int ID_Pracownika { get; set; }
        public string Stanowisko { get; set; }
        public System.DateTime Data_Zatrudnienia { get; set; }
        public System.DateTime Koniec_umowy { get; set; }
        public string Rodzaj_Umowy { get; set; }
        public float Wymiar_Etatu { get; set; }
        public float Pensja { get; set; }
    }
}
