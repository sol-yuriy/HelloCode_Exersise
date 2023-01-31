/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int row = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");

int[,] result = GetFillArray(row, column);

GetPrintArray(result, row, column);
GetAverage(result);


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

//Метод создания и заполнения массива по заданному условию
int [,] GetFillArray(int row, int column)
{
    int min = 0;
    int max = 10;
    int [,] array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = rnd.Next(min, max);
        }
    }
    return array;
}

//Метод вывода созданного массива
void GetPrintArray(int[,] array, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Метод рассчета среднего арифметического каждого столбца 2-мерного массива
void GetAverage(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average1 = 0;
        for(int j = 0; j< array.GetLength(0); j++)
        {
            average1 += array[j,i];
        }
        average[i] = Math.Round(average1/array.GetLength(0), 1);
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", average)}");
}
