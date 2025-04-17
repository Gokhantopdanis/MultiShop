using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents._ContactDetailComponentPartial
{
    public class _ContactDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}