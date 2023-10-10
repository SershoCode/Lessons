namespace Homework.Race;

public class Race
{
    public void Start(Car carOne, Car carTwo)
    {
        var carOneWinPoints = 0;
        var carTwoWinPoints = 0;

        // Проверяем, у кого больше лошадиных сил.
        if (carOne.HorsePowers > carTwo.HorsePowers)
            carOneWinPoints++;
        else
            carTwoWinPoints++;

        // Проверяем, у кого быстрее скорость разгона.
        if(carOne.AccelerationTime < carTwo.AccelerationTime)
            carOneWinPoints++;
        else
            carTwoWinPoints++;

        // Подготавливаем строку под имя победителя
        var winner = string.Empty;

        if (carOneWinPoints > carTwoWinPoints)
            winner = $"{carOne.Manufacturer} {carOne.Model}";
        else if (carTwoWinPoints > carOneWinPoints)
            winner = $"{carTwo.Manufacturer} {carTwo.Model}";
        else
            winner = "дружба";

        Console.WriteLine($"В гонке победила: {winner}");
    }
}
