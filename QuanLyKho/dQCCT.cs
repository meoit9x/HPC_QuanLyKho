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
    
    public partial class dQCCT
    {
        public int cqid { get; set; }
        public Nullable<int> qid { get; set; }
        public Nullable<int> vid { get; set; }
        public string qthongso { get; set; }
        public Nullable<int> dvtid { get; set; }
    
        public virtual dDVT dDVT { get; set; }
        public virtual dQC dQC { get; set; }
        public virtual dVT dVT { get; set; }
    }
}
