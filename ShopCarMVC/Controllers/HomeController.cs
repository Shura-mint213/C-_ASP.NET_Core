using System;
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
    public class HomeController : Controller
    {
        private readonly IAllCars carRep;

        public HomeController(IAllCars carRep)
        {
            this.carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                facCars = carRep.getFavCars
            };
            return View(homeCars);
        }
    }
}
