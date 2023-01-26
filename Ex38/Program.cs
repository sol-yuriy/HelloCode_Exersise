/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/


int digit = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(digit, 1, 99);
int diffMaxMin = GetDiffMaxMin(array, digit);

Console.WriteLine($"Массив [{String.Join(", ", array)}]  -->  {diffMaxMin}");


//Метод определения разницы между МАКС и МИН элементами массива
int GetDiffMaxMin(int[] list, int count)
{
    int max = 0;
    int min = 0;
    for (int i=0; i < count; i++)
    {
        for (int j = 1; j < count; j++)
        {
            if (list[j] > list[max]) 
                max = j;
            if (list[j] < list[min])
                min = j;
        }
    }
    int result = list[max] - list[min];
    return result;
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




