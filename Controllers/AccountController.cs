using Microsoft.AspNetCore.Mvc;

namespace OnlineStoreZaliczenie.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
