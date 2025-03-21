using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
