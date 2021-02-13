using System;

namespace ExampleOpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Fruits =
            {
                new Orange(),
                new Strawberry(),
                new Banana()
            };
            PrintFruitsPrice(Fruits);
        }

        private static void PrintFruitsPrice(Fruit[] Fruits)
        {
            foreach(var fruit in Fruits)
            {
                Console.WriteLine(fruit.GetPrice());
            }
        }
    }
}
