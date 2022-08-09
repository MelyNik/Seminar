/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
наибольшую цифру числа. 
Пример:
78 -> 8
12 -> 2
85 -> 8
*/

int GetRandomNumberInRange(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber, maxNumber + 1);
    return result;
}

int GetMaxDigitFromNumber(int number)
{
    int result = number / 10;
    int secondDigit = number % 10;
    if (secondDigit > result)
    {
        result = secondDigit;
    }
    return result;
}

for (int i = 0; i < 10; i++)
{
    int randomNumber = GetRandomNumberInRange(10, 99);

    Console.WriteLine();
    Console.WriteLine($"Cлучайное число - {randomNumber}");
    Console.WriteLine();

    int maxDigit = GetMaxDigitFromNumber(randomNumber);

    Console.WriteLine($"Наибольшая цифра числа - {randomNumber}, число - {maxDigit}");
    Console.WriteLine();
}