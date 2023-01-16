Console.Write("Введите число: ");
string num = Console.ReadLine() ?? "";
int number = int.Parse(num);
int i = 1;
while (i < number)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
i++;
}