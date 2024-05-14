using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.MenuComponents
{
    public class _MenuNavbarPartialComponent  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
