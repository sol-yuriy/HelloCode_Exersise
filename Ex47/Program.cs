/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Пример:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
double[,] result = GetFillArray(row, column);
GetPrintArray(result, row, column);


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
double [,] GetFillArray(int row, int column)
{
    int min = -10;
    int max = 10;
    double [,] array = new double[row, column];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = Math.Round((rnd.Next(min, max) + Math.Round(rnd.NextDouble(), 2)), 1);
        }
    }
    return array;
}

//Метод вывода созданного массива
void GetPrintArray(double[,] array, int row, int column)
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
