/*
Напишите программу, которая на вход принимает 2 числа и проверяет, является ли второе число квадратом первого.
Пример:
a == 5; b == 25 -> Да
a == 2; b == 10 -> Нет
a == 9; b == -3 -> Нет
a == -3; b == 9 *> Да
*/

int userNumber1 = new int ();
Console.WriteLine("Введите первое число:");
userNumber1 = Convert.ToInt32(Console.ReadLine());

int userNumber2 = new int();
Console.WriteLine("Введите второе число:");
userNumber2 = Convert.ToInt32(Console.ReadLine());

if ( userNumber2 == userNumber1 * userNumber1)
{
    Console.WriteLine($"Да, число {userNumber2} является квадратом числа {userNumber1} ");
}
else
{
    Console.WriteLine($"Нет, число {userNumber2} не является квадратом числа {userNumber1} ");
}
