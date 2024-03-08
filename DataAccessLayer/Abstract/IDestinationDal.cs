using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination_yerler>
    {
        public Destination_yerler GetDestinationWithGuide(int id);
        public List<Destination_yerler> GetLast4Destinations();
    }
}
