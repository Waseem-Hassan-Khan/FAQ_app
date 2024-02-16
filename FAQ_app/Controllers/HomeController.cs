using FAQ_app.Store;
using Microsoft.AspNetCore.Mvc;

namespace FAQ_app.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index(string category)
        {
            var faqList = DataStore.FAQList;

            ViewData["Category"] = category;
            return View(faqList);
        }


        [Route("topic/{topicName}")]
        [Route("/category/{category}")]
        [Route("topic/{topicName}/category/{category}")]
        public IActionResult C(string topicName, string category)
        {
            var nfaqList = DataStore.FAQList;

            if (!string.IsNullOrEmpty(topicName) && string.IsNullOrEmpty(category))
            {
                var faqList = DataStore.FAQList.Where(t => t.Topic == topicName).ToList();
                return View(faqList);
            }

            if (!string.IsNullOrEmpty(category) && string.IsNullOrEmpty(topicName))
            {
                var faqList = DataStore.FAQList.Where(t => t.Category == category).ToList();
                return View(faqList);
            }

            if (!string.IsNullOrEmpty(category) && string.IsNullOrEmpty(topicName))
            {
                var faqList = DataStore.FAQList.Where(t => t.Category == category).ToList();
                return View(faqList);
            }

            if (!string.IsNullOrEmpty(category) && !string.IsNullOrEmpty(topicName))
            {
                var faqList = DataStore.FAQList.Where(t => t.Category == category&& t.Topic == topicName).ToList();
                category = null;
                return View(faqList);
            }

            ViewData["TopicName"] = topicName;
            ViewData["Category"] = category;

            return View(nfaqList);
        }
    }
}
