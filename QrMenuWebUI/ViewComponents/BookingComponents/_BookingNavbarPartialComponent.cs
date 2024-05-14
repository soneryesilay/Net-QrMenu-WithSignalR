using Microsoft.AspNetCore.Mvc;

namespace QrMenuWebUI.ViewComponents.BookingComponents
{
    public class _BookingNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
