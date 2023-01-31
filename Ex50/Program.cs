/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
int x = GetNumberFromUser("Введите номер строки элемента массива: ", "Ошибка ввода!");
int y = GetNumberFromUser("Введите номер столбца элемента массива: ", "Ошибка ввода!");

var row = new Random().Next(2,20);
int column = new Random().Next(2,50);
int[,] inArray = GetFillArray(row, column);

GetPrintArray(inArray, row, column);
GetPosition(inArray, x, y);



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

//Метод вывода созданного массива
void GetPrintArray(int[,] array, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void GetPosition(int[,] array, int x, int y)
{
    int result = 0;
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        result = array[x,y];
        Console.WriteLine($"Заданный элемент массив: {result}");
    }
    else
    {
        Console.WriteLine($"{x}{y} Такого числа в массиве нет");
    }
}