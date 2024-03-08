using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbstractUow
{
    public interface IGenericUowService<T>
    {
        void Insert(T t);
        void Update(T t);
        void MultiUpdate(List<T> t);
        T TGetById(int id);
    }
}
