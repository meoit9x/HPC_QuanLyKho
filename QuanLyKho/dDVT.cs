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
            this.dQCCTs = new HashSet<dQCCT>();
            this.dVTs = new HashSet<dVT>();
            this.pNCTs = new HashSet<pNCT>();
            this.pSDCTs = new HashSet<pSDCT>();
        }
    
        public int dvtid { get; set; }
        public string dvt { get; set; }
    
        public virtual ICollection<dQCCT> dQCCTs { get; set; }
        public virtual ICollection<dVT> dVTs { get; set; }
        public virtual ICollection<pNCT> pNCTs { get; set; }
        public virtual ICollection<pSDCT> pSDCTs { get; set; }
    }
}
