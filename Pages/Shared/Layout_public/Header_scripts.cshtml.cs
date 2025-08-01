using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.Shared.Layout_public
{
    public class Header_scripts : PageModel
    {
        private readonly ILogger<Header_scripts> _logger;

        public Header_scripts(ILogger<Header_scripts> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}