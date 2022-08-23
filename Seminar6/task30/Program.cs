/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Пример:
45 -> 101101
3  -> 11
2  -> 10
*/

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
