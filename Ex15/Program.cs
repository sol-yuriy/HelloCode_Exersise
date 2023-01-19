// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

Console.Write("Введите номер дня недели: ");
string numb = Console.ReadLine() ?? "";
int num = int.Parse(numb);

if (num == 7 || num == 6)
     Console.WriteLine($"{num} -> да");
else Console.WriteLine($"{num} -> нет");