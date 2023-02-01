/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/




int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int[,] result = GetFillArray(row, column);
GetPrintArray(result, row, column);
Console.WriteLine();
int[,] newArray = GetNewArray(result, row, column);
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


// Метод замены 1ой и последней строк в 2-мерном массиве
int[,] GetNewArray(int[,] array, int row, int column)
{
    int[] temp = new int[column];
    for (int j = 0; j < column; j++)
    {
        temp[j] += array[0, j];
        array[0, j] = array[row - 1, j];
        array[row - 1, j] = temp[j];
    }
    return array;
}
