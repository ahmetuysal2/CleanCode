using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{


    public abstract class Duck
    {
        public abstract void Quack(); //All duck can quack
        public abstract void Swim(); // All duck can swim
        public abstract void Fly(); // But not all duck can swim for example  RubberDuck. So Ist not appropriate for Liskov Substitution Principle
                                    // We can use interface for the propery that subclass can not use
    }


    public interface IFly
    {
        void Fly();
    }

    public interface ISwim
    {
        void Swim();
    }

    public interface IQuack
    {
        void Quack();
    }

    public class MallardDuck : IFly, ISwim, IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            System.Console.WriteLine("Swimming!");
        }

        public void Fly()
        {
            System.Console.WriteLine("Flying!");
        }
    }

    public class MarbledDuck : IFly, ISwim, IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            System.Console.WriteLine("Swimming!");
        }

        public void Fly()
        {
            System.Console.WriteLine("Flying!");
        }
    }

    public class RubberDuck : ISwim, IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak!");
        }

        public void Swim()
        {
            System.Console.WriteLine("Floating!");
        }
    }


    //public class MallardDuck : Duck
    //{
    //    public override void Quack()
    //    {
    //        System.Console.WriteLine("Quack!");
    //    }

    //    public override void Swim()
    //    {
    //        System.Console.WriteLine("Swimming!");
    //    }

    //    public override void Fly()
    //    {
    //        System.Console.WriteLine("Flying!");
    //    }
    //}

    //public class MarbledDuck : Duck
    //{
    //    public override void Quack()
    //    {
    //        System.Console.WriteLine("Quack!");
    //    }

    //    public override void Swim()
    //    {
    //        System.Console.WriteLine("Swimming!");
    //    }

    //    public override void Fly()
    //    {
    //        System.Console.WriteLine("Flying!");
    //    }
    //}

    //public class RubberDuck : Duck
    //{
    //    public override void Quack()
    //    {
    //        System.Console.WriteLine("Squeak!");
    //    }

    //    public override void Swim()
    //    {
    //        System.Console.WriteLine("Floating!");
    //    }

    //    public override void Fly()
    //    {
    //        throw new Exception("Rubber ducks can't fly!");
    //    }
    //}
}
