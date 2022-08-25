/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Пример:
45 -> 101101
3  -> 11
2  -> 10
*/
/*

Мой не доделанный первый вариант:

Console.WriteLine($"Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());

void BinaryNumber(int number)
{
    int binary = 2;
    int binaryNumber = number;
    int sum = number;
    if(binaryNumber == 1)
    {
        Console.WriteLine($"{binaryNumber} ");
    }
    {
        binaryNumber = binaryNumber / binary;
        Console.Write($"{sum - (binary * binaryNumber) }");
        sum = sum / binaryNumber;
    }
}
*/

/*

Мой не доделанный второй вариант:

int[] BinaryArray(int number)
{
    int num = number;
    int result = 0;
    int j = 0;
    int[] arr = new int[j];
    while (num > 0)
    {
        result = num % 2;
        num = num / 2;
        if (result > 0)
        {
            arr[j] = 1;
        }
        else
        {
            arr[j] = 0;
        }
        j++;
    }
    return arr;
}

int[] ReversArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int j = 0; j < arr.Length; j++)
    {
        array[j] = arr[arr.Length - 1 - j];
    }
    return array;
}

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = BinaryArray(number);
Console.WriteLine($"{arr}");

int[] revers = ReversArray(arr);
Console.WriteLine($"{revers}");

*/

/*

Вариант с семинара не доделанный:

Console.WriteLine($"Ввидети число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = number;
int remains = 0;
while(digit>0)
{
    remains = digit % 2;
    Console.Write($"{remains} ");
    digit = digit / 2;  
    int i = 0;
    int[] arr = new int[i];
    arr[i] = remains;
    i++;
}
Console.WriteLine();

 Задача не решена из за преподователя !!!

*/
/*

Вариант через рекурсия, но не работает на больше числа:

Console.WriteLine($"Введите число: ");
int number = int.Parse(Console.ReadLine());

int TenToTwo(int number)
{
    if(number == 1)
    {
        return 1;
    }
    else if (number == 0)
    {
        return 0;
    }
    return number % 2 + 10 * TenToTwo(number/2);
}
int result = TenToTwo(number);
Console.WriteLine($"{result} ");
*/