using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCarMVC.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName  { get; set; }
        public string desc { get; set; }
        public List<Car> Cars { get; set; }

    }
}
