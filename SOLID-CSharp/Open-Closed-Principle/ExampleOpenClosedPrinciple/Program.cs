using System;

namespace ExampleOpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Fruits =
            {
                new Fruit("oranges"),
                new Fruit("bananas"),
                new Fruit("strawberrys")
            };
            PrintFruitsPrice(Fruits);
        }

        private static void PrintFruitsPrice(Fruit[] Fruits)
        {
            foreach(var fruit in Fruits)
            {
                if (fruit.GetFruitType() == "oranges") Console.WriteLine(1.2);
                if (fruit.GetFruitType() == "bananas") Console.WriteLine(0.85);
                if (fruit.GetFruitType() == "strawberrys") Console.WriteLine(2);
            }
        }
    }
}
