using DataAccessLayer.Concrete;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIdQueryResults Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResults
            {
                DestinationId = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
