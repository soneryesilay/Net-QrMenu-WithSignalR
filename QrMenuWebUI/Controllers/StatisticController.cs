using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.Controllers
{
	public class StatisticController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
