/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/



int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int[,] result = GetFillArray(row, column);
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
int[,] GetFillArray(int row, int column)
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

//Метод вывода созданного массива и расчет диагонали
void GetPrintArray(int[,] array, int row, int column)
{
    int result = 0;
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i==j)
                result = result + array[i,j];
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма элементов главной диагонали: {result}");
}
