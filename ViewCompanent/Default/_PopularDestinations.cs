using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.Default
{
    public class _PopularDestinations: ViewComponent
    {
        DestinationManager destinationManager= new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.GetList();
            return View(values);
        }
    }
}
