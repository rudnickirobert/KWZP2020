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
    
    public partial class Dokumentacja_Proces
    {
        public int ID_Dokumentacja_Proces { get; set; }
        public int ID_Dokumentacji { get; set; }
        public int ID_Proces_Technologiczny { get; set; }
    
        public virtual Dokumentacje Dokumentacje { get; set; }
        public virtual Proces_Technologiczny Proces_Technologiczny { get; set; }
    }
}
