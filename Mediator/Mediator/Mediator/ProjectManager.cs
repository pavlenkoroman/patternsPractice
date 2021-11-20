using System.Security.Cryptography;
using Mediator.MediatorUsers;

namespace Mediator.Mediator
{
    public class ProjectManager : Manager
    {
        public Designer Designer { get; set; }
        public Programmer Programmer { get; set; }
        public override void Send(string message, OfficeWorker officeWorker)
        {
            if (Designer == officeWorker)
            {
                Programmer.Notify(message);
            }
            else
            {
                Designer.Notify(message);
            }
        }
    }
}