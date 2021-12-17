using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var whatAmI = new { Color = "Blue", Flavor = "Tasty", Height = 37 };
            Console.WriteLine(whatAmI);
            Console.WriteLine($"My color is {whatAmI.Color} and I'm {whatAmI.Flavor}");
        }
    }
}
