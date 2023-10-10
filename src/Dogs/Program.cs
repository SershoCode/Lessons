namespace Dogs;

// Свойства наших собачек: Имя, Порода, Рост, Вес.
// Действия наших собачек: Поиск

public class Program
{
    public static void Main()
    {
        var dog = new Dog("Зельда", "Овчарка", 70, 35.8f);

        Console.WriteLine($"Dog name: {dog.Name}");
        Console.WriteLine($"Dog breed: {dog.Breed}");
        Console.WriteLine($"Dog growth: {dog.Growth}");
        Console.WriteLine($"Dog weight: {dog.Weight}");

        dog.Search("drugs");

        Console.ReadLine();
    }
}