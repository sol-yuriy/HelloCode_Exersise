/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/


int digit = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(digit, 0, 200);
int digitFind = GetDigitFind(array, 10, 99);

Console.WriteLine($"Массив [{String.Join(", ", array)}]  -->  {digitFind}");


//Метод поиска числа в массиве в заданном диапазоне
int GetDigitFind(int[] list, int number1, int number2)
{
    int count = list.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (list[i] > number1 && list[i] < number2)
        {
            result += 1;
        }
    }
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
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
