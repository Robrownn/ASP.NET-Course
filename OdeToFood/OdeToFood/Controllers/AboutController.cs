using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    // Attribute Routing:
    [Route("company/[controller]/[action]")]
    public class AboutController : Controller
    {
        // If you just see /about then invoke the action below
        // Example: [Route("")]
        public string Phone()
        {
            return "1+555+555+5555";
        }

        // These attribute routes are hierarchical, therefor the route outside this scope will be /controller
        // and this would be controller/action
        // Example: [Route("[action]")]
        public string Address()
        {
            return "CA";
        }
    }
}