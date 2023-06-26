// Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(n, 10, 99);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
Console.WriteLine($"[{string.Join(",", array)}]");

int min = 99;
int max = 0;
foreach (int el in array)  
{
    if (el < min) min = el;
    if (el > max) max = el;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");





