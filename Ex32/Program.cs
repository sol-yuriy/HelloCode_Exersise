/*Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/
Console.Clear();
int[] array = GetRandomArray(15, -100, 100);
Console.WriteLine($"Начальный массив:    [{String.Join(", ", array)}]");

int[] arrayTrans = GetTransMinusPlusElementsArray(array);

// ??? Почему если 6 строку закоментить, а 11 включить, то начальный массив будет таким же как конечный ???
//Console.WriteLine($"Начальный массив:    [{String.Join(", ", array)}]");
Console.WriteLine($"Перевернутый массив: [{String.Join(", ", arrayTrans)}]");



//Метод формирования массива по заданному пользователем количеству
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] element = new int[size];
    for (int i = 0; i < size; i++)
    {
        element[i] = new Random().Next(minValue, maxValue + 1);
    }
    return element;
}

//Метод который меняет положительные элементы массива на отрицательные
int[] GetTransMinusPlusElementsArray(int[] arrayTranse)
{
    for (int i = 0; i < arrayTranse.Length; i++)
    {
        arrayTranse[i] *= -1;
    }
    return arrayTranse;
}