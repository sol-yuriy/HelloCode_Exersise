// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
string numb = Console.ReadLine() ?? "";
int num = int.Parse(numb);

int divMillion = num % 1000000;

Console.WriteLine($"{divMillion}");

if (divMillion > 10)
{
    int divMillion = num % 10000000;
}