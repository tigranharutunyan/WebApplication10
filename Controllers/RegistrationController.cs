using Microsoft.AspNetCore.Mvc;
using WebApplication10.Data;
using WebApplication10.Data.Entity;
namespace WebApplication10.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly MyContextUsers _context;
        public RegistrationController(MyContextUsers context)
        {
            _context = context;
        }

        public IActionResult Index(UserRegistrationcs users)
        {
           
                _context.Users.Add(users);
                _context.SaveChanges();
           
            return View();
        }
    }
}
