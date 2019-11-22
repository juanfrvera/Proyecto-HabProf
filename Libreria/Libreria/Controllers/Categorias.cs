using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class Categorias : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}