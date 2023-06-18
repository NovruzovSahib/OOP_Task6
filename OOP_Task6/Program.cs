using OOP_Task6;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.Go();
        car.Stop();
        Console.WriteLine();

        Plane plane = new Plane();
        plane.Go();
        plane.Stop();
        plane.Fly();
        Console.WriteLine();

        Ship ship = new Ship();
        ship.Go();
        ship.Stop();
        ship.Swim();
        Console.WriteLine();

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Go();
        motorcycle.Stop();
        motorcycle.Ride();

        Console.ReadLine();
    }
}