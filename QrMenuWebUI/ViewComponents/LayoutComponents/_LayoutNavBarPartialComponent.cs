using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavBarPartialComponent	:ViewComponent
	{
		public IViewComponentResult Invoke()
		{ 
			return View(); 
		}
	}
}
