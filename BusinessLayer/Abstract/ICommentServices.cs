using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentServices:IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> GetListCommentWithDestination();
        public List<Comment> TGetListCommentWithDestinationAndUser(int id);

    }
}
