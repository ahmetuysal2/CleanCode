public interface Animal
{
    void Fly();
    void Run();
    void Bark();
}

public class Bird : Animal
{
    public void Bark()
    {
        //do nothing 
    }

    public void Fly()
    {
        Console.WriteLine("I am flying");
    }

    public void Run()
    {
        Console.WriteLine("I am running");
    }
}

public class Cat : Animal
{
    public void Bark()
    {
        //do nothing 
    }

    public void Fly()
    {
        //do nothing 
    }

    public void Run()
    {
        Console.WriteLine("I am running");
    }
}


//Interface Segregation Principle


public interface Flyable
{
    void Fly();
}
public interface Runnable
{
    void Run();
}
public interface Barkable
{
    void Bark();
}

public class BirdWithInterfaceSegregation : Flyable, Runnable
{
    public void Run()
    {
        Console.WriteLine("I am running");
    }
    public void Fly()
    {
        Console.WriteLine("I am flying");

    }
}

public class CatWithInterfaceSegregation : Runnable
{
    public void Run()
    {
        Console.WriteLine("I am running");
    }
}
