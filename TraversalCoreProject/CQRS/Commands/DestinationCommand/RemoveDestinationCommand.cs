namespace TraversalCoreProject.CQRS.Commands.DestinationCommand
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
