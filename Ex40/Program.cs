/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Подсказка: Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int side1 = GetNumberFromUser("Введите длину стороны треугольника: ", "Ошибка ввода!");
int side2 = GetNumberFromUser("Введите длину стороны треугольника: ", "Ошибка ввода!");
int side3 = GetNumberFromUser("Введите длину стороны треугольника: ", "Ошибка ввода!");

GetTestTriangle(side1, side2, side3);


//Метод проверки реальности треугольника
void GetTestTriangle(int s1, int s2, int s3)
{
    if ((s1 + s2) > s3 && (s2 + s3) > s1 && (s1 + s3) > s2)
        Console.WriteLine("Треугольник с такими сторонами может существовать");
    else 
        Console.WriteLine("Треугольник с такими сторонами НЕ может существовать");
}

//Метод ввода целого числа пользователем
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}