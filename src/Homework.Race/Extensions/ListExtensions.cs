namespace Homework.Race;

public static class ListExtensions
{
    public static string Random(this List<string> collection)
    {
        return collection[new Random().Next(0, collection.Count)];
    }
}
