using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFly FlyingBehavior;

        public IQuack QuackBehavior;

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyingBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }

    public interface IFly
    {
        void Fly();
    }

    public interface IQuack
    {
        void Quack();
    }

    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public class CantFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }

    }

    public class FlyWithRocket : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm rocket powered! Whooooooosh!");
        }
    }

    public class DuckQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class Squeek : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeek!");
        }
    }

    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.FlyingBehavior = new FlyWithWings();
            this.QuackBehavior = new DuckQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.FlyingBehavior = new CantFly();
            this.QuackBehavior = new Squeek();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.FlyingBehavior = new CantFly();
            this.QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
