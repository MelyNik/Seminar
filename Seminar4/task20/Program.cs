/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Пример:
456 -> 3
78 -> 2
89126 -> 5
*/

int NumberOfDigits(int number)
{
    int result = 0;
    while (number > 0 || number < 0)
    {
        number = number / 10;
        result++;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр числа {number} = {NumberOfDigits(number)} ");
