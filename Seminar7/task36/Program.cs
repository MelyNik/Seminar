/*
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*

Мой вариант:

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumPrintArray(int[,] array)
{
    int sum = 0;
    Console.Write($"Сумма элементов главной диагонали: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
                if (j == array.GetLength(1) - 1 || i == array.GetLength(0)-1)
                {
                    Console.Write($"{array[i, j]} ");
                }
                else
                {
                    Console.Write($"{array[i, j]} + ");
                }
            }
        }
    }
    Console.WriteLine($"= {sum}");
}

int line = new Random().Next(3, 6);
int column = new Random().Next(3, 6);
int[,] array = new int[line, column];

PrintTwoDimensionalArray(array);
SumPrintArray(array);
*/

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line,column];
    for(int i = 0; i<line; i++)
    {
        for(int j = 0; j<column; j++)
        {
            array[i,j] = new Random().Next(min,max);
        }
    }
    return array;
}

int ChangeArray(int[,] array)
{
    int sum = 0;
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите количество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int[,] array = GetArray(line,columns, -99, 100);
PrintArray(array);
sum = ChangeArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
