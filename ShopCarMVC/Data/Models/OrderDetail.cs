using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCarMVC.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int carId { get; set; }
        public uint price { get; set; }
        public virtual Car car { get; set; }
        public virtual  Order order { get; set; }
        
    }
}
