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
    
    public partial class duser
    {
        public int uid { get; set; }
        public string uname { get; set; }
        public string uuser { get; set; }
        public string upass { get; set; }
        public Nullable<int> kid { get; set; }
        public Nullable<int> position { get; set; }
    
        public virtual dK dK { get; set; }
    }
}
