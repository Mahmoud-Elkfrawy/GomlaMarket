using Microsoft.AspNetCore.Mvc;

namespace GomlaMarket.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
