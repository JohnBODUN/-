using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;

namespace Обзор_решения.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("08.03.2022", new CultureInfo("ru-Rus"));
            ViewData["TimeStamp"] = dateTime;
        }
    }
}
