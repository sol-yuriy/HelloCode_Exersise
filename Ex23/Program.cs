/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");
int numbers =1;

Console.Write($"{N} --> ");
while (numbers <= Math.Abs(N))
{
    Console.Write($" {Math.Pow(numbers, 3)}, ");
    numbers++; 
}
