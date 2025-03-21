using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.AdminDashboard
{
    public class _DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
