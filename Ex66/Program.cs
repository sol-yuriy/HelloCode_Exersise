/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int a = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int b = GetNumberFromUser("Введите число: ", "Ошибка ввода!");

Console.WriteLine();
Console.WriteLine($"Сумма чисел от {a} до {b} = {NumbersRec(a, b)}");

// Метод ввода целого числа пользователем
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Сумма натуральных чисел в заданном диапазоне
int NumbersRec(int a, int b)
{
    if (a <= b)
         return a + NumbersRec(a + 1, b);
    else return 0;
}