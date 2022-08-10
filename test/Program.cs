Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else
{
    int devision = number / 100;
    int index = 0;
    while (devision > 1)
    {
        index++;
        devision = devision / 10;
    }
    int thirdNumber = 0;
    if (index > 1)
    {
        int degree = 10;
        int i = 1;
        while (i < index)
        {
            thirdNumber = number / degree % 10;
            degree = degree * 10;
            i++;
        }
    }
    else
    {
        thirdNumber = number % 10;
    }
    if (thirdNumber > 0)
    {
        Console.WriteLine($"Третей цифрой числа {number} является {thirdNumber}");
    }
    else
    {
        Console.WriteLine($"Третей цифрой числа {number} является {-thirdNumber}");
    }
}