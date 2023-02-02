/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример:
{ 1, 9, 9, 0, 2, 8, 0, 9 }

0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза

*/


int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите минимальный элемент массива: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите максимальный элемент массива: ", "Ошибка ввода!");
int[,] result = GetFillArray(row, ((byte)column), min, max);
GetPrintArray(result, row, column);
GetDictionaryArray(result, max);


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
int[,] GetFillArray(int row, int column, int min, int max)
{
    //int min = 1;
    //int max = 6;
    int[,] array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

// Метод вывода массива в консоль
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

/*
// Метод (самый ТУПОЙ) подсчета элементов массива
void GetDictionaryArray(int[,] array)
{
    int[] dict = new int[5];
    int count0 = 0;
    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    int count4 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if(array[i,j] == 1)
                {
                    count0+=1;
                    dict[0] = count0;
                }
                else if (array[i,j] == 2)
                {
                    count1+=1;
                    dict[1] = count1;
                }
                else if (array[i,j] == 3)
                {
                    count2+=1;
                    dict[2] = count2;
                }
                else if (array[i,j] == 4)
                {
                    count3+=1;
                    dict[3] = count3;
                }
                else if (array[i,j] == 5)
                {
                    count4+=1;
                    dict[4] = count4;
                }
        }
    }
    Console.WriteLine($"число 1 встречается:  {dict[0]}");
    Console.WriteLine($"число 2 встречается:  {dict[1]}");
    Console.WriteLine($"число 3 встречается:  {dict[2]}");
    Console.WriteLine($"число 4 встречается:  {dict[3]}");
    Console.WriteLine($"число 5 встречается:  {dict[4]}");
}
*/


// Метод подсчета элементов массива
void GetDictionaryArray(int[,] array, int max)
{
    int[] dict = new int[max+1]; //формирую массив значений до max
    int count = 0;
    for (int n = 0; n < max; n++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == n + 1)
                {
                    count += 1;
                    dict[n] = count;
                }
            }
        }
        count = 0;
        Console.WriteLine($"число {n+1} встречается:  {dict[n]}");
    }
}

