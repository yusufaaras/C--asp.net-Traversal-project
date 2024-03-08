using BusinessLayer.Abstract.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal; 
        private readonly IUowDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public void Insert(Account t)
        {
            _accountDal.Insert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public Account TGetById(int id)
        {
           return _accountDal.GetById(id);
        }

        public void Update(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}
