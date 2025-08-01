using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Awards_certifications : PageModel
    {
        private readonly ILogger<Awards_certifications> _logger;

        public Awards_certifications(ILogger<Awards_certifications> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}