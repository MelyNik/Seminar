/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
// Random rnd = new Random(); Означает, что мы к переменной rnd присвоили рандом, 
// int number = rnd.Next(100); а к переменной number присволии переменную rnd от 0 до 100.
// arr[i] = number; Тут к массиву с индексом i присвоили переменную number к корой ранее присвоили рандом.


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Console.WriteLine($"Создан массив: ");
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue);
    }
    return array;
}

int[] ReversArray(int[] array)
{
    int[] arr = new int[array.Length];
    for(int i = 0; i<array.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

int[] array = GetArray(10, 1, 10);
Console.WriteLine(String.Join(" ",array));
int[] coppyArray = ReversArray(array);
Console.WriteLine(String.Join(" ",coppyArray));