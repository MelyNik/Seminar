/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Пример:
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
Мой вариант:

Console.WriteLine($"Введи длину чисел Фибоначчи");
int number = Convert.ToInt32(Console.ReadLine());

void LengthOfNumbersFibonacci(int number)
{
    if (number == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"ОШИБКА!!! Числа Фибоначчи длинной {number} не могут быть отображены.");
        Console.ResetColor();
    }
    else if (number == 1)
    {
        Console.WriteLine($"Числа Фибоначчи длинной {number} = 0");
    }
    else if (number == 2)
    {
        Console.WriteLine($"Числа Фибоначчи длинной {number} = 0 1");
    }
    else if (number == 3)
    {
        Console.WriteLine($"Числа Фибоначчи длинной {number} = 0 1 1");
    }
    else
    {
        int i = 3;
        int digit1 = 1;
        int digit2 = 1;
        int sum = 0;
        Console.Write($"Числа Фибоначчи длинной {number} = 0 1 1 ");
        while (i < number)
        {
            sum = digit1 + digit2;
            Console.Write($"{sum} ");
            digit2 = sum;
            digit1 = sum - digit1;
            i++;
        }
        Console.WriteLine();
    }
}

LengthOfNumbersFibonacci(number);

*/

Console.WriteLine($"Введите длину чисел Фибоначчи: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] LengthFibonacci(int length)
{
    int[] arr = new int[length];
    arr[0] = 0;
    arr[1] = 1;
    int i = 2;
    while (i < arr.Length)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
        i++;
    }
    return arr;
}

void PrintArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        if (i == 0)
        {
            Console.Write($"[");
        }
        if (i< array.Length-1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
        i++;
    }
    Console.WriteLine();
}

int[] array = LengthFibonacci(length);
PrintArray(array);

