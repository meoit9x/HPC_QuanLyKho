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
    
    public partial class pCCT
    {
        public int cctid { get; set; }
        public Nullable<int> vid { get; set; }
        public Nullable<double> cctsoluong { get; set; }
        public Nullable<int> cid { get; set; }
        public string diengiai { get; set; }
        public Nullable<int> accept { get; set; }
        public Nullable<double> dongia { get; set; }
    
        public virtual dVT dVT { get; set; }
        public virtual pC pC { get; set; }
    }
}
