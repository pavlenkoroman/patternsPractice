using System;

namespace PatternMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем молоко...");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Добавить молока?");
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