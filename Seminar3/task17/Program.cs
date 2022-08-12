/*
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N. 
Пример:
5 -> 1, 4, 9, 16, 25. 
2 -> 1,4
*/

void TableOfSquaresOr1toN(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($" {i * i} ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableOfSquaresOr1toN(number);
