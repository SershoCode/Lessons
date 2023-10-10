using Homework.Race;

Console.ReadKey();

ConsoleHelper.Print("Генерируем первую машину...");

var carOne = CarGenerator.Generate();

carOne.PrintSpecs();

Console.WriteLine();

ConsoleHelper.Print("Генерируем вторую машину...");

var carTwo = CarGenerator.Generate();

carTwo.PrintSpecs();

Console.ReadKey();
