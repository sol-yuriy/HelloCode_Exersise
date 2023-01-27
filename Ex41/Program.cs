/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int digit = GetNumberFromUser("Введите количество цифр: ", "Ошибка ввода!");
int[] ArrayFromUser = GetArrayFromUser(digit);
int ArrayPositive = GetArrayPositive(ArrayFromUser, digit);

Console.WriteLine($"Вы ввели: {String.Join(", ", ArrayFromUser)} --> из них чисел больше 0: {ArrayPositive}шт");



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

//Метод формирования массива пользователем
int[] GetArrayFromUser(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        int digit1 = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
        array[i] = digit1;
    }
    return array;
}

//Метод поиска положительных чисел в массиве
int GetArrayPositive(int[] array, int size)
{
    int positive = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i] > 0) positive +=1;
    }
    return positive;
}
