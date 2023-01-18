//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите 3х значное число: ");
string numb=Console.ReadLine() ?? "";
int num = int.Parse(numb);

//int a1 = rnd / 100;
int a2 = (num / 10) % 10;
//int a3 = rnd % 10;

Console.WriteLine($"{num} : {a2}");