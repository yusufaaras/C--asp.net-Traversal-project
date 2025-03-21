using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.Default
{
    public class _TestiMonial:ViewComponent
    {
        TestiMonialManager testiMonialManager = new TestiMonialManager(new EfTestimonalDal());
        public IViewComponentResult Invoke()
        {
            var values =testiMonialManager.GetList();
            return View(values);
        }
    }
}
