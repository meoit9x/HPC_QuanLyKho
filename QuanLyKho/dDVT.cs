//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho
{
    using System;
    using System.Collections.Generic;
    
    public partial class dDVT
    {
        public dDVT()
        {
            this.dQCCT = new HashSet<dQCCT>();
            this.dVT1 = new HashSet<dVT>();
            this.pNCT = new HashSet<pNCT>();
            this.pSDCT = new HashSet<pSDCT>();
        }
    
        public int dvtid { get; set; }
        public string dvt { get; set; }
    
        public virtual ICollection<dQCCT> dQCCT { get; set; }
        public virtual ICollection<dVT> dVT1 { get; set; }
        public virtual ICollection<pNCT> pNCT { get; set; }
        public virtual ICollection<pSDCT> pSDCT { get; set; }
    }
}
