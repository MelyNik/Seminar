/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления. 
Пример:
34, 5 -> не кратно, остаток 4 16, 4 -> кратно
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 

if( number2 % number1 == 0 )
{
    Console.WriteLine();
    Console.WriteLine($"{number2} кратно {number1}");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"{number2} не кратно {number1}");
    int result = number2 % number1;
    Console.WriteLine($"Остаток: {result}");
}

