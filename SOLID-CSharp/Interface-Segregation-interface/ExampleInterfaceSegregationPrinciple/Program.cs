using System;

namespace ExampleInterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Swimmer swimmer = new Swimmer();
            swimmer.Swing(5);
        }
    }

    public interface IAthlete
    {
        void WarmUp(int time);
    }

    public interface ISwimmable
    {
        void Swing(int time);
    }

    public interface IRunable
    {
        void Run(int time);
    }

    class Swimmer : IAthlete, ISwimmable
    {
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
