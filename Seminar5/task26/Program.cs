/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int length = 123;
int[] arr = new int[length];

void FindingTheSpecifiedIntervalOfTheArray(int[] array)
{
    int i = 0;
    int sum = 0;
    Console.WriteLine($"Предоставлен массив: ");
    while(i < array.Length)
    {
        array[i] = new Random().Next(0,123);
        Console.Write($"{array[i]} ");
        if (array[i]<99 && array[i] > 9)
        {
            sum = sum + 1;
        }
        i++;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Количество значений находящихся в отрезке от 10 до 99 = {sum} ");
    Console.WriteLine();
}

FindingTheSpecifiedIntervalOfTheArray(arr);