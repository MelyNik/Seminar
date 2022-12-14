/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Пример:
4 -> 24
5 -> 120

Процесс решения:
1. Задаём число A.
2. Задаём функцию возвращаемого типа, которая будет выдавать сумму чисел от 1 до N.
3. Задаём счётчик который будет увеличиваться, каждый проход цикла.
4. Задать переменную, которая будет содержать в себе всё сумму.
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()); // Тоже самое как и Convert.ToInt32(Console.ReadLine());.

int GetSumNumbers(int number)
{
    int sum = 1;
    int i = 1; // 1 потому, что в условии от единицы.
    while (i <= number) // <= Потому, что до A включительно судя по всему.
    {
        sum *= i; // Означает sum = sum + i.
        i++;
    }
    return sum;
}

Console.WriteLine($"Cумма чисел от 1 до А = {GetSumNumbers(number)}");

