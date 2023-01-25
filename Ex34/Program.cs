/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int digit = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(digit, 100, 1000);
int ArrayHonestElements = GetArrayHonestElements(array, digit);

Console.WriteLine($"Массив [{String.Join(", ", array)}]  -->  {ArrayHonestElements}");


//Метод определения четных элементов массива 
int GetArrayHonestElements(int[] list, int count)
{
    int honest = 0;
    for (int i = 0; i < count; i++)     
    {
        if (list[i] % 2 == 0)
            honest++; 
    }
    return honest;
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




