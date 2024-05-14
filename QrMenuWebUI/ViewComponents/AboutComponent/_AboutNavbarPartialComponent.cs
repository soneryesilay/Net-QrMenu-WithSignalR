using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.AboutComponent
{
    public class _AboutNavbarPartialComponent  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
