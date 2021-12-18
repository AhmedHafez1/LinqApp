using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public int Count;

        public string FunnyThingIHave => "big red shoes";

        public void Honk() => Console.WriteLine("Honk honk!");

        public void TalkAboutYourself() => Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");

        public string ScaryThing => $"{Count} spiders"; 
    }
}
