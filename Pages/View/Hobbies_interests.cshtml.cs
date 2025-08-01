using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Hobbies_interests : PageModel
    {
        private readonly ILogger<Hobbies_interests> _logger;

        public Hobbies_interests(ILogger<Hobbies_interests> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}