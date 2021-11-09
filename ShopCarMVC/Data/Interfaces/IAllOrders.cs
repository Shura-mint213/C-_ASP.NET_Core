using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
