/*
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив  Новый массив 
выглядел вот так:            будет выглядеть вот так:
1 4 7 2                      1 4 7 2
5 9 2 3                      5 81 2 9
8 4 2 4                      8 4 2 4
*/

/*

Мой Вариант:

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

void PrintArrayReplacementEvenIndex(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                Console.Write($"{array[i,j]*array[i,j]} ");
            }
            else
            {
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

int line = new Random().Next(3,6);
int column = new Random().Next(3,6);
int[,] array = new int[line, column];

PrintTwoDimensionalArray(array);
Console.WriteLine();
PrintArrayReplacementEvenIndex(array);
*/

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] ChangeArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1);j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] *= array[i,j]; 
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, -99, 100);
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));