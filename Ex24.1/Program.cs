/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3.  78 -> 2.  89126 -> 5
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int countNum = GetCountNumbers(num);
Console.WriteLine($"{num} -> {countNum}");

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

int GetCountNumbers(int count)
{
    int i = 0;
    while (true)
    {
        count = count / 10;
        i++;
        if (count == 0) break;
    }
    return i;
}