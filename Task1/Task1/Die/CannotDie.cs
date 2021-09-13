using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Die
{
    class CannotDie : IDead
    {
        public void Dead()
        {
            Console.WriteLine("Это неодушевленный объект, поэтому не может умереть");
        }
    }
}
