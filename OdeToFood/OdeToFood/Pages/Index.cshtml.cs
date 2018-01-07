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

        public DbSet<Restaurant> Restaurants { get; set; }

        public IndexModel(OdeToFoodDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Restaurants = _context.Restaurants;
        }
    }
}