class Animal          // methods behave according to obj call
{
    public virtual void display()
    {
        Console.WriteLine("This is an Animal");
    }
}

class Herbivore : Animal
{
    public override void display()
    {
        Console.WriteLine("This is a Herbivore");
    }
}

class Carnivore : Animal
{
    public override void display()
    {
        Console.WriteLine("This is a Carnivore");
    }
}