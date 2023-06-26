// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GetArray(10, -10, 100);
Console.WriteLine($"[{string.Join(",", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int kol(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

Console.Write($"Cумма элементов, стоящих на нечётных позициях: {kol(array)}");

