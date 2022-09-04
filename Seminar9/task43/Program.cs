/*
Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
Пример:
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

int[] DeterminationMaximumNumber(int m, int n)
{
    int[] array = new int[2];
    int max = m;
    int min = n;
    if (n > max)
    {
        max = n;
        min = m;
    }
    array[0] = min;
    array[1] = max;
    return array; 
}


Random r = new Random();
int m = r.Next(1, 9);
Console.WriteLine($"{m} ");
int n = r.Next(1, 9);
Console.WriteLine($"{n} ");
Console.WriteLine();

if (m == n)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! Между {m} и {n} нет промежутке натуральных чисел.");
    Console.ResetColor();
}
else
{
    int[] array = DeterminationMaximumNumber(m,n);
    for(int i = array[0]; i < array[1]+1; i++)
    {
    Console.Write($"{i} \t");
    }
}