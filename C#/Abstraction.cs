abstract class Vehicle
{
    public abstract void start();

    public void stop()
    {
        Console.WriteLine("Vehicle has stopped");
    }
}

class Scooter : Vehicle
{
    public override void start()
    {
        Console.WriteLine("Scooter has started");
    }
}