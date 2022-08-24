/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Пример:
45 -> 101101
3  -> 11
2  -> 10
*/
/*

Мой не доделанный вариант:

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

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number;
int result1 = 0;
int result2 = 0;
for(int i = 0; i<number; i++)
{
    result1 = num / 2;
    result2 = num % 2;
}
