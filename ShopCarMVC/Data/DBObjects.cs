using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if(!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                     new Car
                     {
                         name = "Tesla Model S",
                         shortDesc = "Быстрый автомобиль",
                         longDesc = "Красивый, быстрый и очень тихий автомобиль компании Testla",
                         img = "/img/TeslaModelS.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Электромобиль"]
                     },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/FordFiesta.jpg",
                        price = 16000,
                        isFavourite = false,
                        available = true,
                        Category = category["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMV M3",
                        shortDesc = "Дерзкий и стльный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/BMVM3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = category["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes c class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/MercedesCClass.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = category["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономичный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/NissanLeaf.jpg",
                        price = 15000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобиль"]
                    });
            }
            content.SaveChanges();
        }
        
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобиль", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машина с двигателем внутреннего сгорания" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }
                return category;
            }
        }
    }
}
