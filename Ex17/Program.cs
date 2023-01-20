/****17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.***/

//Console.Clear();

Console.Write("Введите координаты точки Х: ");
int X = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты точки Y: ");
int Y = int.Parse(Console.ReadLine() ?? "");

if (X > 0 && Y > 0) Console.Write("для этих координат - четверть 1");
else if (X > 0 && Y < 0) Console.Write("для этих координат - четверть 4");
else if (X < 0 && Y < 0) Console.Write("для этих координат - четверть 3");
else if (X < 0 && Y > 0) Console.Write("для этих координат - четверть 2");
else Console.Write("ошибка ввода координат");