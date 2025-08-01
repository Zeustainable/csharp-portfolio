using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.Shared.Layout_public
{
    public class Footer_scripts : PageModel
    {
        private readonly ILogger<Footer_scripts> _logger;

        public Footer_scripts(ILogger<Footer_scripts> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}