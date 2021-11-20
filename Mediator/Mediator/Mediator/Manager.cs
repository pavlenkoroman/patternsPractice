using Mediator.MediatorUsers;

public abstract class Manager
{
    public abstract void Send(string message, OfficeWorker officeWorker);
}