/* Итоговая работа:
Написать программу, которая из имеющегося массива строк сформирует новый массив строк, длина которых меньше либо равна 3.
*/

string[] array = { "dhgdfhdf", "df9", "5", "7gt", "398hf", "jhbhf", "/._", "jhgytf545e" };

// определим длину результирующего массива
int size=0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)  size++;

// сформируем новый массив
string[] part = new string[size];
int j=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        part[j] = array[i];
        j++;
    }
}

Console.WriteLine($"{String.Join(", ", part)}");



