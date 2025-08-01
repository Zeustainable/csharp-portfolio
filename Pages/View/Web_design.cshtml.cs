using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Web_design : PageModel
    {
        private readonly ILogger<Web_design> _logger;

        public Web_design(ILogger<Web_design> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}