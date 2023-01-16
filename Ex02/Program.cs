Console.Write("Введите 1ое число: ");
string num1 = Console.ReadLine();

int num_1 = int.Parse(num1);                                    //преобразую строку в целое число 

Console.Write("Введите 2ое число: ");
string num2 = Console.ReadLine();

int num_2 = int.Parse(num2);                                    //преобразую строку в целое число 

double result = Math.Pow(num_2, 2);                             // возвожу в степень 2ое число, чтобы сравнить с 1ым

if (result == num_1)
{
    Console.Write($"a = {num_1}, b = {num_2} --> YES");         //сравниваю, если 1е число = 2ое ^2, то вывожу YES
}
else
{
    Console.Write($"a = {num_1}, b = {num_2} --> NO");          //сравниваю, если 1е число <> 2ое ^2, то вывожу NO
}