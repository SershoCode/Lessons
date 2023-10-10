using Homework.Race;

ConsoleHelper.Print("Генерируем первую машину...");

var carOne = CarGenerator.Generate();

carOne.PrintSpecs();

Console.WriteLine();

ConsoleHelper.Print("Генерируем вторую машину...");

var carTwo = CarGenerator.Generate();

carTwo.PrintSpecs();

Console.WriteLine("Гонка начинается");

var race = new Race();

race.Start(carOne, carTwo);

Console.ReadKey();
