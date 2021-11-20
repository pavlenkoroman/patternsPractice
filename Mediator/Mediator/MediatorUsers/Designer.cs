using System;

namespace Mediator.MediatorUsers
{
    public class Designer : OfficeWorker
    {
        public Designer(Manager manager) 
            : base(manager)
        { }

        public void Send(string message)
        {
            Manager.Send(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Сообщение дизайнеру: {message}");
        }
    }
}