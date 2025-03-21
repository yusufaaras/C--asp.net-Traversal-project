namespace TraversalCoreProject.CQRS.Commands.DestinationCommand
{
    public class UpdateDestinationCommand
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
    }
}
