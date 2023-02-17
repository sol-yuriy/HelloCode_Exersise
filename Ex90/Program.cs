/* Итоговая работа:
Написать программу, которая из имеющегося массива строк сформирует новый массив строк, длина которых меньше либо равна 3.
*/

int size = GetNumberFromUser("Введите количество элементов массива': ", "Ошибка ввода!");




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

// Метод формирования начального строкового массива
string[] GetStringArray(int size)
{
    string[] array = new string[size];
    for (int i=0; i<size;i++)
        array[i] = Console.ReadLine() ?? "";
    return array;
}

string[] array = { "dhgdfhdf", "df9", "5", "7gt", "398hf", "jhbhf", "/._", "jhgytf545e" };

// определим длину результирующего массива
int size=0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)  size++;

// сформируем новый массив
string[] part = new string[size];
int j=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        part[j] = array[i];
        j++;
    }
}
// вывод массива
Console.WriteLine($"{String.Join(", ", part)}");