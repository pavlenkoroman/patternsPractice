using System;
using System.Collections.Generic;
using System.Text;
using Task1.Die;
using Task1.Swim;

namespace Task1
{
    class WoodDuck : Duck
    {
        public WoodDuck()
            :base(new NoFly(), new NoQuack(), new NotSwimable(), new CannotDie())
        { }
    }
}
