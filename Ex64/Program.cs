/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

int a = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int b = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
Console.WriteLine();
Console.WriteLine($"M = {a}, N = {b}. -> {NumRec(a, b)}");

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

// Метод вывода натур-х чисел от N до 1
string NumRec(int a, int b)
{
    if (a<=b) return $"{a} " + NumRec(a+1, b);
    return String.Empty;
}