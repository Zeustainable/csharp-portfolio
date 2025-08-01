using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Graphic_design : PageModel
    {
        private readonly ILogger<Graphic_design> _logger;

        public Graphic_design(ILogger<Graphic_design> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}