/*
Напишите программу, которая выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
Пример:
[1,0,1,1,0,1,0,0]
*/

/*
Как вариант:
Console.WriteLine($"Введите длину массива");
int arrayLength = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[arrayLength];

То есть мы вводим длинну моссива в консоль сами.
*/

int Length = 8;
int[] arr =new int [Length];

void RandomArrayOrder(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

RandomArrayOrder(arr);