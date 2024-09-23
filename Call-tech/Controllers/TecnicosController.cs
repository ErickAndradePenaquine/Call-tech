using Microsoft.AspNetCore.Mvc;

namespace Call_tech.Controllers
{
    public class TecnicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
