using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager:IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public List<Destination_yerler> GetList()
        {
            return _destinationDal.GetList();
        }

        public void TAdd(Destination_yerler t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination_yerler t)
        {
            _destinationDal.Delete(t);
        }

        public Destination_yerler TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public Destination_yerler TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination_yerler> TGetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }

        public void TUpdate(Destination_yerler t)
        {
            _destinationDal.Update(t);
        }
    }
}
