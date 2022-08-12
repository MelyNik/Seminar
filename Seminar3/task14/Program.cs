/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
*/

void PrintNumberQuarterCoordinateSystem (int x, int y)
{
    int result = 0;
    if(x > 0 && y > 0)
    {
        result = 1;
        Console.WriteLine($"Для координат {x}:{y} находятся в {result} четверти");
    }
    else if(x < 0 && y > 0)
    {
        result = 2;
        Console.WriteLine($"Для координат {x}:{y} находятся в {result} четверти");
    }
    else if(x < 0 && y < 0)
    {
        result = 3;
        Console.WriteLine($"Для координат {x}:{y} находятся в {result} четверти");
    }
    else if ( x > 0 && y < 0)
    {
        result = 4;
        Console.WriteLine($"Для координат {x}:{y} находятся в {result} четверти");
    }
    else if( x == 0 || y == 0 )
    {
        result = 0;
        Console.ForegroundColor = ConsoleColor.Red; // Окрасили текст ниже в красный.
        Console.WriteLine($"ОШИБКА!: X или Y не должны быть равны 0, вы ввели x -> {x} y -> {y}");
        Console.ResetColor();
    }
}

Console.WriteLine("Введите координаты точки: X");
int userX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки: Y");
int userY = Convert.ToInt32(Console.ReadLine());

PrintNumberQuarterCoordinateSystem(userX, userY);
