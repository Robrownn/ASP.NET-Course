

using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Avoid using http request headers within a controller
            var model = new Restaurant {Id = 1, Name = "My Pizza Place"};

            // The controller doesn't decide what the result is, just that it does the thing you're telling it to do
            return new ObjectResult(model);
        }
    }
}
