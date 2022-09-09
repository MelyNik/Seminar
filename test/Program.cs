int[,] GetArray(int line, int column, int min, int max)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max+1);
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


int lines = 50;
int columns = 50;

int[,] array = GetArray(lines, columns, 1, 10);
PrintArray(array);
int[] result = ChangeArray(array);
result = SortArray(result);
Console.WriteLine();
PrintSortArray(result);
