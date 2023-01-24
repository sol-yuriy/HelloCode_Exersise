/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.Clear();

int numA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int numB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
int deg = GetDegree(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {deg}");

//Метод возведения числа А в степень (число В) 
int GetDegree(int A, int B)
{
    int degree = A;
    for (int i = 1; i < B; i++)
    {
        degree = degree * A;
    }
    return degree;
}

//Метод ввода целого цисла пользователем
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


