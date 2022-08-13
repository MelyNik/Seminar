/*
По данному натуральному числу n найдите сумму чисел 1+1/1!+1/2!+1/3!+....+1/n!.
Количество действий должно быть пропорционально n.
Напишите программу, которая считывает значение n и выводит результат в виде действительного числа.
*/



Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

double F = 1;
double result = 1;
double index = 1;
double number = 1;

while (index <= n)
{
    F = F * index;
    result = result + (number / F);
    index++;
}
Console.WriteLine(Math.Round(result, 5));
