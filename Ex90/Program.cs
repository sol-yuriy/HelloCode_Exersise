/* Итоговая работа:
Написать программу, которая из имеющегося массива строк сформирует новый массив строк, длина которых меньше либо равна 3.
*/

//Ввод данных
int size = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
string[] array = GetStringArray(size);
int count = GetSizeNewArray(array);
string[] newArray = GetNewArray(array, count);

//Вывод данных
Console.WriteLine();
Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");
Console.WriteLine();
Console.WriteLine($"Новый массив: [ {String.Join(", ", newArray)} ]");


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

// Метод формирования начального строкового массива с терминала
string[] GetStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите символы элемента массива: ");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

// Метод определения длины результирующего массива
int GetSizeNewArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) size++;
    return size;
}

// Метод формирования нового массива с элементами не более 3х символов
string[] GetNewArray(string[] array, int size)
{
    string[] part = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            part[j] = array[i];
            j++;
        }
    }
    return part;
}


