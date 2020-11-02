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

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Entrees => Menu.Entrees();
        public IEnumerable<IOrderItem> Drinks => Menu.Drinks();
        public IEnumerable<IOrderItem> Sides => Menu.Sides();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
