using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOpenClosedPrinciple
{
    public class Fruit
    {
        private string type;

        public Fruit(string type)
        {
            this.type = type;
        }

        public string GetFruitType()
        {
            return type;
        }
    }
}
