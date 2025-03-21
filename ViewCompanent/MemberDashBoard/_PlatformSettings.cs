using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.MemberDashBoard
{
    public class _PlatformSettings: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
