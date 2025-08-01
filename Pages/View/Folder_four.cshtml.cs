using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Folder_four : PageModel
    {
        private readonly ILogger<Folder_four> _logger;

        public Folder_four(ILogger<Folder_four> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}