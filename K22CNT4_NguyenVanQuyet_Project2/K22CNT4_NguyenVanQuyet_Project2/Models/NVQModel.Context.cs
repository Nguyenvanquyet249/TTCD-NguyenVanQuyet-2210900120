﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NVQDbEntities : DbContext
    {
        public NVQDbEntities()
            : base("name=NVQDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chi_Tiet_Don_Hang> Chi_Tiet_Don_Hang { get; set; }
        public virtual DbSet<Danh_Gia> Danh_Gia { get; set; }
        public virtual DbSet<Danh_Muc> Danh_Muc { get; set; }
        public virtual DbSet<Don_Hang> Don_Hang { get; set; }
        public virtual DbSet<Hang_San_Xuat> Hang_San_Xuat { get; set; }
        public virtual DbSet<Nguoi_Dung> Nguoi_Dung { get; set; }
        public virtual DbSet<San_Pham> San_Pham { get; set; }
        public virtual DbSet<Thanh_Toan> Thanh_Toan { get; set; }
        public virtual DbSet<Yeu_Thich> Yeu_Thich { get; set; }

        public System.Data.Entity.DbSet<K22CNT4_NguyenVanQuyet_Project2.Models.NVQCartItem> NVQCartItems { get; set; }
    }
}