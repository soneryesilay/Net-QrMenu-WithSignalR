using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATablePartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
