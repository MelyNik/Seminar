/*
Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/
/*

Мой вариант:

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[i, j] = array[j, i];
            }
        }
    }
    return arr;
}

Random r = new Random();
int lines = r.Next(3, 6);
int columns = r.Next(3, 6);

int[,] array = GetArray(lines, columns, 1, 20);
PrintArray(array);
Console.WriteLine();
if (lines == columns)
{
    PrintArray(ChangeArray(array));
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! В массиве не могут быть изменены строки на столбцы или на оборот, так как их количество разное.");
    Console.ResetColor();
}
*/

int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    return array;
}

Random r = new Random();
int lines = r.Next(3, 3);
int columns = r.Next(3, 3);

int[,] array = GetArray(lines, columns, 1, 20);
PrintArray(array);
Console.WriteLine();
if (lines == columns)
{
    PrintArray(ChangeArray(array));
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ОШИБКА!!! В массиве не могут быть изменены строки на столбцы или на оборот, так как их количество разное.");
    Console.ResetColor();
}
