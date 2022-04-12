static dynamic generateNumbersArray(int n)
{
    int[] numbersArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введи число {i + 1}:");
        numbersArray[i] = int.Parse(Console.ReadLine());
    }
    return (numbersArray);
}

static int findMax(int[] numbersArray)
{
    int max = numbersArray[0];
    for (int i = 1; i < numbersArray.Length; i++)
    {
        if (numbersArray[i] > max)
        {
            max = numbersArray[i];
        }
    }
    return (max);
}

int[] numbersArray = generateNumbersArray(3);
foreach (int n in numbersArray) Console.Write($"{n} ");
Console.Write($"-> max = {findMax(numbersArray)}");