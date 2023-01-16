Console.Write("Введите номер дня недели: ");
string number = Console.ReadLine() ?? "";

double num = double.Parse(number);

if (num == 1)
{
    Console.Write($"{num} --> Понедельник");
}
else if (num == 2)
{
    Console.Write($"{num} --> Вторник");
}
else if (num == 3)
{
    Console.Write($"{num} --> Среда");
}
else if (num == 4)
{
    Console.Write($"{num} --> Четверг");
}
else if (num == 5)
{
    Console.Write($"{num} --> Пятница");
}
else if (num == 6)
{
    Console.Write($"{num} --> Суббота");
}
else if (num == 7)
{
    Console.Write($"{num} --> Воскресенье");
}
else
{
    Console.Write("Попробуйте еще раз. Введите число от 1 до 7");
}
