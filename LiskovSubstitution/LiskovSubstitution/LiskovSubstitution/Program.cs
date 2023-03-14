using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{


    /*
     * Lİskov Substitionda üst sınıfı kullanan alt sınıflar üst sınıfa ait özellikleri tamamen kullanabilmeli,anlamsal olarak bütüncül bir şekilde 
     * kullanıp, hiç bir alt sınıfta üst sınıfa ait kullanılmayan bir özellik es geçimemeli (throw new ImplementedExecepiton) gibi
     * Eğer böyle bir durum oluyor ise de bu duruma sebep olanb özellik için ayrı bir interface yaratılamlıdır.
     * */

    public static void Main(string[] args)
    {
        Duck duck = new MallardDuck();
        duck.Fly();
        /*
         * POLYMORPHISM
          Çok biçimlilik olarak bilinir.  Teknik olarak; bir üst sınıf referansının tüm alt sınıf nesnelerini tutabilmesidir.
          Bilindiği gibi, alt sınıftaki nesneler üst ıfın sahip olduğu metotlara(static ve final tanımlı metotlar hariç) da sahiptirler 
         (Örneğin, oluşturduğunuz bir nesne üzerinde Object sınıfına ait metotları görmeniz mümkündür).
         Bu özellik ile birlikte Polymorphism, bir üst sınıf referansı ile alt sınıftaki nesnelerin kullanılabilmesine olanak sağlar. 
         Buradaki avantaj, bir işlemi gerçekleştirirken hangi sınıfa ait nesne ile işlem gerçekleştirdiğimizi bilmemize gerek kalmamasıdır.

         */
    }

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

    public class MallardDuck : Duck, IFly, ISwim, IQuack
    {
        public override void Quack()
        {
            System.Console.WriteLine("Quack!");
        }

        public override void Swim()
        {
            System.Console.WriteLine("Swimming!");
        }

        public override void Fly()
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
