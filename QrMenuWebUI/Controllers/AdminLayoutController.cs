using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
