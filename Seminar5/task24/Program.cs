/*
Напишите программу замена элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
Пример:
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int length = 12;
int[] arr = new int[length];

void RandomArray(int[] array)
{
    int i = 0;
    Console.WriteLine($"Элементы массива до преобразования: ");
    while (i < array.Length)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write($"{array[i]} ");
        i++;
    }
    Console.WriteLine();
}

void NegativeAndPositiveTransformations(int[] array)
{
    int i = 0;
    Console.WriteLine($"Элементы массива после преобразования: ");
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            array[i] = 0 - array[i];
            Console.Write($"{array[i]} ");
        }
        else if (array[i]<0)
        {
            array[i] = 0 - array[i];
            Console.Write($"{array[i]} ");
        }
        else 
        {
            Console.Write($"{array[i]} ");
        }
        i++;
    }
    Console.WriteLine();
}

RandomArray(arr);
NegativeAndPositiveTransformations(arr);