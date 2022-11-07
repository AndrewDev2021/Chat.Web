using Microsoft.AspNetCore.Mvc;

namespace Chat.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] 
        [Route("/")]
        public IActionResult HomePage()
        {
            return View();
        }
    }
}