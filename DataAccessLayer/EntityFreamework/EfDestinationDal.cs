using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamework
{
    public class EfDestinationDal : GenericRepository<Destination_yerler>, IDestinationDal
    {
        public Destination_yerler GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x=>x.DestinationId==id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Destination_yerler> GetLast4Destinations()
        {
            using (var context = new Context())
            {
                var values = context.Destinations.Take(4).OrderByDescending(x=>x.DestinationId).ToList();
                return values;
            }
        }
    }
}
