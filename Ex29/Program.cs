/*Задача 29: Напишите программу, которая позволяет пользователю задать массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/


Console.Clear();

int num = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] arr = MakeArray(num);
PrintArray(arr);

//Метод вывода массива на печать
void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < count - 1) Console.Write(", ");
    }
    Console.Write(" ]");
}

//Метод формирования массива по заданному пользователем размеру и элементам массива
int[] MakeArray(int num)
{
    int[] element = new int[num];
    for (int i = 0; i < num; i++)
    {
        element[i] = GetNumberFromUser("Введите элемент массива: ", "Ошибка ввода!");
    }
    return element;
}

//Метод ввода целого цисла пользователем
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return Math.Abs(userNumber);
        Console.WriteLine(errorMessage);
    }
}

