using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ClientUserCount()
		{
			return View();
		}
	}
}
