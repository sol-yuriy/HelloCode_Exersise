/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

int x1x2 = 0;
int y1y2 = 0;
double dist = 0;

Console.Write("Введите координату Х 1ой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Y 1ой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Х 2ой точки: ");
int x2 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Y 2ой точки: ");
int y2 = Convert.ToInt32(Console.ReadLine() ?? "");

if (x1 < 0 || x2 < 0)
    x1x2 = Math.Abs(x1) + Math.Abs(x2);
else if (x1 < 0 && x2 < 0)
    x1x2 = Math.Abs(x1 - x2);
else if (x1 > 0 && x2 > 0)
    x1x2 = Math.Abs(x1 - x2);

if (y1 < 0 || y2 < 0)
    y1y2 = Math.Abs(y1) + Math.Abs(y2);
else if (y1 < 0 && y2 < 0)
    y1y2 = Math.Abs(y1 - y2);
else if (y1 > 0 && y2 > 0)
    y1y2 = Math.Abs(y1 - y2);

dist = Math.Pow((Math.Pow(x1x2, 2) + Math.Pow(y1y2, 2)), 1.0 / 2);

Console.WriteLine($"расстояние между точками по Х: {x1x2}");
Console.WriteLine($"расстояние между точками по Y: {y1y2}");
Console.WriteLine($"расстояние между точками: {dist}");