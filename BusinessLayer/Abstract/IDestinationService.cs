using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination_yerler>
    {
        public Destination_yerler TGetDestinationWithGuide(int id);
        public List<Destination_yerler> TGetLast4Destinations();
    }
}
