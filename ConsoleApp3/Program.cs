using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {
                new Wolf(false),
                new Hippo(),
                new Wolf(true),
                new Wolf(false),
                new Hippo()
                };
            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
                if (animal is ISwimmer swimmer)
                {
                    swimmer.Swim();
                }
                if (animal is IPackHunter packHunter)
                {
                    packHunter.HuntInPack();
                }

                if (animal is Canine)
                {
                    Console.WriteLine("Canine ################################################");
                }
               

                Console.WriteLine();
            }
            
            Hippo hippo = new Hippo();
            IPackHunter pack = hippo as IPackHunter;

            if (pack != null) Console.WriteLine("OK");
        }
    }
}
