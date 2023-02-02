/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/





int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int[,] result = GetFillArray(row, column);
GetPrintArray(result, row, column);
Console.WriteLine();
int[] SumsRowsArray = GetSumsRowsArray(result);
GetMinSumElementsRowArray(SumsRowsArray);



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

// Метод нахождения сумм элементов каждой строки массива
int[] GetSumsRowsArray(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    Console.WriteLine($"Суммы строк массива по порядку: {String.Join(", ", sum)} ");
    return sum;
}

void GetMinSumElementsRowArray(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min])
            min = i;
    }
    Console.WriteLine($"Минимальная сумма в строке {min}");
}
