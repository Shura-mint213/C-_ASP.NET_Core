using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopCarMVC.Data.Interfaces;
using ShopCarMVC.Data.Models;
using ShopCarMVC.ViewModels;

namespace ShopCarMVC.Controllers
{
    public class ShopCartController : Controller 
    {
        private readonly IAllCars carRep;
        private readonly ShopCart shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            this.shopCart = shopCart;
            this.carRep = carRep;
        }

        public ViewResult Index()
        {
            var items = shopCart.GetShopItems();
            shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = carRep.Cars.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
