// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Write("Введите первое число: ");
string number1 = Console.ReadLine() ?? "";
int num1 = int.Parse(number1);

Console.Write("Введите второе число: ");
string number2 = Console.ReadLine() ?? "";
int num2 = int.Parse(number2);

int quadro = num1*num1;

if (quadro == num2) Console.WriteLine($"{num1}, {num2} --> да");
else Console.WriteLine($"{num1}, {num2} --> нет");
