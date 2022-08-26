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

void PrintTwoDimensionalArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(100);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SumPrintArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; i<array.GetLength(1); j++)
        {
            if()
        }
    }
}

int line = new Random().Next(3,6);
int column = new Random().Next(3,6);
int[,] array = new int[line, column];

PrintTwoDimensionalArray(array);