namespace Cats;

public class Cat
{
    public string Name { get; set; } // Свойство: Имя
    public int Age { get; set; }    // Свойство: Возраст
    public int Power { get; set; }  // Свойство: Сила

    // При создании класса конструктор выполняется первым.
    public Cat(string name, int age, int power)
    {
        Name = name;
        Age = age;
        Power = power;
    }

    // Метод: Укус
    public void Bite()
    {
        Console.WriteLine("Я укусил");
    }

    // Метод: Поздороваться
    public void SayHello(string greetingText)
    {
        Console.WriteLine($"{greetingText}! Меня зовут {Name}");
    }
}
