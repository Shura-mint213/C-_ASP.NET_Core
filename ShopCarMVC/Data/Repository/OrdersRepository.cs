using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarMVC.Data.Interfaces;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDbContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDbContent, ShopCart shopCart)
        {
            this.shopCart = shopCart;
            this.appDbContent = appDbContent;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContent.Order.Add(order);

            var items = shopCart.ListShopItems;

            foreach (var elem in items)
            {
                var orderDetail = new OrderDetail()
                {
                    carId = elem.car.id,
                    orderID = order.id,
                    price = elem.car.price
                };
                appDbContent.OrderDerail.Add(orderDetail);
            }

            appDbContent.SaveChanges();
        }
    }
}
