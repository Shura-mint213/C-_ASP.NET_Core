using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCarMVC.Data.Interfaces;
using ShopCarMVC.Data.Models;
using ShopCarMVC.ViewModels;

namespace ShopCarMVC.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory allCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            allCars = iAllCars;
            allCategories = iCarsCategory;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            //string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                //проверка на тип товара
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобиль")).OrderBy(i => i.id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allCars.Cars.Where(i => i.Category.categoryName.Equals("Классические автомобили")).OrderBy(i => i.id);
                    currCategory = "Классические автомобили";
                }
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                carCategory = currCategory
            };
            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }
    }
}
