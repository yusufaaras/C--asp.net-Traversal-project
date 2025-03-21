using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewCompanent.Comments
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager =new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values =commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
