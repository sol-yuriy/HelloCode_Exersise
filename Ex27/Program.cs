/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int numb = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int resultSum = GetSumNumbers(numb);
Console.WriteLine($"{numb} ->  {resultSum}");

int GetSumNumbers(int numbers)
{
    int sumNumbers = 0;
    for (int i = 1; numbers > 0; i++)
    {
        sumNumbers = sumNumbers + numbers % 10;
        numbers = numbers / 10;
    }
    return sumNumbers;
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


