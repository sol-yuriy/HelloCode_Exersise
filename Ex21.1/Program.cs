/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double dist = 0;

Console.Write("Введите координату Х 1ой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Y 1ой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Z 1ой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Х 2ой точки: ");
int x2 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Y 2ой точки: ");
int y2 = Convert.ToInt32(Console.ReadLine() ?? "");

Console.Write("Введите координату Z 2ой точки: ");
int z2 = Convert.ToInt32(Console.ReadLine() ?? "");

dist = Math.Pow((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 1.0 / 2);

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}. {z2}): -> {Math.Round(dist, 2)}");
