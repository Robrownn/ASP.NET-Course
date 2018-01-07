using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class IndexModel : PageModel
    {
        private OdeToFoodDBContext _context;
        private IGreeter _greeter;

        public DbSet<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }

        public IndexModel(OdeToFoodDBContext context,
                          IGreeter greeter)
        {
            _context = context;
            _greeter = greeter;
        }

        public void OnGet()
        {
            Restaurants = _context.Restaurants;
            CurrentMessage = _greeter.GetMessageOfTheDay();
        }
    }
}