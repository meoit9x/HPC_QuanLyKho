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
    
    public partial class pTon
    {
        public int id { get; set; }
        public Nullable<int> vid { get; set; }
        public Nullable<double> soluong { get; set; }
        public Nullable<double> dongia { get; set; }
        public Nullable<int> kid { get; set; }
        public string trangthai { get; set; }
    
        public virtual dK dK { get; set; }
        public virtual dVT dVT { get; set; }
    }
}
