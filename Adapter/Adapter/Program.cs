using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Turkey turkey = new Turkey();
            TurkeyToDuckAdapter adaptedTurkey = new TurkeyToDuckAdapter(turkey);

            adaptedTurkey.Fly();
            adaptedTurkey.Quack();
        }
    }
}
