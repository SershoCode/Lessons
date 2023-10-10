namespace Homework.Race;

public static class CarGenerator
{
    private static List<string> Manufacturers = new () { "Audi", "Skoda", "Volkswagen", "Seat", "Cherry", "Lada", "UAZ" };
    private static List<string> Models = new() { "Azumba", "Rumba", "Yumba", "Flower", "Strike", "Pilot", "Speeder" };

    public static Car Generate()
    {
        var manufacturer = Manufacturers.Random();

        var model = Models.Random();

        var horsePowers = new Random().Next(80, 350);

        var accelerationTime = new Random().NextDouble() * 15;

        var car = new Car(manufacturer, model, horsePowers, accelerationTime);

        return car;
    }
}
