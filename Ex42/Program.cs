/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/


//1 вариант - с использованием типа STRING

int digit = GetNumberFromUser("Введите десятичное число: ", "Ошибка ввода!");
string BinFromDec = GetBinFromDec(digit);
Console.WriteLine($"тестовый вывод неперевернутый: {BinFromDec}");
GetBinRevers(BinFromDec);


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

//Метод перевода DEC в BIN с записью в строковое значение
string GetBinFromDec(int cipher)
{
    string bin = String.Empty;
    int chast = cipher / 2;
    bin = Convert.ToString(cipher % 2);

    for (int i = 1; chast > 0; i++)
    {
        int ost = chast % 2;
        chast = chast / 2;
        bin = bin + Convert.ToString(ost);
    }
    return bin;
}

//Метод переворота строки для корректного вывода BIN-числа (ПОДСМОТРЕЛ)
void GetBinRevers(string BinRevers)
{
    char[] s = BinRevers.ToCharArray();
    Array.Reverse(s);
    Console.WriteLine(s);
}


