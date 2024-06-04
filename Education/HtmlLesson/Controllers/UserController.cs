using HtmlLesson.Context;
using HtmlLesson.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlLesson.Controllers
{
    public class UserController : Controller
    {
        private readonly MSUDBContext _context;

        public UserController(MSUDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public User Register([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            //user.Name = string.Concat("Değişen-", user.Name);
            return user;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
         
    }
}
