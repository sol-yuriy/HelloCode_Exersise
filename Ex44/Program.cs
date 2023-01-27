/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int digit = GetNumberFromUser("Введите десятичное число: ", "Ошибка ввода!");

GetSeqFibonacci(digit);


//Метод ввода целого числа пользователем
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

//Метод вывода в терминал ряда Фибоначчи до введенного значения
void GetSeqFibonacci(int number)
{
    Console.Write($" При N = {number}, Ряд Фибоначчи --> ");
    double a = 0;
    Console.Write($" {a}");
    double b = 1;
    Console.Write($" {b}");
    int num = number - 2;
    for (int i = 1; i <= num / 2; i++)
    {
        a = a + b;
        Console.Write($" {a},");
        b = b + a;
        Console.Write($" {b},");
    }
}