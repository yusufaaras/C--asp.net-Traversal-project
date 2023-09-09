using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.AdminDashboard
{
    public class _AdminGuideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
