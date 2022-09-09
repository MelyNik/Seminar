/*
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
Пример:
453 -> 12
45 -> 9
*/
/*

Мой вариант:

int SumDigitsNumber(int number)
{
    int k = 0;
    int sum = number;
    while (sum % 10 != 0)
    {
        sum = sum / 10;
        k++;
    }
    int result = 0;
    int remains = 0;
    for (int i = k; i > 0; i--)
    {
        remains = number % 10;
        number = number / 10;
        result = result + remains;
    }
    return result; 
}

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigitsNumber(number);

Console.WriteLine($"Сумма цифр числа {number} = {result}");

*/

int Rec(int number)
{
    if(number==0)
    {
        return 0;
    }
    else
    {
        return number%10 + Rec(number/10);;
    }
}
Console.WriteLine(Rec(456));