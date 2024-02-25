using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dt_web_app.Pages
{
    public class DTDetail : PageModel
    {
        private readonly ILogger<DTDetail> _logger;

        public DTDetail(ILogger<DTDetail> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}