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
    
    public partial class Kontrola_Efektywnosci
    {
        public int ID_Kontrola_Efektywnosci { get; set; }
        public int ID_Procesu_Produkcyjnego { get; set; }
        public Nullable<System.DateTime> Data_Kontroli { get; set; }
        public string Uwagi { get; set; }
        public Nullable<int> Liczba_Poprawnych { get; set; }
    
        public virtual Proces_Produkcyjny Proces_Produkcyjny { get; set; }
    }
}
