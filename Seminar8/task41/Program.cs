/*
Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника/
*/

int Factorial(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
    {
        result*=i;
    }
    return result;
}

Console.WriteLine($"Введите количество строк треугольника Паскаля: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < number; i++)
{
    for(int j = 0; j <= (number - i); j++)//создаем отступы после каждой строки
    {
        Console.Write(" ");
    }
    for(int j = 0; j <= i; j++)
    {
        Console.Write(" ");//пробелы между элементами треугольника
        Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));//формула вычисления элементов треугольника
    }
    Console.WriteLine();
}


