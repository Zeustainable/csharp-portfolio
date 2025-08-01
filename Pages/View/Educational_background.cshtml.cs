using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Educational_background : PageModel
    {
        private readonly ILogger<Educational_background> _logger;

        public Educational_background(ILogger<Educational_background> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}