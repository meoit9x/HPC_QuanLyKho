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
    
    public partial class pTB
    {
        public int tbid { get; set; }
        public string diengiai { get; set; }
        public Nullable<int> accept { get; set; }
        public Nullable<int> kid { get; set; }
        public string tacvu { get; set; }
    
        public virtual dK dK { get; set; }
    }
}
