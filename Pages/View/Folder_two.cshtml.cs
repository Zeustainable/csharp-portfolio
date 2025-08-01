using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Folder_two : PageModel
    {
        private readonly ILogger<Folder_two> _logger;

        public Folder_two(ILogger<Folder_two> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}