/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

/*
Мой вариант:
int length = 12;
int[] arr = new int[length];

void RandomArray(int[] array)
{
    int i = 0;
    int sum1 = 0;
    int sum2 = 0;
    Console.WriteLine($"Элементы массива: ");
    while(i < array.Length)
    {
        array[i] = new Random().Next(-9,9);
        if (array[i] > 0)
        {
            sum1 = sum1 + array[i];
            Console.Write($"{array[i]} ");
        }
        else if (array[i] < 0)
        {
            sum2 = sum2 + array[i];
            Console.Write($"{array[i]} ");
            
        }
        i++;
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов массива = {sum1} ");
    Console.WriteLine($"Сумма отрицательных элементов массива = {sum2} ");
}

RandomArray(arr);
*/
// Преподавателя

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
int positiveSum = 0;
int negativeSum = 0;
foreach(int i in array) // Тут i это не индекс массива, а элемент массива.
// то есть нужно выводить именно i, а под каждой i, будет по очереди выводиться array[0....n].
{
    if(i>0)
    {
        positiveSum = positiveSum + i; // Вместо positiveSum = positiveSum + i, можно использовать positiveSum += i.
    }   
    else
    {
        negativeSum = negativeSum + i; // Вместо positiveSum = positiveSum + i, можно использовать positiveSum += i.
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {positiveSum} ");
Console.WriteLine($"Сумма отрицательных элементов массива = {negativeSum} ");
