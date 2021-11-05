using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopCarMVC.Data.Interfaces;
using ShopCarMVC.Data.Models;

namespace ShopCarMVC.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCats = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Testla",
                        img = "/img/TeslaModelS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCats.AllCategories.First()
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
                        Category = _categoryCats.AllCategories.Last()
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
                        Category = _categoryCats.AllCategories.Last()
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
                        Category = _categoryCats.AllCategories.Last()
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
                        Category = _categoryCats.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFevCars { get; set; }

        public IEnumerable<Car> getFavCars => throw new NotImplementedException();

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
