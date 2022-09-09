/*
Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
Пример:
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

/*

Мой вариант:

int Exponentiation(int a, int b)
{
    if( b == 0)
    {
        return 1;
    }
    else
    {
        return Exponentiation(a, b - 1) * a;
    }
}

Console.WriteLine($"Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(numberA,numberB);
Console.WriteLine(result);
*/
/*
Или

int Rec(int numberA, int numberB)
{
    return numberB == 0 ? 1 : Rec(numberA, numberB-1) * numberA;
}
Console.WriteLine(Rec(3,5));
*/


int Rec(int numberA, int numberB)
{
    if (numberB == 1)
    {
        return 1; 
    }  
    else
    {
        return Rec(numberA, numberB-1) * numberA;
    }
}
Console.WriteLine(Rec(3,5));


