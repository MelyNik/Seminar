/*
Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
/*

// Мой вариант:

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

int ReturnArrayIndexLine(int[,] array)
{
    int min = array[0,0];
    int k =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]<min)
            {
                min = array[i,j];
                k = i;
            }
        }
    }
    return k;
}

int ReturnArrayIndexColumn(int[,] array)
{
    int min = array[0,0];
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]<min)
            {
                min = array[i,j];
                l = j;
            }
        }
    }
    return l;
}

void PrintChangeArray(int[,] array, int indexLine, int indexColumn)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i!= indexLine && j!=indexColumn)
            {
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

Random r = new Random();
int lines = r.Next(3,6);
int columns = r.Next(3,6);

int[,] array = GetArray(lines, columns, 1, 20);
PrintArray(array);
Console.WriteLine();

int indexLine = ReturnArrayIndexLine(array);
int indexColumn = ReturnArrayIndexColumn(array);

PrintChangeArray(array,indexLine,indexColumn);
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

int[] ReturnArrayIndexLine(int[,] array)
{
    int min = array[0,0];
    int minIndexI =0;
    int minIndexJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]<min)
            {
                min = array[i,j];
                minIndexI = i;
                minIndexJ = j;
            }
        }
    }
    int[] result = new int [2];
    result[0] =  minIndexI;
    result[1] =  minIndexJ;
    return result;
}

int[,] DeletArray(int[,] array,int[] arr)
{
    int[,] result = new int[array.GetLength(0)-1,array.GetLength(1)-1];
    int minI = arr[0];
    int minJ = arr[1];
    for(int i = 0; i < array.GetLength(0)-1; i++)
    {
        for(int j = 0; j <array.GetLength(1)-1; j++)
        {
            if(i < minI && j<minJ)
            {
                result[i,j] = array[i,j];
            }
            else
            {
                if(i<minI)
                {
                    result[i,j] = array[i,j+1];
                }
                else if(j<minJ)
                {
                    result[i,j] = array[i+1,j];
                }
                else
                {
                    result[i,j] = array[i+1,j+1];
                }
            }
        }
    }
    return result;
}

Random r = new Random();
int lines = r.Next(3,6);
int columns = r.Next(3,6);

int[,] array = GetArray(lines, columns, 1, 20);
PrintArray(array);

int[] indexs = ReturnArrayIndexLine(array);
Console.WriteLine();
array = DeletArray(array,indexs);
PrintArray(array);
