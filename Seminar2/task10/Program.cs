/*
Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. 
Пример:
456 -> 46 
782 -> 72 
918 -> 98
*/

/*
int GetRandomNumberInRange(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber, maxNumber + 1);
    return result;
}
int GetDigitFromNumber(int number1, int number2)
{
    int result = number / 10;
    int secondNumber1 = result / 10;
    int secondNumber2 = result % 10;
    return secondNumber1; secondNumber2;
}

Console.WriteLine("Cлучайное трёхзначное число:");
int randomNumber = GetRandomNumberInRange(100, 999);
Console.WriteLine(randomNumber);

Console.WriteLine("Первые две цифры трёхзначного числа: ");
int result = GetDigitFromNumber(randomNumber);
Console.WriteLine(result);
*/

int number = new Random().Next(100,999+1);

Console.WriteLine(number);

int number1 = number / 100;
int number2 = number % 10;

Console.WriteLine($"{number1}{number2}");
