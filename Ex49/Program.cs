/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int[,] result = GetFillArray(row, column);
GetPrintArray1(result, row, column);
Console.WriteLine();
GetPrintArray2(result, row, column);


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
void GetPrintArray1(int[,] array, int row, int column)
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

//Метод вывода массива и замены элементов массива по заданному условию
void GetPrintArray2(int[,] array, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i%2>0 && j%2>0)
            {
                array[i,j] = (int)Math.Pow(array[i,j], 2);
            }
            else
            {
                array[i,j] = array[i,j];
            }
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

