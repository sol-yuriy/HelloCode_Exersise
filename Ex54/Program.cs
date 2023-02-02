/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/





int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int[,] result = GetFillArray(row, column);
GetPrintArray(result, row, column);
Console.WriteLine();
GetRegulMaxToMinArray(result);
Console.WriteLine("Упорядоченный массив:");
GetPrintArray(result, row, column);


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
            array[i, j] = rnd.Next(min, max);
    }
    return array;
}

// Метод вывода созданного 2-мерного массива
void GetPrintArray(int[,] array, int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

// Метод упорядочивания по убыванию элементов массива построчно
void GetRegulMaxToMinArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int n = j + 1; n < array.GetLength(1); n++)
            {
                if (array[i, n] > array[i, maxPosition])
                    maxPosition = n;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temp;
        }
    }
}
