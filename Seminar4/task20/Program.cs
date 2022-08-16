/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Пример:
456 -> 3
78 -> 2
89126 -> 5
*/

string NumberOfDigits(string text)
{
    string Length = text.Length;
    Length = Convert.ToInt32;
    return Length;
}

Console.WriteLine("Введите число: ");
string text = Console.ReadLine();

int Length = NumberOfDigits(text);
Console.WriteLine(Length);