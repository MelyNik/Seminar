/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Пример:
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/


/*

Мой Вариант:
void PrintTwoDimensionalArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-99, 100);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int line = new Random().Next(3,8);
int column = new Random().Next(3,8);

int[,] array = new int[line, column];

PrintTwoDimensionalArray(array);

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

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
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
