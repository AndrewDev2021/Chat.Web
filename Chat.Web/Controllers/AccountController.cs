using Microsoft.AspNetCore.Mvc;

namespace Chat.Web.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("/registration")]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpGet]
        [Route("/login")]
        public IActionResult LogIn()
        {
            return View();
        }
    }
}
