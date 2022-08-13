/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат ( число умноженное на само себя).
Например:
4 -> 16
-3 -> 19
-7 -> 49
*/
/*

Мой вариант:

Console.WriteLine("Введите число:");
int userNumber = new Random().Next(-10, 10);
Console.WriteLine(userNumber);
Console.WriteLine(userNumber * userNumber);
*/

int userNumber = new int();
Console.WriteLine("Введите число:");
userNumber = Convert.ToInt32(Console.ReadLine()); 
/* 
Console.ReadLine() - Возвращает в программу, то число которое мы ввили в терминале (консоли).
Convert.ToInt32 - преобразует строку (Console.ReadLine()) в числовое значение, так как Console.ReadLine() это строка.
*/

int result = ( userNumber * userNumber);

Console.WriteLine("Степень числа " + userNumber + " = " + result); 
// Или так Console.WriteLine($"Степень числа {userNumber} = {result}"); - Получается общая информация в (") при условии, что в начале $, а числовые данные должны быть в {}
/*
 ("Степень числа "+userNumber+" = "+result) - Конкатенация, т.е. -
- в данном случае "+" выполняет форму склеивание четырёх значение.
*/
