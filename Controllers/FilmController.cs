using Microsoft.AspNetCore.Mvc;

namespace FilmDB1.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
