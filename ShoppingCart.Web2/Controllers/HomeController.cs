using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Web2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
