/*
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int a, b, c;

Console.WriteLine($"Введите длину стороны a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите длину стороны b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите длину стороны c: ");
c = Convert.ToInt32(Console.ReadLine());


string Result(int a, int b, int c)
{
    string result = string.Empty;
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        result = "Треугольник существует";
    }
    else
    {
        result = "Треугольник не существует";
    }
    return result;
}

string result = Result(a,b,c);
Console.WriteLine($"{result} ");