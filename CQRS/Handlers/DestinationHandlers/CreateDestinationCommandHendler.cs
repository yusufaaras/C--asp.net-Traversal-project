using TraversalCoreProject.CQRS.Commands.DestinationCommand;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityLayer.Concrete;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHendler
    {
        private readonly Context _context;

        public CreateDestinationCommandHendler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination_yerler
            {
                City = command.City,
                Capacity = command.Capacity,
                DayNight = command.DayNight,
                status=true, 
                Price=command.Price
            });
            _context.SaveChanges();
        }
    }
}
