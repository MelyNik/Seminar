/*
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
а первый - на последнем и т.д.).
Пример:
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

void RandomArray(int[] array, int minNumber, int maxNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber);
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    Console.WriteLine($"Создан массив: ");
    while (i < array.Length)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
    Console.WriteLine();
}

void ModificationArray(int[] array)
{
    int i = 0;
    int j = array.Length;
    int[] arr = new int[array.Length];
    Console.WriteLine($"Перевёрнутый массив: ");
    while (j > 0)
    {
        arr[i] = array[j-1];
        Console.Write($"{arr[i]} ");
        j = j - 1;
        i++;
    }
    Console.WriteLine();
}

int[] arr = new int[new Random().Next(5, 10)];

RandomArray(arr, 1, 10);
PrintArray(arr);
ModificationArray(arr);