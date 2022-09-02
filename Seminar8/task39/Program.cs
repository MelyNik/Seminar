/*
Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент входных данных.
Набор данных                    Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }      0 встречается 2 раза
                                1 встречается 1 раз
                                2 встречается 1 раз
                                8 встречается 1 раз
                                9 встречается 3 раза


1, 2, 3                         1 встречается 3 раза
4, 6, 1                         2 встречается 2 раз
2, 1, 6                         3 встречается 1 раз
                                4 встречается 1 раз
                                6 встречается 2 раза
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

int[] ChangeArray(int[,] array)
{
    int[] arr = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[k] = array[i, j];
            k++;
        }
    }
    return arr;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void PrintSortArray(int[] array)
{
    int count = 1;
    int firstNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != firstNumber)
        {
            Console.WriteLine($"{firstNumber} встречается {count} раз(а)");
            firstNumber = array[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{firstNumber} встречается {count} раз(а)");
}

Random r = new Random();
int lines = r.Next(3, 6);
int columns = r.Next(3, 6);

int[,] array = GetArray(lines, columns, 1, 20);
PrintArray(array);
int[] result = ChangeArray(array);
result = SortArray(result);
Console.WriteLine();
PrintSortArray(result);

