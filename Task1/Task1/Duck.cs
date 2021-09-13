using System;
using System.Collections.Generic;
using System.Text;
using Task1.Swim;

namespace Task1
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;
        protected ISwimable _swimable;        

        public void Display() 
        {
            Console.WriteLine("Это уточка");
            _flyBehavior.Fly();
            _quackBehavior.Quack();
            _swimable.Swim();
        }
        
    }
}
