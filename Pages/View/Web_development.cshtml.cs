using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Web_development : PageModel
    {
        private readonly ILogger<Web_development> _logger;

        public Web_development(ILogger<Web_development> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}