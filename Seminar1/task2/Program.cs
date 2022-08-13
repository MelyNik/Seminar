/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру
*/


int day = new int();
Console.WriteLine("Введите номер дня недели");
day = Convert.ToInt32(Console.ReadLine());

if ( day <  1 ) Console.WriteLine("Дня недели с таким номером, не существует");  // Можно написать так if ( day < 1 || day > 7), где || знак "или"
else if ( day >  7 ) Console.WriteLine("Дня недели с таким номером, не существует");
else if ( day == 1 ) Console.WriteLine("Название первого дня недели - понедельник");
else if ( day == 2 ) Console.WriteLine("Название второго дня недели - вторник");
else if ( day == 3 ) Console.WriteLine("Название третьего дня недели - среда");
else if ( day == 4 ) Console.WriteLine("Название четвёртого дня недели - четверг");
else if ( day == 5 ) Console.WriteLine("Название пятого дня недели - пятница");
else if ( day == 6 ) Console.WriteLine("Название шестого дня недели - суббота");
else if ( day == 7 ) Console.WriteLine("Название седьмого дня недели - воскресение");

// Команда при зажатии сочетания клавиш cntrl+alt+стрелочки вверх или вниз, позволяет писать одновременном в выделенных строках одинаковый текст.