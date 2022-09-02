/*
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/
/*

Мой вариант:

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line,column];
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    int[,] arr = new int [array.GetLength(0),array.GetLength(1)];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if(i == 0)
            {
                arr[i,j] = array[array.GetLength(0)-1,j];
            }
            else if (i == array.GetLength(0)-1)
            {
                arr[i,j] = array[0,j];
            }
            else
            {
                arr[i,j] = array[i,j];
            }
        }
    }
    return arr;
}

Random random = new Random();
int lines = random.Next(3,6);
int columsn = random.Next(3,6);

int[,] array = GetArray(lines,columsn,-10,20);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(ChangeArray(array));
Console.WriteLine();
*/
// Вариант 2:

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line,column];
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t"); // \t - красиво.
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        int temp = array[0,j];
        array[0,j]=array[array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = temp;
    }
    return array;
}

Random random = new Random();
int lines = random.Next(3,6);
int columsn = random.Next(3,6);

int[,] array = GetArray(lines,columsn,-10,20);
Console.WriteLine();
PrintArray(array);

Console.WriteLine();
PrintArray(ChangeArray(array));