/*
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Пример:
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

/*

Мой вариант:

Random r = new Random();
int n = r.Next(1, 9);
Console.WriteLine($"{n} ");
Console.WriteLine();

if (n < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! Натуральных чисел в промежутке от 1 до {n} - нет.");
    Console.ResetColor();
}
else
{
    for(int i = 1; i < n+1; i++)
    {
    Console.Write($"{i} \t");
    }
}
*/

string Number(int a, int b)
{
    if(a<=b)
    {
        return $"{a} " + Number(a + 1, b);
    }
    else
    {
        return $"b";
    }
}

Console.WriteLine(Number(1,10));

