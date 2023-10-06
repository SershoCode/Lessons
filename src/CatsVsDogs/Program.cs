namespace Cats;

// 1. Нам нужны котики
// 1.1. У них должны быть:
//      - Имя, Сила, Возраст
// 1.2. Они должны уметь:
//     - Кусаться, Здороваться.

public class Program
{
    public static void Main()
    {
        var cat = new Cat( "Barnie",3,20);

        Console.WriteLine(cat.Name);
        Console.WriteLine(cat.Age);
        Console.WriteLine(cat.Power);

        // Укусить.
        cat.Bite();

        // Поздороваться
        cat.SayHello("Здарова, заебал");

        Console.ReadLine();
    }
}

