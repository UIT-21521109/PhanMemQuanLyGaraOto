//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhanMemQuanLyGaraOto.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BAOCAOTON
    {
        public System.DateTime THANGNAM { get; set; }
        public int MAPHUTUNG { get; set; }
        public Nullable<int> TONDAU { get; set; }
        public Nullable<int> SLNHAP { get; set; }
        public Nullable<int> SLBAN { get; set; }
        public Nullable<int> TONCUOI { get; set; }
    
        public virtual PHUTUNG PHUTUNG { get; set; }
    }
}
