/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Пример:
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.WriteLine($"Введите число: ");
int number = int.Parse(Console.ReadLine());

int length = new Random().Next(5, 15);
int[] arr = new int[length];

void RandomArray(int[] array, int number)
{
    int i = 0;
    Console.Write($"В данном массиве: ");
    while (i < array.Length)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]} ");
        i++;
    }
    int j = 0;
    int sum = 0;
    while (j < array.Length)
    {
        if (array[j] == number || array[j] == -number)
        {
            sum =  1;
        }
        j++;
    }
    if (sum == 1)
    {
        Console.Write($"присутствует число {number}");
    }
    else
    {
        Console.WriteLine($"отсутствует число {number}");
    }
    Console.WriteLine();
}

RandomArray(arr, number);