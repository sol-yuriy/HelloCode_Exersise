//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4...  16, 4 -> кратно

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine() ?? "";
int num1 = int.Parse(number1);

Console.WriteLine();

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine() ?? "";
int num2 = int.Parse(number2);

int div = num1 % num2;
if (div > 0) Console.WriteLine($"{num1}, {num2} --> не кратно, остаток {div}");
else Console.WriteLine($"{num1}, {num2} --> кратно");