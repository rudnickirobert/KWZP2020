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
    
    public partial class Proces_Zamowienie
    {
        public int ID_Proces_Zamowienie { get; set; }
        public int ID_Proces_Technologiczny { get; set; }
        public int ID_Zamowienie_Element { get; set; }
        public Nullable<bool> Kompletny_Proces { get; set; }
    
        public virtual Proces_Technologiczny Proces_Technologiczny { get; set; }
        public virtual Zamowienie_Element Zamowienie_Element { get; set; }
    }
}
