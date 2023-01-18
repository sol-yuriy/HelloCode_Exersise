//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine() ?? "";
int num = int.Parse(number);

int div7 = num % 7;
int div23 = num % 23;

Console.WriteLine(div7);
Console.WriteLine(div23);

if (div7 > 0 || div23 > 0) Console.WriteLine($"{num} --> нет");
else Console.WriteLine($"{num} --> да");