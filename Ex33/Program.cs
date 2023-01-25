/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
string value = "ДА";

int digit = GetNumberFromUser("Введите искомое целое число: ", "Ошибка ввода!");
int[] array = GetRandomArray(20, -10, 10);
string digitFind = GetDigitFind(array, digit, value);

if (digitFind == value)
{
    Console.WriteLine($"{digit}; массив [{String.Join(", ", array)}]  -->  ДА");
}
else
{
    Console.WriteLine($"{digit}; массив [{String.Join(", ", array)}]  -->  НЕТ");
}


//Метод поиска заданного числа в массиве
string GetDigitFind(int[] list, int number, string value)
{
    int count = list.Length;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        if (list[i] == number)
        {
            result += $"{value}";
            break;
        }
    }
    return result;
}

//Метод формирования массива по заданным параметрам
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] element = new int[size];
    for (int i = 0; i < size; i++)
    {
        element[i] = new Random().Next(minValue, maxValue + 1);
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
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}