using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using System.Reflection.Metadata;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        //public IEnumerable<IOrderItem> Entrees => Menu.Entrees();
        //public IEnumerable<IOrderItem> Drinks => Menu.DrinksShort();
        //public IEnumerable<IOrderItem> Sides => Menu.SidesShort();
        public IEnumerable<IOrderItem> SearchResults { get; set; }
        public string[] Types { set; get; }
        public double? PriceMin { get; set; }
        public double? PriceMax { get; set; }
        public uint? CalorieMin { get; set; }
        public uint? CalorieMax { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string[] Types, double? PriceMin, double? PriceMax, uint? CalorieMin, uint? CalorieMax)
        {
            this.Types = Types;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            SearchResults = Menu.FilterByType(Menu.FullMenu(), Types);
            SearchResults = Menu.FilterByPrice(SearchResults, PriceMin, PriceMax);
            SearchResults = Menu.FilterByCalories(SearchResults, CalorieMin, CalorieMax);
        }
    }
}
