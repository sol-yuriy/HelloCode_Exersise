/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/


//2 вариант - с использованием массива

int digit = GetNumberFromUser("Введите десятичное число: ", "Ошибка ввода!");
int sizeBin = GetBinSize(digit);
int[] BinFromDec = GetBinFromDec(digit, sizeBin);

GetBinRevers(BinFromDec);
Console.WriteLine($"Число {digit} в двоичном виде: {String.Join("", BinFromDec)}");



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

//Метод рассчета размера массива
int GetBinSize(int number)
{
    int size = 0;
    if (number < 16) size = 4;
    else if (number < 256) size = 8;
    else if (number < 4095) size = 12;
    else if (number < 65536) size = 16;
    else if (number < 1048576) size = 20;
    return size;
}

//Метод перевода DEC в BIN с записью в массив
int[] GetBinFromDec(int cipher, int size)
{
    int[] bin = new int[size];
    int chast = cipher / 2;
    bin[0] = cipher % 2;

    for (int i = 1; chast > 0; i++)
    {
        int ost = chast % 2;
        chast = chast / 2;
        bin[i] = bin[i] + ost;
    }
    return bin;
}

//Метод переворота получившегося массива - окончательный двоичный вид числа пользователя
void GetBinRevers(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}