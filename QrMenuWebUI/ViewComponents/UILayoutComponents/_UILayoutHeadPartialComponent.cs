using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeadPartialComponent  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
