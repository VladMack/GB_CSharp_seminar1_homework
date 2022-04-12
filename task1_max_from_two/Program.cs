static int findMax(int number1, int number2)
{
    if (number1 >= number2)
    {
        return (number1);
    }
    else
    {
        return (number2);
    }
}

Console.WriteLine("Введи первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число:");
int b = int.Parse(Console.ReadLine());
int max = findMax(a, b);
Console.WriteLine($"a = {a}; b = {b} -> max = {max}");