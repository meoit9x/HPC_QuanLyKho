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
    
    public partial class dQC
    {
        public dQC()
        {
            this.dQCCTs = new HashSet<dQCCT>();
        }
    
        public int qid { get; set; }
        public string qten { get; set; }
    
        public virtual ICollection<dQCCT> dQCCTs { get; set; }
    }
}
