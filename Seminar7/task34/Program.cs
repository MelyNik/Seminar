/*
Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
Пример:
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

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
