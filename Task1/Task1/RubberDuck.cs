using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new NoFly();
            _quackBehavior = new RubberDuckQuack();
            _swimable = new Swimable();
        }
    }
}
