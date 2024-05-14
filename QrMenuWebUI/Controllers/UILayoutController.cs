using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
