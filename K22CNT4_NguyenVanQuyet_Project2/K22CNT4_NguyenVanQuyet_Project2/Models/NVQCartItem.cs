using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNT4_NguyenVanQuyet_Project2.Models
{
    public class NVQCartItem
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string HinhAnh {  get; set; }    
        public int SoLuongMua { get; set; }
        public float DonGiaMua {  get; set; }
        public float ThanhTien {  get; set; }
    }
}