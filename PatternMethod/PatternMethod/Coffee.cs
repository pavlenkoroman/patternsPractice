using System;

namespace PatternMethod
{
    public class Coffee : CaffeineBeverage
    {
        public bool UserAnswer { get; set; }
        public Coffee(bool answer)
        {
            UserAnswer = answer;
        }
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
            if (UserAnswer)
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