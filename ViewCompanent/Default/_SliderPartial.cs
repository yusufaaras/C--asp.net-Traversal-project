using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
