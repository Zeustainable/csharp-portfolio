using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Folder_three : PageModel
    {
        private readonly ILogger<Folder_three> _logger;

        public Folder_three(ILogger<Folder_three> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}