using Microsoft.AspNetCore.Mvc;

namespace HTMLLesson.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}
