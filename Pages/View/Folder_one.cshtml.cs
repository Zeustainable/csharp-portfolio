using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyPortfolio.Pages.View
{
    public class Folder_one : PageModel
    {
        private readonly ILogger<Folder_one> _logger;

        public Folder_one(ILogger<Folder_one> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}