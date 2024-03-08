using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete.ConcreteUow
{
    public interface IAccountService : IGenericUowService<Account>
    {
    }
}