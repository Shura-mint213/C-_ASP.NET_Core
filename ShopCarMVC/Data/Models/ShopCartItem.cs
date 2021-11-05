using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCarMVC.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car car { get; set; }
        public int price { get; set; }
        public string ShopCarId{ get; set; }
    }
}
