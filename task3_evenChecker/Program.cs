static string checkEven(int number)
{
    if (number % 2 == 0)
    {
        return ("чётное число");
    }
    else
    {
        return ("нечётное число");
    }
}

Console.WriteLine("Введи число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} - {checkEven(number)}.");