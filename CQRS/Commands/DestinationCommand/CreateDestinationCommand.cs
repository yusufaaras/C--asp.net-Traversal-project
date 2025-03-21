namespace TraversalCoreProject.CQRS.Commands.DestinationCommand
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public bool status { get; set; }
    }
}
