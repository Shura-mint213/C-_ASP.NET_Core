using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCarMVC.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = allCars.Cars;
            obj.carCategory = "Автомобиль";
            return View(obj);
        }
    }
}
