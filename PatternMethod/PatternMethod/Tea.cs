using System;

namespace PatternMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем чай...");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем сахар...");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Добавить сахар?");
            string answer = Console.ReadLine();
            if (answer.ToUpper().StartsWith("Д"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}