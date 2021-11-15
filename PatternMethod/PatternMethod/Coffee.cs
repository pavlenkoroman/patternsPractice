using System;

namespace PatternMethod
{
    public class Coffee : CaffeineBeverage
    {
        private bool userAnswer;
        public Coffee(bool answer)
        {
            userAnswer = answer;
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
            return userAnswer;
        }
    }
}