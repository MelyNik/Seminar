/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве. 
Пример:
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки A: ");
double pointAx = Convert.ToDouble(Console.ReadLine());
double pointAy = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double pointBx = Convert.ToDouble(Console.ReadLine());
double pointBy = Convert.ToDouble(Console.ReadLine());

double lengthC = Math.Sqrt(Math.Pow((pointAx - pointBx), 2) + Math.Pow((pointAy - pointBy), 2));
Console.WriteLine(Math.Round(lengthC, 2));   //  Math.Round(lengthC, 2) - означает , что  после запятой оставить 2 знака.
/*
Math.Pow((pointAx - pointBx), 2) - Означает, что выражение (pointAx - pointBx) в квадрате
Math.Pow((...), 2):
Math.Pow - это означает в квадрате
2 - это квадрат, было бы 3 было бы в кубе
*/
/*
Math.Sqrt - означет корень из всего выражения в скобках.
*/


