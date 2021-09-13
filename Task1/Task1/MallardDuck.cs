using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyingWithWings();
            _quackBehavior = new DuckQuack();
            _swimable = new Swimable();
        }
    }
}
