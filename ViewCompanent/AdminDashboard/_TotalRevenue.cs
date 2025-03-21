using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.AdminDashboard
{
    public class _TotalRevenue:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
