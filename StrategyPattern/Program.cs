using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new MallardDuck());
            ducks.Add(new RubberDuck());
            ducks.Add(new DecoyDuck());

            foreach (Duck duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                Console.WriteLine("Upgrading to rocket...");
                duck.FlyingBehavior = new FlyWithRocket();
                duck.PerformFly();
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
