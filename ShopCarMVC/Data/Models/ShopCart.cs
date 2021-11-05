using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ShopCarMVC.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDbContent;
        public ShopCart(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCarId = ShopCartId,
                car = car,
                price = car.price
            });
            appDbContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return appDbContent.ShopCartItem.Where(c => c.ShopCarId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
