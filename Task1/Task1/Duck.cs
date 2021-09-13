using System;
using System.Collections.Generic;
using System.Text;
using Task1.Die;
using Task1.Swim;

namespace Task1
{
    public abstract class Duck
    {
        private protected IFlyBehavior _flyBehavior;
        private protected IQuackBehavior _quackBehavior;
        private protected ISwimable _swimable;
        private protected IDead _dead;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimable swimable, IDead dead)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _swimable = swimable;
            _dead = dead;
        }
        public void Display() 
        {
            _flyBehavior.Fly();
            _quackBehavior.Quack();
            _swimable.Swim();
        }

        public void Dead()
        {
            if(_dead is CanDie)
            {
                CanDie canDie = new CanDie();
                canDie.Dead();

                _flyBehavior = new NoFly();
                _quackBehavior = new NoQuack();
                _swimable = new NotSwimable();
            }
            else
            {
                CannotDie cannotDie = new CannotDie();
                cannotDie.Dead();
            }
        }
    }
}
