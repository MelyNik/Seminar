/*
Напишите программу, которая выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
Пример:
[1,0,1,1,0,1,0,0]
*/

int Length = 8;
int[] arr =new int [Length];

void RandomArrayOrder(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[] array)
{
    int i = 0;
    int Langth = array.Length;
    while(i <Langth)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
    Console.WriteLine();
}

RandomArrayOrder(arr);
PrintArray(arr);