/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int digit = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(digit, 1, 10);
int[] arrayMult = GetArrayMult(array, digit);

Console.WriteLine($"Массив [{String.Join(", ", array)}]  -->  [{String.Join(", ", arrayMult)}]");


//Метод произведения полярных элементов начального массива и их запись в другой массив
int[] GetArrayMult(int[] list, int count)
{
    int size = 0;
    if (count % 2 > 0)
        size = (count / 2) + 1;
    else
        size = count / 2;
    int[] multiple = new int[size];

    for (int i = 0; i <= size - 1; i++)     
    //(size - 1) - индекс последнего элемента массива, size - количество элементов
    {
        //if (list[i] != list[count - i - 1])  - не верно, т.к. сравниваю значение элемента, а они могут быть равны
        if (i != (count - i - 1))     // верно, т.к. сравниваю индекс элементе
            multiple[i] = (list[i] * list[count - i - 1]);   
            //[count - i - 1] для правильного учета последнего элемента массива
        else
            multiple[i] = list[i];
    }
    return multiple;
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