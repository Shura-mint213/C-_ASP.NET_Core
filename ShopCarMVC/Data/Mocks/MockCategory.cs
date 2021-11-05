using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarMVC.Data.Interfaces;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Электромобиль", desc = "Современный вид транспорта"},
                    new Category{categoryName = "Классические автомобили", desc = "Машина с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
