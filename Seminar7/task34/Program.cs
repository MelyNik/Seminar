/*
Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
Пример:
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
/*

Мой вариант:

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int line = new Random().Next(3, 6);
int column = new Random().Next(3, 6);

int[,] array = new int[line, column];

PrintArray(array);
*/


int[,] TwoDimensionalArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = i + j;
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

Console.WriteLine($"Введите количество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = TwoDimensionalArray(line, columns);
PrintArray(array);
