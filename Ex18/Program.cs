/***Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*

Вариант 1. Простой, без проверки исключений.

Console.Write("Введите номер координатной четверти (от 1 до 4): ");
int quarter = Convert.ToInt32(Console.ReadLine() ?? "");

if (quarter == 1) Console.WriteLine("X > 0, Y > 0");
else if (quarter == 2) Console.WriteLine("X < 0, Y > 0");
else if (quarter == 3) Console.WriteLine("X < 0, Y < 0");
else if (quarter == 4) Console.WriteLine("X > 0, Y < 0");
else Console.WriteLine("Ошибка в выборе четверти");                 


Вариант 2. С использованием методов*/

int quarter=9;

InputQuarter(ref quarter);
IdentXY(quarter);


static void InputQuarter(ref int quarter)
{
    while (true)
    {
        Console.Write("Введите номер координатной четверти (от 1 до 4): ");
        try
        {
            quarter = Convert.ToInt32(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода номера четверти! {exc.Message}");
        }
    }
}

static void IdentXY(int quarter)
{
    if (quarter == 1) Console.WriteLine("X > 0, Y > 0");
    else if (quarter == 2) Console.WriteLine("X < 0, Y > 0");
    else if (quarter == 3) Console.WriteLine("X < 0, Y < 0");
    else if (quarter == 4) Console.WriteLine("X > 0, Y < 0");
    else Console.WriteLine("Ошибка в выборе четверти");
}
