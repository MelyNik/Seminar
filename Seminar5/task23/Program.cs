/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

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
