/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int digit = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(digit, -10, 10);
int SumUnevenElements = GetSumUnevenElements(array, digit);

Console.WriteLine($"Массив [{String.Join(", ", array)}]  -->  {SumUnevenElements}");


//Метод определения нечетных элементов массива и их суммы
int GetSumUnevenElements(int[] list, int count)
{
    int sumUneven = 0;
    for (int i = 0; i < count; i++)     
    {
        if (i % 2 != 0)
            sumUneven += list[i]; 
    }
    return sumUneven;
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










