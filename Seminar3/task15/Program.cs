/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

// Пограмма не работает в этом варианте 
/*
void PrintNumberQuarterCoordinateSystem (int numberQuarter,int[] PositiveNumber,int[] NegativeNumber)
{
    if( numberQuarter == 1)
    {
        Console.WriteLine($"Диапазон возможных координат x - {PositiveNumber} ");
        Console.WriteLine($"Диапазон возможных координат y - {PositiveNumber} ");
    }
    else if(numberQuarter == 2)
    {
        Console.WriteLine($"Диапазон возможных координат x - {NegativeNumber} ");
        Console.WriteLine($"Диапазон возможных координат y - {PositiveNumber} ");
    }
    else if(numberQuarter == 3)
    {
        Console.WriteLine($"Диапазон возможных координат x - {NegativeNumber} ");
        Console.WriteLine($"Диапазон возможных координат y - {NegativeNumber} ");
    }
    else if ( numberQuarter == 4)
    {
        Console.WriteLine($"Диапазон возможных координат x - {PositiveNumber} ");
        Console.WriteLine($"Диапазон возможных координат y - {NegativeNumber} ");
    }
    else if( numberQuarter > 4 || numberQuarter < 4 )
    {
        Console.ForegroundColor = ConsoleColor.Red; // Окрасили текст ниже в красный.
        Console.WriteLine($"ОШИБКА!: Номера четверти {numberQuarter} не существует ");
        Console.ResetColor();
    }
}

void NewPositiveArray(int[] collection)  // Void означает, что из этой функции мы ни чего 
                                   // не будем возвращать, т.е. в конце функции
                                   // не должно быть команды return.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void NewNegativeArray(int[] collection)  // Void означает, что из этой функции мы ни чего 
                                   // не будем возвращать, т.е. в конце функции
                                   // не должно быть команды return.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-1, -10);
        index++;
    }
}

Console.WriteLine("Введите номеру четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

int arraySize = 10;

int[] PositiveNumber = new int[arraySize];
int[] NegativeNumber = new int[arraySize];

NewPositiveArray(PositiveNumber);
NewNegativeArray(NegativeNumber);

PrintNumberQuarterCoordinateSystem(quarter, PositiveNumber, NegativeNumber);
*/

// Вариант 2

void PrintNumberQuarterCoordinateSystem (int numberQuarter)
{
    if( numberQuarter == 1)
    {
        Console.WriteLine("Диапазон возможных координат x - ( от 0 до бесконечности ) ");
        Console.WriteLine("Диапазон возможных координат y - ( от 0 до бесконечности ) ");
    }
    else if(numberQuarter == 2)
    {
        Console.WriteLine("Диапазон возможных координат x - ( от 0 до  минус бесконечности ) ");
        Console.WriteLine("Диапазон возможных координат y - ( от 0 до бесконечности ) ");
    }
    else if(numberQuarter == 3)
    {
        Console.WriteLine("Диапазон возможных координат x - ( от 0 до  минус бесконечности ) ");
        Console.WriteLine("Диапазон возможных координат y - ( от 0 до  минус бесконечности ) ");
    }
    else if ( numberQuarter == 4)
    {
        Console.WriteLine("Диапазон возможных координат x - ( от 0 до бесконечности ) ");
        Console.WriteLine("Диапазон возможных координат y - ( от 0 до  минус бесконечности ) ");
    }
    else if( numberQuarter > 4 || numberQuarter < 4 )
    {
        Console.ForegroundColor = ConsoleColor.Red; // Окрасили текст ниже в красный.
        Console.WriteLine($"ОШИБКА!: Номера четверти {numberQuarter} не существует ");
        Console.ResetColor();
    }
}

Console.WriteLine("Введите номеру четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

PrintNumberQuarterCoordinateSystem(quarter);