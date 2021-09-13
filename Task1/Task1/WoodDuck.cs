using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    class WoodDuck : Duck
    {
        public WoodDuck()
        {
            _flyBehavior = new NoFly();
            _quackBehavior = new NoQuack();
            _swimable = new NotSwimable();
        }
    }
}
