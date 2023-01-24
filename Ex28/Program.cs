/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/


Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int multNum = GetMultNumbers(num);
Console.WriteLine($"{num} -> {multNum}");

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

int GetMultNumbers(int number)
{
    int mult = 1;
    for(int i = 2; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}
