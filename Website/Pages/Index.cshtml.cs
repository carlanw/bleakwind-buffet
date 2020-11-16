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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        //public IEnumerable<IOrderItem> Entrees => Menu.Entrees();
        //public IEnumerable<IOrderItem> Drinks => Menu.DrinksShort();
        //public IEnumerable<IOrderItem> Sides => Menu.SidesShort();

        /// <summary>
        /// List of items matching searc conditions
        /// </summary>
        public IEnumerable<IOrderItem> SearchResults { get; set; }
        /// <summary>
        /// Types of items to include
        /// </summary>
        public string[] Types { set; get; }
        /// <summary>
        /// Minimum price to filter by
        /// </summary>
        public double? PriceMin { get; set; }
        /// <summary>
        /// Maximum Price to filter by
        /// </summary>
        public double? PriceMax { get; set; }
        /// <summary>
        /// Minimum calories to filter by
        /// </summary>
        public uint? CalorieMin { get; set; }
        /// <summary>
        /// Maximum calories to filter by
        /// </summary>
        public uint? CalorieMax { get; set; }
        /// <summary>
        /// Terms to search for
        /// </summary>
        public string[] SearchTerms { get; set; }
        /// <summary>
        /// Unformatted input from the search bar
        /// </summary>
        public string SearchTermsRaw { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] Types, double? PriceMin, double? PriceMax, uint? CalorieMin, uint? CalorieMax)
        {
            this.Types = Types;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CalorieMin = CalorieMin;
            this.CalorieMax = CalorieMax;
            this.SearchTermsRaw = SearchTerms;
            if (SearchTerms != null)
                this.SearchTerms = SearchTerms.Split(' ');
            else
                this.SearchTerms = null;

            SearchResults = new List<IOrderItem>();

            // Apply Search Terms
            if (SearchTerms != null && SearchTerms.Length != 0)
            {
                foreach (string term in this.SearchTerms)
                {
                    IEnumerable<IOrderItem> Matches = Menu.FullMenu().Where(item =>
                    item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase) ||
                    item.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase) &&
                    !SearchResults.Contains(item)
                    );

                    (SearchResults as List<IOrderItem>).AddRange(Matches);
                }
            }
            else
            {
                SearchResults = Menu.FullMenu();
            }

            // Filter by type
            if(Types != null && Types.Count() != 0)
            {
                SearchResults = SearchResults.Where(item =>
                (item is Entree && Types.Contains("Entree")) ||
                (item is Drink && Types.Contains("Drink")) ||
                (item is Side && Types.Contains("Side"))
                );
            }

            // Filter by price
            if(PriceMin != null && PriceMax != null)
            {
                if(PriceMin == null) // only max defined
                {
                    SearchResults = SearchResults.Where(item =>
                    item.Price <= PriceMax
                    );
                }
                else if(PriceMax == null) // only min defined
                {
                    SearchResults = SearchResults.Where(item =>
                    item.Price >= PriceMin
                    );
                }
                else // both defined
                {
                    SearchResults = SearchResults.Where(item =>
                    item.Price <= PriceMax &&
                    item.Price >= PriceMin
                    );
                }
            }

            // Filter by calories
            if (CalorieMin != null && CalorieMax != null)
            {
                if (CalorieMin == null) // only max defined
                {
                    SearchResults = SearchResults.Where(item =>
                    item.Calories <= CalorieMax
                    );
                }
                else if (CalorieMax == null) // only min defined
                {
                    SearchResults = SearchResults.Where(item =>
                    item.Calories >= CalorieMin
                    );
                }
                else // both defined
                {
                    SearchResults = SearchResults.Where(item =>
                    item.Calories <= CalorieMax &&
                    item.Calories >= CalorieMin
                    );
                }
            }

            //SearchResults = Menu.FilterByType(Menu.FullMenu(), Types);
            //SearchResults = Menu.FilterByPrice(SearchResults, PriceMin, PriceMax);
            //SearchResults = Menu.FilterByCalories(SearchResults, CalorieMin, CalorieMax);
        }
    }
}
