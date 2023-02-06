/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

Console.Clear();

int row = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int column = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
int range = GetNumberFromUser("Введите количество рядов массива: ", "Ошибка ввода!");

int[,,] result = GetFillArray(row, column, range);
GetPrintArray(result, row, column, range);


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

// Метод создания и заполнения случайного 3-мерного массива по заданному условию
int[,,] GetFillArray(int row, int column, int range)
{
    int min = 10;
    int max = 100;
    int element = 0;
    int[,,] array3D = new int[row, column, range];
    var rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < range; k++)
            {
                while (true)
                {
                        element = rnd.Next(min, max);
                        //Console.WriteLine($"**** Рандом - {element} ?");
                        int unic = GetTestUniqueElementArray(array3D, element);
                        if (unic == 1)
                        {
                            array3D[i, j, k] = element;
                            //Console.WriteLine($"Присвоен номер  - {array3D[i, j, k]} - флаг {unic}");
                            break;
                        }
                        else
                            Console.WriteLine("Есть повтор!");      // Покажет количество повторов
                }
            }
        }
    }
    return array3D;
}

// Метод проверки ина уникальность элемента массива
int GetTestUniqueElementArray(int[,,] array, int unique)
{
    int flag = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == unique)
                {
                    flag = 2;                   //Элемент есть в списке! Пропустить его.
                    //Console.WriteLine($"УЖЕ Присутствует - {flag}");
                    goto Search;
                    //break;
                }
                else
                    flag = 1;
            }
        }
    }
    Search:
    return flag;
}

// Метод вывода созданного 3-мерного массива
void GetPrintArray(int[,,] array, int row, int column, int range)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < range; k++)
            {
                Console.Write($"Элемент ({i}, {j}, {k}) = {array[i, j, k]} ");
                Console.WriteLine();
            }
        }
    }
}