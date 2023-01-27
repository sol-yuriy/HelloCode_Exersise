/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/


int digit = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(digit, 0, 200);
int[] arrayRevers = GetArrayRevers(array, digit);

Console.WriteLine($"Массив:        [{String.Join(", ", array)}]");
Console.WriteLine($"Новый массив:  [{String.Join(", ", arrayRevers)}]");



//Метод ввода целого цисла пользователем
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

//Метод формирования массива по заданным параметрам
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] element = new int[size];
    for (int i = 0; i < size; i++)
    {
        element[i] = new Random().Next(minValue, maxValue + 1);
    }
    return element;
}

//Метод поэлементного копирования одного массива в другой
int[] GetArrayRevers(int[] list, int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = list[i];
    }
    return result;
}

