using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptsPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
