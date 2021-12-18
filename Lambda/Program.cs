using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            tallGuy.Honk();

            var array = new[] { 5, 16, 7, 18, 9, 11, 14, 19 };
            var result1 = from i in array select 2 * i;
            var result2 = array.Select(i => 2 * i).OrderBy(i => i);

            foreach (var i in result1)
            {
                Console.WriteLine(i);
            }

            foreach (var i in result2)
            {
                Console.WriteLine(i);
            }

            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result3 = from v in values
                                      where v < 37
                                      orderby -v
                                      select v;

            var result4 = values.Where(v => v < 37).OrderByDescending(v => v);
        }
    }
}
