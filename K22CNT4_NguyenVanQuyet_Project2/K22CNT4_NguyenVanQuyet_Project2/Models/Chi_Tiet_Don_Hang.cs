//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K22CNT4_NguyenVanQuyet_Project2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chi_Tiet_Don_Hang
    {
        public int id_don_hang { get; set; }
        public int id_san_pham { get; set; }
        public int so_luong { get; set; }
        public decimal don_gia { get; set; }
    
        public virtual Don_Hang Don_Hang { get; set; }
        public virtual San_Pham San_Pham { get; set; }
    }
}
