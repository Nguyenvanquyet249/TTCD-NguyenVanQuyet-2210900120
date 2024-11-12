using K22CNT4_NguyenVanQuyet_Project2.Bussiness;
using K22CNT4_NguyenVanQuyet_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K22CNT4_NguyenVanQuyet_Project2.Controllers
{
    public class NVQCartController : Controller
    {
        private const string NVQCartSessionKey = "NVQCartSessionKey";
        NVQDbEntities dbEntities= new NVQDbEntities();
        private NVQ_ShoppingCart GetCart()
        {
            var cart = Session[NVQCartSessionKey] as NVQ_ShoppingCart;
            if (cart == null)
            {
                cart = new NVQ_ShoppingCart();
                Session[NVQCartSessionKey] = cart;
            }
            return cart;
        }
        public ActionResult AddToCart(int id,string TenSanPham, string HinhAnh, int SoLuongMua, float DonGiaMua)
        {
            var cart = GetCart();
            var item = new NVQCartItem
            {
                Id = id,
                TenSanPham = TenSanPham,
                HinhAnh = HinhAnh,
                SoLuongMua = SoLuongMua,
                DonGiaMua = DonGiaMua,
                ThanhTien = SoLuongMua * DonGiaMua
            };

            cart.Items.Add(item);
            return RedirectToAction("Index");
        }
        // GET: NVQCart
        public ActionResult Index()
        {
            var cart = GetCart();
            return View(cart.Items);
        }
    }
}