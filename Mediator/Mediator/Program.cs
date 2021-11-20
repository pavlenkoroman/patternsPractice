using Mediator.Mediator;
using Mediator.MediatorUsers;

namespace Mediator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProjectManager pm = new ProjectManager();
            Programmer programmer = new Programmer(pm);
            Designer designer = new Designer(pm);

            pm.Programmer = programmer;
            pm.Designer = designer;
            
            designer.Send("Дизайн готов, иди работай");
            programmer.Send("Моя часть работы окончена, жду следующий макет");
        }
    }
}