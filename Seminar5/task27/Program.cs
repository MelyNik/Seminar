/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int length = new Random().Next(3, 15);
int[] arr = new int[length];

void RandomArray(int[] array)
{
    int i = 0;
    Console.Write($"Пердоcтавлен массив: ");
    while (i < array.Length)
    {
        array[i] = new Random().Next(1, 21);
        Console.Write($"{array[i]} ");
        i++;
    }
    Console.WriteLine();
}

void ProductsOfArrayNumbers(int[] array)
{
    if (array.Length == array.Length / 2 * 2)
    {
        int i = 0;
        int j = array.Length - 1;
        Console.Write($"Произведение крайних чиселмассива: ");
        while (i < array.Length / 2)
        {
            int composition = array[i] * array[j];
            j = j - 1;
            Console.Write($"{composition} ");
            i++;
        }
        Console.WriteLine();
    }
    else
    {
        int i = 0;
        int digit = 0;
        int j = array.Length - 1;
        Console.Write($"Произведение крайних чисел массива: ");
        while (i < array.Length / 2)
        {
            int composition = array[i] * array[j];
            j = j - 1;
            Console.Write($"{composition} ");
            i++;
        }
        digit = array.Length / 2;
        Console.Write($"{array[digit]}");
        Console.WriteLine();
    }
}

RandomArray(arr);
ProductsOfArrayNumbers(arr);