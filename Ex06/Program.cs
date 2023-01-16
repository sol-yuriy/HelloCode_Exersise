Console.Write("Введите число на проверку четности: ");
string num = Console.ReadLine() ?? "";
double number = double.Parse(num);
if (number % 2 == 0)
{
    Console.Write($"Число {number} четное");
}
else
{
    Console.Write($"Число {number} НЕчетное");
}