namespace Mediator.MediatorUsers
{
    public abstract class OfficeWorker
    {
        public Manager Manager { get; protected set; }

        public OfficeWorker(Manager manager)
        {
            this.Manager = manager;
        }

        public abstract void Notify(string message);
    }
}