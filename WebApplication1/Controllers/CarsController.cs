using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Data.interfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CarsController : Controller 
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory ICarsCat)
        {
            _allCars = iAllCars;
            _allCategories = ICarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Cars";

            return View(obj);
        }

        
    }
}
