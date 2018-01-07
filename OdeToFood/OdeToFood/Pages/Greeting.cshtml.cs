using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;

        public string CurrentGreeting { get; set; }

        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }

        // You can add parameters to this get and use them in the display of the page.
        // For example using string interpolation to include a name in the current message.
        public void OnGet()
        {
            CurrentGreeting = _greeter.GetMessageOfTheDay();
        }
    }
}