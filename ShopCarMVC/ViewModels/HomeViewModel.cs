using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> facCars { get; set; }
    }
}
