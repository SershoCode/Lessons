namespace Homework.Race;

public class Car
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int HorsePowers { get; set; }
    public double AccelerationTime { get; set; }

    public Car(string manufacturer, string model, int horsePowers, double accelerationTime)
    {
        Manufacturer = manufacturer;
        Model = model;
        HorsePowers = horsePowers;
        AccelerationTime = accelerationTime;
    }

    public void PrintSpecs()
    {
        var delimiter = new string('-', 20);

        Console.WriteLine(delimiter);

        ConsoleHelper.Print($"{Manufacturer} {Model}");

        Console.WriteLine(delimiter);

        ConsoleHelper.Print($"{nameof(Manufacturer)}: {Manufacturer}");
        ConsoleHelper.Print($"{nameof(Model)}: {Model}");
        ConsoleHelper.Print($"{nameof(HorsePowers)}: {HorsePowers} hp.");
        ConsoleHelper.Print($"{nameof(AccelerationTime)}: {AccelerationTime} s.");

        Console.WriteLine(delimiter);

    }
}
