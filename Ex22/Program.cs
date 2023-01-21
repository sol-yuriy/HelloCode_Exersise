/* Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4  
*/

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");
int numbers =1;

Console.Write($"{N} --> ");
while (numbers <= N)
{
    Console.Write($" {Math.Pow(numbers, 2)}, ");
    numbers++; 
}
