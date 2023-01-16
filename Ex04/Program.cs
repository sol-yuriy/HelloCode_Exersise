Console.Write("Введите 1ое число: ");
string num1=Console.ReadLine() ?? "";
int num_1=int.Parse(num1);

Console.Write("Введите 2ое число: ");
string num2=Console.ReadLine() ?? "";
int num_2=int.Parse(num2);

Console.Write("Введите 3е число: ");
string num3=Console.ReadLine() ?? "";
int num_3=int.Parse(num3);

int max = 0;

if (num_1 > num_2)
{
    max = num_1;
}
else
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.Write($"Максимальное из 3х чисел: {max}");