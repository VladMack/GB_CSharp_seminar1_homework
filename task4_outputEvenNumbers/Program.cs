static bool checkEven(int number)
{
    if (number % 2 == 0)
    {
        return (true);
    }
    else
    {
        return (false);
    }
}

static string outputEvenNumbers(int number)
{
    string evenNumbers = "";
    for (int i = 1; i <= number; i++)
    {
        if (checkEven(i) == true)
        {
            evenNumbers += $" {i}";
        }
    }
    if (evenNumbers == "")
    {
        return ("нет");
    }
    else
    {
        return (evenNumbers);
    }
}

Console.WriteLine("Введи число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Чётные числа в диапазоне от 1 до {number}:{outputEvenNumbers(number)}.");