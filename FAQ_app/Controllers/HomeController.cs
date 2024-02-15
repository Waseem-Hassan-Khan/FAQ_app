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

        [Route("topic/{topicName}")]
        public IActionResult C(string topicName)
        {
            var faqList = DataStore.FAQList.Where(t => t.Topic == topicName).ToList();
            ViewData["TopicName"] = topicName;

            return View(faqList);
        }

        //[Route("topic/{topicName}")]
        //public IActionResult JavaScript(string topicName)
        //{
        //    var faqList = DataStore.FAQList.Where(t => t.Topic == topicName).ToList();
        //    ViewData["TopicName"] = topicName;

        //    return View(faqList);
        //}

        //[Route("topic/{topicName}")]
        //public IActionResult BootStrap(string topicName)
        //{
        //    var faqList = DataStore.FAQList.Where(t => t.Topic == topicName).ToList();
        //    ViewData["TopicName"] = topicName;

        //    return View(faqList);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
