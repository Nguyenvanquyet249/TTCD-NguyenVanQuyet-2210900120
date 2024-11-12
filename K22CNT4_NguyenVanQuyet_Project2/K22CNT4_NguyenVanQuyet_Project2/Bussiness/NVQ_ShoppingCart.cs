using K22CNT4_NguyenVanQuyet_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K22CNT4_NguyenVanQuyet_Project2.Bussiness
{
    public class NVQ_ShoppingCart
    {
        public List<NVQCartItem> Items { get; set; }
        public NVQ_ShoppingCart()
        {
            Items = new List<NVQCartItem>();
        }
        public void AddToCart(NVQCartItem item)
        {
            var existingItem = Items.FirstOrDefault(x => x.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.SoLuongMua += item.SoLuongMua;
            }
            else
            {
                Items.Add(item);
            }
        }
        public void RemoveCartItem(int id)
        {
            var itemToRemove = Items.FirstOrDefault(x=>x.Id == id);
            if(itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }
        public float GetTongThanhTien()
        {
            return Items.Sum(x => x.SoLuongMua * x.DonGiaMua);
        }
    }
}