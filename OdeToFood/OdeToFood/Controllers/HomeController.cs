

using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            // Avoid using http request headers within a controller
            var model = _restaurantData.GetAll();

            // The controller doesn't decide what the result is, just that it does the thing you're telling it to do
            return View(model);
        }
    }
}
