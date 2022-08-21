/*
Напишите программу замена элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
Пример:
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

/*
Мой вариант:

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
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size]; // Длина массива.
    for(int i = 0; i < size; i++) // Тут можем указать в место size, res так как к res присвоили длину массива.
    {
        res[i] = new Random().Next(minValue,maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine();

foreach(int i in array) // Тут i это не индекс массива, а элемент массива.
{
    int[] array1 = new int [12];
    int j = 0;
    if(i>0)
    {
        array[j] = i * (-1); 
    }   
    else
    {
        array[j] = i * (-1);  // Вместо positiveSum = positiveSum + i, можно использовать positiveSum += i.
    }
    Console.Write($"{array[j]} ");
    j++;
}


