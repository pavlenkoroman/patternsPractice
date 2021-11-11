using System;
using System.IO.Compression;

namespace PatternMethod
{
    class Program
    {
        static void Main()
        {
            Coffee coffee = new Coffee();
            Tea tea = new Tea();

            coffee.PrepareRecipe();
            tea.PrepareRecipe();
        }
    }
}
