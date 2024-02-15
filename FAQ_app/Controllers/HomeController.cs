using FAQ_app.Models;
using FAQ_app.Store;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FAQ_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var faqList = DataStore.FAQList;
            return View(faqList);
        }
        [Route("custom-privacy-url")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
