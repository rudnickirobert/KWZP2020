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
    
    public partial class Polki_regaly
    {
        public int ID_Polki_regaly { get; set; }
        public Nullable<int> ID_regal { get; set; }
        public Nullable<int> ID_Polka { get; set; }
    
        public virtual Polki Polki { get; set; }
        public virtual Regaly Regaly { get; set; }
    }
}