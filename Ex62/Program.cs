/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");

int[,] result = GetFillSpiralArray(row, column);

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

//Метод спирального заполнения квадратного массива
int[,] GetFillSpiralArray(int row, int column)
{
    int[,] array = new int[row, column];
    int count = 1;
    for (int j = 0; j < column; j++)                //наполнение верхней строки    
    {
        array[0, j] = count;
        count++;
    }
    for (int i = 1; i < row; i++)                   // наполнение правого столбца
    {
        array[i, column - 1] = count;
        count++;
    }
    for (int j = column - 2; j >= 0; j--)           // наполнение нижней строки
    {
        array[row - 1, j] = count;
        count++;
    }
    for (int i = row - 2; i > 0; i--)               // наполнение левого столбца
    {
        array[i, 0] = count;
        count++;
    }
    int x = 1;
    int y = 1;

    while (count < row * column)                // общий счетчик по наполнению массива
    {
        while (array[x, y + 1] == 0)            // наполнение вправо
        {
            array[x, y] = count;
            count++;
            y++;
        }
        while (array[x + 1, y] == 0)             // Наполнение вниз
        {
            array[x, y] = count;
            count++;
            x++;
        }
        while (array[x, y - 1] == 0)            // наполнение влево
        {
            array[x, y] = count;
            count++;
            y--;
        }
        while (array[x - 1, y] == 0)             // наполнение вверх
        {
            array[x, y] = count;
            count++;
            x--;
        }
        if(row * column - array[x, y-1] == 1 && array[x, y] == 0)
            array[x, y] = count;
        else if (row * column - array[x, y+1] == 1 && array[x, y] == 0)
            array[x, y] = count;
    }
    return array;
}

// Метод вывода 2-мерного массива
void GetPrintArray(int[,] array, int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] < 10)
                Console.Write($"{array[i, j]} ,  ");
            else
                Console.Write($"{array[i, j]},  ");
        }
        Console.WriteLine();
    }
}