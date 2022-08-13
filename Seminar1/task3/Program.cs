/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Пример:
4 -> "-4,-3,-2,-1,0,1,2,3,4"
2 -> "-2,-1,0,1,2" 
*/
/*

Мой вариант

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = -number;
while (i <= number)
{
    Console.Write($" {i}");
    i++;
}
*/

Console.WriteLine("Введите число");    
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -number;
     i <= number;
     i++)
{
    Console.Write($" {i}");
}

// Второй вариант решения цикла иначе, разница в том, что мы помещаем i = -number и i++ в сам цикл, и перечисляем через ";".