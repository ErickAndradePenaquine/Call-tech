using Microsoft.AspNetCore.Mvc;

namespace Call_tech.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
