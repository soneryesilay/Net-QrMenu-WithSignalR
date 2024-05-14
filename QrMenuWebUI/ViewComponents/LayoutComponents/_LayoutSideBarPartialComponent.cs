using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutSideBarPartialComponent : ViewComponent
	{
	   public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
