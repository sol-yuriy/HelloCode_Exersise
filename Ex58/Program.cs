/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/



int row1 = GetNumberFromUser("Введите количество строк 1 массива: ", "Ошибка ввода!");
int column1 = GetNumberFromUser("Введите количество столбцов 1 массива: ", "Ошибка ввода!");
int[,] result1 = GetFillArray(row1, column1);

int row2 = GetNumberFromUser("Введите количество строк 2 массива: ", "Ошибка ввода!");
int column2 = GetNumberFromUser("Введите количество столбцов 2 массива: ", "Ошибка ввода!");
int[,] result2 = GetFillArray(row2, column2);

Console.WriteLine();
Console.WriteLine("Первый массив:");
GetPrintArray(result1, row1, column1);
Console.WriteLine();
Console.WriteLine("Второй массив:");
GetPrintArray(result2, row2, column2);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов:");
GetMultpleArrays(result1, result2);




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
    int min = 1;
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

// Метод перемножения массивов
void GetMultpleArrays(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))                         // Проверка на возможность умножения массивов
    {
        int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];  // Результирующий массив
        for (int i = 0; i < array1.GetLength(0); i++)                       // Прохожу по строкам 1го массива
        {
            for (int j = 0; j < array2.GetLength(1); j++)                   // Прохожу по столбцам 2 массива
            {
                int[] elementArray3 = new int[array1.GetLength(1)];
                for (int n = 0; n < array1.GetLength(1); n++)              // Подсчитываю составляющие каждого элемента нового массива(по кол-ву столбцов 1 матрицы)
                {
                    elementArray3[n] = array1[i, n] * array2[n, j];           
                    // Console.WriteLine($"{String.Join(", ", elementArray3)}");      //Проверка математики элемента нового массива
                    //Console.WriteLine("-");
                }
                array3[i,j] = GetSumElementsArray(elementArray3);
            }
        }
        GetPrintArray(array3, array3.GetLength(0), array3.GetLength(1));
    }
    else
    {
        Console.WriteLine("Эти массивы нельзя перемножить");
    }

}

//Метод вычисления элемента третьего массива
int GetSumElementsArray(int[] array)
{
    int sum = 0;
    for(int i=0; i < array.Length; i++)
        sum += array[i];
    return sum;
}