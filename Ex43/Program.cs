/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double b1 = GetNumberFromUser("Введите координату b1: ", "Ошибка ввода!");
double k1 = GetNumberFromUser("Введите координату k1: ", "Ошибка ввода!");
double b2 = GetNumberFromUser("Введите координату b2: ", "Ошибка ввода!");
double k2 = GetNumberFromUser("Введите координату k2: ", "Ошибка ввода!");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
//double y2 = k2 * x + b2;
Console.WriteLine($"Вы ввели: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}  -->  ({x}, {y})");

//Метод ввода целого числа пользователем
double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}