/* 
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

Console.Clear();

int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
Console.WriteLine();

if (row != column)
{
    Console.WriteLine("Замена строк на столбцы в данном массиве невозможна!");
    Console.WriteLine("Введите одинаковое количество строк и столбцов в массиве!");
    Console.WriteLine();
    row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
    column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
    Console.WriteLine();
}

Console.WriteLine("Начальный массив:");
int[,] result = GetFillArray(row, column);
GetPrintArray(result, row, column);
Console.WriteLine();
int[,] newArray = GetNewArray(result, row, column);
Console.WriteLine("Новый массив:");
GetPrintArray(newArray, row, column);


// Метод ввода целого числа пользователем
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

// Метод создания и заполнения случайного 2-мерного массива по заданному условию
int[,] GetFillArray(int row, int column)
{
    int min = 0;
    int max = 10;
    int[,] array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

// Метод вывода созданного 2-мерного массива
void GetPrintArray(int[,] array, int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод переворота квадратного массива на 90 градусов: замены строк на столбцы в 2-мерном массиве 
int[,] GetNewArray(int[,] array, int row, int column)
{
    int[,] newArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}
