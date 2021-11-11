using System;

namespace PatternMethod
{
    public abstract class CaffeineBeverage
    {
        private static void BoilWater()
        {
            Console.WriteLine("Кипятим воду...");
        }

        private static void PourInCap()
        {
            Console.WriteLine("Наливаем в чашку...");
        }

        protected abstract void Brew();

        public  void PrepareRecipe()
        {
            BoilWater();
            PourInCap();
            Brew();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }
        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}