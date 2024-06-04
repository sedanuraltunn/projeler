using Microsoft.AspNetCore.Mvc;

namespace HtmlLesson.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
