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
    
    public partial class vWolneMaszyny
    {
        public int ID_Maszyny { get; set; }
        public string Maszyna { get; set; }
        public Nullable<int> ID_Środki_Trwałe { get; set; }
        public Nullable<System.DateTime> Data_Zakończenia { get; set; }
        public Nullable<System.DateTime> Data_Rozpoczęcia_ { get; set; }
        public Nullable<System.DateTime> Data_Rozpoczęcia_Naprawy_Serwisu { get; set; }
        public Nullable<System.DateTime> Data_Zakończenia_Naprawy_Serwisu { get; set; }
    }
}