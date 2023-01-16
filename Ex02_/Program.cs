Console.Write("Введите 1ое число: ");
string num1=Console.ReadLine() ?? "";
int num_1=int.Parse(num1);

Console.Write("Введите 2ое число: ");
string num2=Console.ReadLine() ?? "";
int num_2=int.Parse(num2);

if (num_1 > num_2)
{
    Console.WriteLine($"a = {num_1}, b = {num_2}, max = {num_1}");
}
else
{
    Console.WriteLine($"a = {num_1}, b = {num_2}, max = {num_2}");
}