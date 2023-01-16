Console.Write("введите число: ");
//string userInput = Console.ReadLine() ?? "";

//int number = int.Parse(userInput);
int number = int.Parse(Console.ReadLine() ?? "");

//int result = (int)Math.Pow(number, 3);
double result = Math.Pow(number, 3);
//int result = number ^ 2;

Console.Write($"{number} в квадрате -> {result}");

