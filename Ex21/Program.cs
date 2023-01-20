/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

double dist = 0;

Console.Write("Введите координату Х 1ой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Y 1ой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Х 2ой точки: ");
int x2 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Y 2ой точки: ");
int y2 = Convert.ToInt32(Console.ReadLine() ?? "");

dist = Math.Pow((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 1.0 / 2);

Console.WriteLine($"A ({x1}, {y1}), B ({x2}, {y2}): {Math.Round(dist, 2)}");