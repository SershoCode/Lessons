namespace Dogs;

public class Dog
{
    public string Name { get; set; }    // Имя.
    public string Breed { get; set; }   // Порода.
    public int Growth { get; set; }     // Рост.
    public float Weight { get; set; }   // Вес.

    public Dog(string name, string breed, int growth, float weight)
    {
        Name = name;
        Breed = breed;
        Growth = growth;
        Weight = weight;
    }

    public void Search(string lookFor)
    {
        Console.WriteLine($"Меня зовут {Name}, я нашла: {lookFor}");
    }
}
