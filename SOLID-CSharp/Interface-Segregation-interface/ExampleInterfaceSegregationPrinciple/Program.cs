using System;

namespace ExampleInterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Swimmer swimmer = new Swimmer();
            swimmer.Run(5);
        }
    }

    public interface IAthlete
    {
        void WarmUp(int time);
        void Run(int time);
        void Swing(int time);
    }

    class Swimmer : IAthlete
    {
        public void Run(int time)
        {
            throw new NotImplementedException();
        }

        public void Swing(int time)
        {
            // Proccess to Swing ...
        }

        public void WarmUp(int time)
        {
            // Proccess to WarmUp ...
        }
    }

}
