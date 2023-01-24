/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.Clear();

int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");

int i = 0;
int[] element = new int[num];
Console.Write("[ ");
while (i < num)
{
    element [i] = new Random().Next(0, 2);
    Console.Write($"{element[i]} ");
    i++;
}
Console.Write("]");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return Math.Abs(userNumber);
        Console.WriteLine(errorMessage);
    }
}
